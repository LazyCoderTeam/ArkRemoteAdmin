﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ArkRemoteAdmin.SourceRcon.HighLevel.Commands;
using ConcurrentPriorityQueue;

namespace ArkRemoteAdmin.SourceRcon.HighLevel
{
    class RconClient
    {
        #region Events

        public event EventHandler Connecting;
        public event EventHandler Connected;
        public event EventHandler<string> ConnectionFailed;
        public event EventHandler<bool> Disconnected;
        public event EventHandler<CommandExecutedEventArgs> CommandExecuted;

        #endregion // Events

        private readonly ConcurrentPriorityQueue<KeyValuePair<Command, EventHandler<CommandExecutedEventArgs>>, int> queue;
        private readonly ManualResetEvent resetEvent;
        private readonly SourceRcon.Rcon rcon;
        private readonly Thread workerThread;
        private bool cancel;

        public bool IsConnected => rcon.Connected;

        public RconClient()
        {
            queue = new ConcurrentPriorityQueue<KeyValuePair<Command, EventHandler<CommandExecutedEventArgs>>, int>();
            resetEvent = new ManualResetEvent(false);
            workerThread = new Thread(ExecuteCommandWorker);
            workerThread.IsBackground = true;
            workerThread.Start();
            rcon = new SourceRcon.Rcon();
        }

        public bool Connect(string host, int port, string password)
        {
            Connecting?.Invoke(this, EventArgs.Empty);

            try
            {
                if (!rcon.Connect(host, port))
                    throw new Exception("Connection to server failed. Check your host and port.");

                if (!rcon.Authenticate(password))
                {
                    Disconnect();
                    throw new Exception("Authentication with server failed. The password is incorrect.");
                }
            }
            catch (Exception ex)
            {
                ConnectionFailed?.Invoke(this, ex.Message);
                throw;
            }

            Connected?.Invoke(this, EventArgs.Empty);

            return true;
        }

        public void Disconnect()
        {
            resetEvent.Reset();
            lock (queue)
                queue.Clear();

            rcon.Disconnect();
            Disconnected?.Invoke(this, true);
        }

        public void ExecuteCommandAsync(Command command, EventHandler<CommandExecutedEventArgs> callback)
        {
            lock (queue)
                queue.Enqueue(new KeyValuePair<Command, EventHandler<CommandExecutedEventArgs>>(command, callback), 5);

            resetEvent.Set();
        }

        public void ExecuteLowPrioCommandAsync(Command command, EventHandler<CommandExecutedEventArgs> callback)
        {
            lock (queue)
            {
                if (!queue.Any(q => q.Key.Type != command.Type))
                {
                    queue.Enqueue(new KeyValuePair<Command, EventHandler<CommandExecutedEventArgs>>(command, callback), 1);
                    resetEvent.Set();
                }
            }
        }

        private void ExecuteCommandWorker()
        {
            while (!cancel)
            {
                if (queue.Count > 0)
                {
                    KeyValuePair<Command, EventHandler<CommandExecutedEventArgs>> entry;
                    lock (queue)
                        entry = queue.Dequeue();

                    try
                    {
                        RconPacket request = new RconPacket(PacketType.ServerdataExeccommand, entry.Key.ToString());
                        RconPacket response = rcon.SendReceive(request);

                        var commandExecutedEventArgs = new CommandExecutedEventArgs()
                        {
                            Successful = response != null,
                            Error = "",
                            Response = response?.Body.Trim(),
                            Command = entry.Key
                        };
                        entry.Value?.Invoke(this, commandExecutedEventArgs);
                        CommandExecuted?.Invoke(this, commandExecutedEventArgs);
                    }
                    catch (Exception ex)
                    {
                        var commandExecutedEventArgs = new CommandExecutedEventArgs()
                        {
                            Successful = false,
                            Error = ex.Message,
                            Response = "",
                            Command = entry.Key
                        };
                        entry.Value?.Invoke(this, commandExecutedEventArgs);
                        CommandExecuted?.Invoke(this, commandExecutedEventArgs);
                    }
                }

                if (queue.Count == 0)
                    resetEvent.Reset();

                resetEvent.WaitOne();
            }
        }
    }
}

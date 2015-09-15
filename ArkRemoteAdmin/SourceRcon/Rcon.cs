﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArkRemoteAdmin.SourceRcon
{
    class Rcon
    {
        private Socket socket;

        public bool Connected
        {
            get { return socket != null && socket.Connected; }
        }

        public bool Connect(string host, int port)
        {
            if (string.IsNullOrEmpty(host))
                throw new ArgumentNullException(nameof(host), "The host can not be empty");
            if (port < 1 || port > 655359)
                throw new ArgumentOutOfRangeException(nameof(port), "The provided port is not valid");

            if (socket == null)
                socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
            socket.ReceiveTimeout = 30000;
            socket.ReceiveBufferSize = 4096;
            socket.SendTimeout = 5000;
            socket.SendBufferSize = 4096;
            IAsyncResult result = socket.BeginConnect(host, port, null, null);
            if (!result.AsyncWaitHandle.WaitOne(5000))
            {
                socket.Close();
                socket = null;
            }

            return Connected;
        }

        public void Disconnect()
        {
            if (Connected)
            {
                socket.Close();
                socket = null;
            }
        }

        public bool Authenticate(string password)
        {
            if (string.IsNullOrEmpty(password))
                throw new ArgumentNullException(nameof(password), "The password can not be empty");

            if (!Connected)
                throw new Exception("You must be connected before authenticating");

            RconPacket response = SendReceive(new RconPacket(PacketType.ServerdataAuth, password));

            return response.Id != -1;
        }

        public RconPacket SendReceive(RconPacket packet)
        {
            if (packet == null)
                throw new ArgumentNullException(nameof(packet));

            if (!Connected)
                throw new Exception("You must be connected before sending data");

            // Send
            socket.Send(packet);

            // Receive
            byte[] buffer = new byte[socket.ReceiveBufferSize], data;
            int size = -1, counter = 0;
            using (MemoryStream ms = new MemoryStream())
            {
                do
                {
                    int count = socket.Receive(buffer);
                    ms.Write(buffer, 0, count);

                    if (size == -1 && ms.Length >= 4)
                        size = ms.ToArray().ToInt32(0);

                    if (socket.Available == 0 && (size > -1 && size + 4 > ms.Length))
                    {
                        Thread.Sleep(50);
                        if (counter++ >= 3)
                            break;
                    }
                } while (socket.Available > 0 || (size > -1 && size + 4 > ms.Length));

                data = ms.ToArray();
            }

            return (RconPacket)data;
        }
    }
}

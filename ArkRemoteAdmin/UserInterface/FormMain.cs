using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using ArkRemoteAdmin.Core;
using ArkRemoteAdmin.Data;
using ArkRemoteAdmin.Properties;
using ArkRemoteAdmin.UserInterface;
//using BssFramework.Windows.Forms;
using Rcon;
using Rcon.Commands;

namespace ArkRemoteAdmin
{
    public partial class FormMain : Form
    {
        private SynchronizationContext syncContext;
        private FormWindowState savedState;

        public FormMain()
        {
            InitializeComponent();

            //toolStrip.Renderer = new SevenToolStripRenderer();
            //cmsTray.Renderer = new SevenToolStripRenderer();

            players.SetStatus = SetStatus;
            server.SetStatus = SetStatus;
            chat.SetStatus = SetStatus;
            console.SetStatus = SetStatus;

            if (!Updater.Exists())
                tsbUpdate.Visible = false;
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            // Set synchronization context
            syncContext = SynchronizationContext.Current;

            if (Updater.Exists())
                Updater.CheckSilent();

            //Version version = await Updater.CheckWebVersion();
            //if (version != null)
                //notifyIcon.ShowBalloonTip(3000, "Update available", $"A new version ({version}) is available. Click here to get it!", ToolTipIcon.Info);

            // Register Events
            ArkRcon.Client.Connecting += Client_Connecting;
            ArkRcon.Client.Connected += Client_Connected;
            ArkRcon.Client.ConnectionFailed += Client_ConnectionFailed;
            ArkRcon.Client.Disconnected += Client_Disconnected;

            // Connect to default server
            Server defaultServer = Data.Data.Servers.FirstOrDefault(s => s.Default);

            if (defaultServer != null)
            {
                try
                {
                    ArkRcon.Connect(defaultServer);
                    //Rcon.Connect(defaultServer);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                    //new TaskDialog()
                    //{
                    //    WindowTitle = "Connection failed",
                    //    MainInstruction = ex.Message,
                    //    Content = "Make sure that the server is online and configured correctly.",
                    //    CommonButtons = TaskDialogCommonButtons.Ok,
                    //    MainIcon = TaskDialogIcon.Warning,
                    //    PositionRelativeToWindow = true
                    //}.Show(this);
                }
            }
        }

        private void Client_Connecting(object sender, EventArgs e)
        {
            syncContext.Post(state =>
            {
                progressOverlay.showOverlay();
            }, null);
        }

        private void Client_ConnectionFailed(object sender, string e)
        {
            syncContext.Send(state => progressOverlay.hideOverlay(), null);
        }

        private void Client_Connected(object sender, EventArgs e)
        {
            syncContext.Send(state =>
            {
                progressOverlay.hideOverlay();
                tsbConnect.Visible = false;
                tsbDisconnect.Visible = true;
                toolStripSeparator1.Visible = true;
                tsbSaveWorld.Visible = true;
                tsExitServer.Visible = true;

                tabControl1.Visible = true;

                tslConnection.Image = Resources.connect;
                tslConnection.Text = "Connected to " + ArkRcon.ConnectedServer.Name;
            }, null);

            SetStatus("Connected");
        }

        private void Client_Disconnected(object sender, bool requested)
        {
            syncContext.Send(state =>
            {
                tsbConnect.Visible = true;
                tsbDisconnect.Visible = false;
                toolStripSeparator1.Visible = false;
                tsbSaveWorld.Visible = false;
                tsExitServer.Visible = false;

                tabControl1.Visible = false;

                tslConnection.Image = Resources.disconnect;
                tslConnection.Text = "Not Connected";
            }, null);

            SetStatus("Disconnected");

            if (!requested)
            {
                // Reconnect
                try
                {
                    ArkRcon.Connect(ArkRcon.ConnectedServer);
                }
                catch (Exception)
                {
                    syncContext.Send(state =>
                    {
                        MessageBox.Show("Make sure the server is online and configured", "Reconnection Failed");

                        //new TaskDialog()
                        //{
                        //    WindowTitle = "Reconnect failed",
                        //    MainInstruction = "Reconnect failed",
                        //    Content = "Make sure that the server is online and configured correctly.",
                        //    CommonButtons = TaskDialogCommonButtons.Ok,
                        //    MainIcon = TaskDialogIcon.Warning,
                        //    PositionRelativeToWindow = true
                        //}.Show(this);
                    }, null);
                }
            }
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                ShowInTaskbar = false;
            else
            {
                savedState = WindowState;
                ShowInTaskbar = true;
            }
        }

        public void SetVisible()
        {
            WindowState = savedState;
        }

        private void tsbConnect_Click(object sender, EventArgs e)
        {
            (new ServerList()).ShowDialog();
        }

        private void tsbSaveWorld_Click(object sender, EventArgs e)
        {
            ArkRcon.Client.ExecuteCommandAsync(new SaveWorld(), WorldSaved);
        }

        private void WorldSaved(object sender, CommandExecutedEventArgs e)
        {
            if (e.Successful)
                SetStatus("World saved");
            else
                SetStatus("World save failed", StatusType.Error);

        }

        private void tsbDisconnect_Click(object sender, EventArgs e)
        {
            ArkRcon.Client.Disconnect();
            //Rcon.Disconnect();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            (new FormAbout()).ShowDialog();
        }

        private void tsbDonate_Click(object sender, EventArgs e)
        {
            Process.Start(tsbDonate.Tag.ToString());
        }

        private void tsExitServer_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show( "Are you sure you want to shut down the server?\r\nBe sure to save your world before you should the server down.", "Exit Server", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                ArkRcon.Client.ExecuteCommandAsync(new DoExit(), ServerExited);
            }
        }

        private void ServerExited(object sender, CommandExecutedEventArgs e)
        {
            if (e.Successful)
            {
                SetStatus("Server shutting down");
                ArkRcon.Client.Disconnect();
            }
            else
                SetStatus("Server could not be shut down", StatusType.Error);
        }

        private void tsbSettings_Click(object sender, EventArgs e)
        {
            (new FormSettings()).ShowDialog();
        }

        public void SetStatus(string status, StatusType type = StatusType.Ok)
        {
            syncContext.Post(state =>
            {
                var statusType = (StatusType)state;
                toolStripStatusLabel1.Text = status.ToString();
                switch (statusType)
                {
                    case StatusType.Ok:
                        toolStripStatusLabel3.Image = Resources.ok;
                        break;
                    case StatusType.Warning:
                        toolStripStatusLabel3.Image = Resources.warning;
                        break;
                    case StatusType.Error:
                        toolStripStatusLabel3.Image = Resources.error;
                        break;
                }
                listView1.Items.Add(new ListViewItem(status.ToString())
                {
                    ForeColor = statusType == StatusType.Ok ? System.Drawing.Color.Green : statusType == StatusType.Warning ? System.Drawing.Color.Goldenrod : System.Drawing.Color.Red,
                    ImageIndex = statusType == StatusType.Ok ? 0 : statusType == StatusType.Warning ? 1 : 2
                });
            }, type);
        }

        private void tsbWebsite_Click(object sender, EventArgs e)
        {
            Process.Start(tsbWebsite.Tag.ToString());
        }

        private void tsbUpdate_Click(object sender, EventArgs e)
        {
            Updater.CheckNow();
        }

        private void tslLog_Click(object sender, EventArgs e)
        {
            panel1.BringToFront();
            panel1.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel1.SendToBack();
        }

        #region Tray Icon

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                WindowState = savedState;
        }

        private void cmsTray_Opening(object sender, CancelEventArgs e)
        {
            showToolStripMenuItem.Visible = WindowState == FormWindowState.Minimized;
            hideToolStripMenuItem.Visible = WindowState != FormWindowState.Minimized;
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = savedState;
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WindowState = savedState;
            Close();
        }

        #endregion // Tray Icon

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tpChat)
                chat.FocusMessage();
            else if (tabControl1.SelectedTab == tpConsole)
                console.FocusMessage();
        }

        private void notifyIcon_BalloonTipClicked(object sender, EventArgs e)
        {
            //BssFramework.Utils.OpenWebsite(new Uri("http://steamcommunity.com/app/346110/discussions/0/530646715638980889/"));
        }
    }

    public enum StatusType
    {
        Ok,
        Warning,
        Error
    }
}

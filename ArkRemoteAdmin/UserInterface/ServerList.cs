using System;
using System.Linq;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ArkRemoteAdmin.Data;
//using BssFramework.Windows.Forms;
using ArkRcon = ArkRemoteAdmin.Core.ArkRcon;

namespace ArkRemoteAdmin.UserInterface
{
    public partial class ServerList : Form
    {
        public ServerList()
        {
            InitializeComponent();
            //toolStrip.Renderer = new SevenToolStripRenderer();
            //cmsServer.Renderer = new SevenToolStripRenderer();
        }

        private void ServerList_Load(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void lvServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Server server = GetSelectedServer();

            tsbConnect.Visible = server != null;
            tsbEdit.Visible = server != null;
            tsbDelete.Visible = server != null;
            tsbSetDefault.Visible = server != null && !server.Default;
            tsbRemoveDefault.Visible = server != null && server.Default;
            toolStripSeparator3.Visible = server != null;
            toolStripSeparator4.Visible = server != null;
            toolStripSeparator5.Visible = server != null;

            connectToolStripMenuItem.Visible = server != null;
            copyAddressToolStripMenuItem.Visible = server != null;
            editServerToolStripMenuItem.Visible = server != null;
            deleteServerToolStripMenuItem.Visible = server != null;
            setAsDefaultToolStripMenuItem.Visible = server != null && !server.Default;
            removeDefaultToolStripMenuItem.Visible = server != null && server.Default;
        }

        #region Menu Commands

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            if ((new WizardAddServer()).ShowDialog() == DialogResult.OK)
                RefreshList();
        }

        private void cmsServer_Opening(object sender, CancelEventArgs e)
        {
            if (lvServers.SelectedItems.Count != 1)
                e.Cancel = true;
        }

        private void lvServers_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                connectToolStripMenuItem_Click(sender, EventArgs.Empty);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = GetSelectedServer();
            if (server != null)
            {
                try
                {
                    if (ArkRcon.Connect(server))
                        Close();
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

        private void copyAddressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = GetSelectedServer();
            if (server != null)
                Clipboard.SetText($"{server.Host}:{server.Port}");
        }

        private void editServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = GetSelectedServer();
            if (server != null)
            {
                if ((new WizardAddServer(server)).ShowDialog() == DialogResult.OK)
                    RefreshList();
            }
        }

        private void deleteServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = GetSelectedServer();
            if (server != null)
            {
                if (ShowServerDeletionDialog() == DialogResult.Yes)
                {
                    Data.Data.Remove(server);
                    foreach (var schedule in Data.Data.Schedules.Where(s => s.ServerId == server.Id))
                        Data.Data.Remove(schedule);

                    RefreshList();
                }
            }
        }

        private void setAsDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server selectedServer = lvServers.SelectedItems[0].Tag as Server;

            if (selectedServer != null)
            {
                foreach (var server in Data.Data.Servers)
                {
                    server.Default = server == selectedServer;
                    Data.Data.Set(server);
                }

                RefreshList();
            }
        }

        private void removeDefaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Server server = GetSelectedServer();

            if (server != null && server.Default)
            {
                server.Default = false;
                Data.Data.Set(server);
            }

            RefreshList();
        }

        #endregion // Menu Commands

        #region Internal Methods

        private Server GetSelectedServer()
        {
            if (lvServers.SelectedItems.Count == 1)
                return lvServers.SelectedItems[0].Tag as Server;

            return null;
        }

        private void RefreshList()
        {
            lvServers.Items.Clear();

            foreach (Server server in Data.Data.Servers)
            {
                ListViewItem item = new ListViewItem(new[] { server.Name, server.Host, server.Port.ToString() }) { Tag = server };
                if (server.Default)
                    item.Font = new Font(item.Font, FontStyle.Bold);

                lvServers.Items.Add(item);
            }

            lvServers_SelectedIndexChanged(this, new EventArgs());
        }

        private DialogResult ShowServerDeletionDialog()
        {
            return MessageBox.Show("Do you really want to delete this server?", "Confirm", MessageBoxButtons.YesNo);
            //TaskDialog taskDialog = new TaskDialog
            //{
            //    WindowTitle = "Delete Server",
            //    MainInstruction = "Do you really want to delete this server?",
            //    Content = "This can not be undone.",
            //    CommonButtons = TaskDialogCommonButtons.Yes | TaskDialogCommonButtons.No,
            //    MainIcon = TaskDialogIcon.Warning,
            //    PositionRelativeToWindow = true
            //};

            //return (DialogResult)taskDialog.Show(this);
        }

        #endregion // Internal Methods
    }
}

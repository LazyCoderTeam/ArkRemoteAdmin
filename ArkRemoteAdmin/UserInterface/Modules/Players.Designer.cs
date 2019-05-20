//using BssFramework.Windows.Forms;

namespace ArkRemoteAdmin.UserInterface
{
    partial class Players
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Online Players", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("Banned Players", System.Windows.Forms.HorizontalAlignment.Left);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Players));
            this.lvPlayers = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSteamId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsPlayer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openSteamProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.copyNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySteamIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.kickToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.banToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unbanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.addToWhitelistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeFromWhitelistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbRefresh = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbKick = new System.Windows.Forms.ToolStripButton();
            this.tsbBan = new System.Windows.Forms.ToolStripButton();
            this.tsbUnban = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbAddWhitelist = new System.Windows.Forms.ToolStripButton();
            this.tsbRemoveWhitelist = new System.Windows.Forms.ToolStripButton();
            this.cmsPlayer.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvPlayers
            // 
            this.lvPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colSteamId});
            this.lvPlayers.ContextMenuStrip = this.cmsPlayer;
            this.lvPlayers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvPlayers.FullRowSelect = true;
            listViewGroup1.Header = "Online Players";
            listViewGroup1.Name = "lvgOnline";
            listViewGroup2.Header = "Banned Players";
            listViewGroup2.Name = "lvgBanned";
            this.lvPlayers.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
            this.lvPlayers.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvPlayers.Location = new System.Drawing.Point(0, 25);
            this.lvPlayers.Name = "lvPlayers";
            this.lvPlayers.Size = new System.Drawing.Size(601, 338);
            this.lvPlayers.TabIndex = 3;
            this.lvPlayers.UseCompatibleStateImageBehavior = false;
            this.lvPlayers.View = System.Windows.Forms.View.Details;
            this.lvPlayers.SelectedIndexChanged += new System.EventHandler(this.lvPlayers_SelectedIndexChanged);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 220;
            // 
            // colSteamId
            // 
            this.colSteamId.Text = "SteamId";
            this.colSteamId.Width = 248;
            // 
            // cmsPlayer
            // 
            this.cmsPlayer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openSteamProfileToolStripMenuItem,
            this.toolStripSeparator4,
            this.copyNameToolStripMenuItem,
            this.copySteamIdToolStripMenuItem,
            this.toolStripSeparator5,
            this.kickToolStripMenuItem,
            this.banToolStripMenuItem,
            this.unbanToolStripMenuItem,
            this.toolStripSeparator2,
            this.addToWhitelistToolStripMenuItem,
            this.removeFromWhitelistToolStripMenuItem});
            this.cmsPlayer.Name = "cmsPlayer";
            this.cmsPlayer.Size = new System.Drawing.Size(194, 220);
            this.cmsPlayer.Opening += new System.ComponentModel.CancelEventHandler(this.cmsPlayer_Opening);
            // 
            // openSteamProfileToolStripMenuItem
            // 
            this.openSteamProfileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openSteamProfileToolStripMenuItem.Image")));
            this.openSteamProfileToolStripMenuItem.Name = "openSteamProfileToolStripMenuItem";
            this.openSteamProfileToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.openSteamProfileToolStripMenuItem.Text = "Open Steam Profile(s)";
            this.openSteamProfileToolStripMenuItem.Click += new System.EventHandler(this.openSteamProfileToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(190, 6);
            // 
            // copyNameToolStripMenuItem
            // 
            this.copyNameToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyNameToolStripMenuItem.Image")));
            this.copyNameToolStripMenuItem.Name = "copyNameToolStripMenuItem";
            this.copyNameToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.copyNameToolStripMenuItem.Text = "Copy Name(s)";
            this.copyNameToolStripMenuItem.Click += new System.EventHandler(this.copyNameToolStripMenuItem_Click);
            // 
            // copySteamIdToolStripMenuItem
            // 
            this.copySteamIdToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copySteamIdToolStripMenuItem.Image")));
            this.copySteamIdToolStripMenuItem.Name = "copySteamIdToolStripMenuItem";
            this.copySteamIdToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.copySteamIdToolStripMenuItem.Text = "Copy SteamId(s)";
            this.copySteamIdToolStripMenuItem.Click += new System.EventHandler(this.copySteamIdToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(190, 6);
            // 
            // kickToolStripMenuItem
            // 
            this.kickToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("kickToolStripMenuItem.Image")));
            this.kickToolStripMenuItem.Name = "kickToolStripMenuItem";
            this.kickToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.kickToolStripMenuItem.Text = "Kick";
            this.kickToolStripMenuItem.Click += new System.EventHandler(this.kickToolStripMenuItem_Click);
            // 
            // banToolStripMenuItem
            // 
            this.banToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("banToolStripMenuItem.Image")));
            this.banToolStripMenuItem.Name = "banToolStripMenuItem";
            this.banToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.banToolStripMenuItem.Text = "Ban";
            this.banToolStripMenuItem.Click += new System.EventHandler(this.banToolStripMenuItem_Click);
            // 
            // unbanToolStripMenuItem
            // 
            this.unbanToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("unbanToolStripMenuItem.Image")));
            this.unbanToolStripMenuItem.Name = "unbanToolStripMenuItem";
            this.unbanToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.unbanToolStripMenuItem.Text = "Unban";
            this.unbanToolStripMenuItem.Click += new System.EventHandler(this.unbanToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(190, 6);
            // 
            // addToWhitelistToolStripMenuItem
            // 
            this.addToWhitelistToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addToWhitelistToolStripMenuItem.Image")));
            this.addToWhitelistToolStripMenuItem.Name = "addToWhitelistToolStripMenuItem";
            this.addToWhitelistToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.addToWhitelistToolStripMenuItem.Text = "Add to whitelist";
            this.addToWhitelistToolStripMenuItem.Click += new System.EventHandler(this.addToWhitelistToolStripMenuItem_Click);
            // 
            // removeFromWhitelistToolStripMenuItem
            // 
            this.removeFromWhitelistToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("removeFromWhitelistToolStripMenuItem.Image")));
            this.removeFromWhitelistToolStripMenuItem.Name = "removeFromWhitelistToolStripMenuItem";
            this.removeFromWhitelistToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.removeFromWhitelistToolStripMenuItem.Text = "Remove from whitelist";
            this.removeFromWhitelistToolStripMenuItem.Click += new System.EventHandler(this.removeFromWhitelistToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbRefresh,
            this.toolStripSeparator3,
            this.tsbKick,
            this.tsbBan,
            this.tsbUnban,
            this.toolStripSeparator1,
            this.tsbAddWhitelist,
            this.tsbRemoveWhitelist});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(601, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 4;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbRefresh
            // 
            this.tsbRefresh.Image = ((System.Drawing.Image)(resources.GetObject("tsbRefresh.Image")));
            this.tsbRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRefresh.Name = "tsbRefresh";
            this.tsbRefresh.Size = new System.Drawing.Size(106, 22);
            this.tsbRefresh.Text = "Refresh Players";
            this.tsbRefresh.Click += new System.EventHandler(this.tsbRefresh_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator3.Visible = false;
            // 
            // tsbKick
            // 
            this.tsbKick.Image = ((System.Drawing.Image)(resources.GetObject("tsbKick.Image")));
            this.tsbKick.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbKick.Name = "tsbKick";
            this.tsbKick.Size = new System.Drawing.Size(49, 22);
            this.tsbKick.Text = "Kick";
            this.tsbKick.Visible = false;
            this.tsbKick.Click += new System.EventHandler(this.kickToolStripMenuItem_Click);
            // 
            // tsbBan
            // 
            this.tsbBan.Image = ((System.Drawing.Image)(resources.GetObject("tsbBan.Image")));
            this.tsbBan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBan.Name = "tsbBan";
            this.tsbBan.Size = new System.Drawing.Size(47, 22);
            this.tsbBan.Text = "Ban";
            this.tsbBan.Visible = false;
            this.tsbBan.Click += new System.EventHandler(this.banToolStripMenuItem_Click);
            // 
            // tsbUnban
            // 
            this.tsbUnban.Image = ((System.Drawing.Image)(resources.GetObject("tsbUnban.Image")));
            this.tsbUnban.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUnban.Name = "tsbUnban";
            this.tsbUnban.Size = new System.Drawing.Size(62, 22);
            this.tsbUnban.Text = "Unban";
            this.tsbUnban.Visible = false;
            this.tsbUnban.Click += new System.EventHandler(this.unbanToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator1.Visible = false;
            // 
            // tsbAddWhitelist
            // 
            this.tsbAddWhitelist.Image = ((System.Drawing.Image)(resources.GetObject("tsbAddWhitelist.Image")));
            this.tsbAddWhitelist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddWhitelist.Name = "tsbAddWhitelist";
            this.tsbAddWhitelist.Size = new System.Drawing.Size(110, 22);
            this.tsbAddWhitelist.Text = "Add to whitelist";
            this.tsbAddWhitelist.Visible = false;
            this.tsbAddWhitelist.Click += new System.EventHandler(this.addToWhitelistToolStripMenuItem_Click);
            // 
            // tsbRemoveWhitelist
            // 
            this.tsbRemoveWhitelist.Image = ((System.Drawing.Image)(resources.GetObject("tsbRemoveWhitelist.Image")));
            this.tsbRemoveWhitelist.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRemoveWhitelist.Name = "tsbRemoveWhitelist";
            this.tsbRemoveWhitelist.Size = new System.Drawing.Size(146, 22);
            this.tsbRemoveWhitelist.Text = "Remove from whitelist";
            this.tsbRemoveWhitelist.Visible = false;
            this.tsbRemoveWhitelist.Click += new System.EventHandler(this.removeFromWhitelistToolStripMenuItem_Click);
            // 
            // Players
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvPlayers);
            this.Controls.Add(this.toolStrip);
            this.Name = "Players";
            this.Size = new System.Drawing.Size(601, 363);
            this.cmsPlayer.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvPlayers;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colSteamId;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbRefresh;
        private System.Windows.Forms.ContextMenuStrip cmsPlayer;
        private System.Windows.Forms.ToolStripMenuItem openSteamProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem copyNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copySteamIdToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem kickToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem banToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem addToWhitelistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeFromWhitelistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unbanToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbKick;
        private System.Windows.Forms.ToolStripButton tsbBan;
        private System.Windows.Forms.ToolStripButton tsbUnban;
        private System.Windows.Forms.ToolStripButton tsbAddWhitelist;
        private System.Windows.Forms.ToolStripButton tsbRemoveWhitelist;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    }
}

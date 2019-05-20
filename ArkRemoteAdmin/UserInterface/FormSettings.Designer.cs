namespace ArkRemoteAdmin.UserInterface
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("General");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Server");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.tblPnl = new System.Windows.Forms.TableLayoutPanel();
            this.tvMenu = new System.Windows.Forms.TreeView();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.tbCtrlPages = new System.Windows.Forms.TabControl();
            this.tbPgGeneral = new System.Windows.Forms.TabPage();
            this.lblRestart = new System.Windows.Forms.Label();
            this.grpDataPath = new System.Windows.Forms.GroupBox();
            this.btnDataPath = new System.Windows.Forms.Button();
            this.tbxDataPath = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tbPgServer = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPlayerInterval = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nudChatInterval = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.fbdDataPath = new System.Windows.Forms.FolderBrowserDialog();
            this.ckbRefreshPlayers = new System.Windows.Forms.CheckBox();
            this.tblPnl.SuspendLayout();
            this.pnlButtons.SuspendLayout();
            this.pnlMain.SuspendLayout();
            this.tbCtrlPages.SuspendLayout();
            this.tbPgGeneral.SuspendLayout();
            this.grpDataPath.SuspendLayout();
            this.tbPgServer.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerInterval)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChatInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPnl
            // 
            this.tblPnl.ColumnCount = 2;
            this.tblPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tblPnl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tblPnl.Controls.Add(this.tvMenu, 0, 0);
            this.tblPnl.Controls.Add(this.pnlButtons, 1, 1);
            this.tblPnl.Controls.Add(this.pnlMain, 1, 0);
            this.tblPnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPnl.Location = new System.Drawing.Point(0, 0);
            this.tblPnl.Name = "tblPnl";
            this.tblPnl.RowCount = 2;
            this.tblPnl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPnl.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblPnl.Size = new System.Drawing.Size(434, 262);
            this.tblPnl.TabIndex = 0;
            // 
            // tvMenu
            // 
            this.tvMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvMenu.Location = new System.Drawing.Point(3, 3);
            this.tvMenu.Name = "tvMenu";
            treeNode1.Name = "nodeGeneral";
            treeNode1.Tag = "";
            treeNode1.Text = "General";
            treeNode2.Name = "nodeServer";
            treeNode2.Text = "Server";
            this.tvMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.tblPnl.SetRowSpan(this.tvMenu, 2);
            this.tvMenu.ShowLines = false;
            this.tvMenu.Size = new System.Drawing.Size(144, 256);
            this.tvMenu.TabIndex = 0;
            this.tvMenu.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvMenu_NodeMouseClick);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.label1);
            this.pnlButtons.Controls.Add(this.btnSave);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Location = new System.Drawing.Point(153, 230);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(281, 29);
            this.pnlButtons.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "* Requires restart";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(113, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(194, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.tbCtrlPages);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(153, 3);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(281, 221);
            this.pnlMain.TabIndex = 2;
            // 
            // tbCtrlPages
            // 
            this.tbCtrlPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCtrlPages.Controls.Add(this.tbPgGeneral);
            this.tbCtrlPages.Controls.Add(this.tbPgServer);
            this.tbCtrlPages.Location = new System.Drawing.Point(-4, -21);
            this.tbCtrlPages.Name = "tbCtrlPages";
            this.tbCtrlPages.SelectedIndex = 0;
            this.tbCtrlPages.Size = new System.Drawing.Size(288, 246);
            this.tbCtrlPages.TabIndex = 0;
            // 
            // tbPgGeneral
            // 
            this.tbPgGeneral.BackColor = System.Drawing.SystemColors.Control;
            this.tbPgGeneral.Controls.Add(this.lblRestart);
            this.tbPgGeneral.Controls.Add(this.grpDataPath);
            this.tbPgGeneral.Controls.Add(this.checkBox2);
            this.tbPgGeneral.Controls.Add(this.checkBox1);
            this.tbPgGeneral.Location = new System.Drawing.Point(4, 22);
            this.tbPgGeneral.Name = "tbPgGeneral";
            this.tbPgGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tbPgGeneral.Size = new System.Drawing.Size(280, 220);
            this.tbPgGeneral.TabIndex = 0;
            this.tbPgGeneral.Text = "General";
            // 
            // lblRestart
            // 
            this.lblRestart.AutoSize = true;
            this.lblRestart.ForeColor = System.Drawing.Color.Red;
            this.lblRestart.Location = new System.Drawing.Point(139, 7);
            this.lblRestart.Name = "lblRestart";
            this.lblRestart.Size = new System.Drawing.Size(11, 13);
            this.lblRestart.TabIndex = 5;
            this.lblRestart.Text = "*";
            // 
            // grpDataPath
            // 
            this.grpDataPath.Controls.Add(this.btnDataPath);
            this.grpDataPath.Controls.Add(this.tbxDataPath);
            this.grpDataPath.Location = new System.Drawing.Point(6, 162);
            this.grpDataPath.Name = "grpDataPath";
            this.grpDataPath.Size = new System.Drawing.Size(268, 52);
            this.grpDataPath.TabIndex = 4;
            this.grpDataPath.TabStop = false;
            this.grpDataPath.Text = "Data-Path";
            this.grpDataPath.Visible = false;
            // 
            // btnDataPath
            // 
            this.btnDataPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDataPath.Location = new System.Drawing.Point(237, 19);
            this.btnDataPath.Name = "btnDataPath";
            this.btnDataPath.Size = new System.Drawing.Size(25, 23);
            this.btnDataPath.TabIndex = 2;
            this.btnDataPath.Text = "...";
            this.btnDataPath.UseVisualStyleBackColor = true;
            // 
            // tbxDataPath
            // 
            this.tbxDataPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbxDataPath.Location = new System.Drawing.Point(6, 21);
            this.tbxDataPath.Name = "tbxDataPath";
            this.tbxDataPath.ReadOnly = true;
            this.tbxDataPath.Size = new System.Drawing.Size(225, 20);
            this.tbxDataPath.TabIndex = 3;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 139);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(174, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Auto-Reconnect on disconnect";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 6);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(137, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Allow multiple instances";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // tbPgServer
            // 
            this.tbPgServer.BackColor = System.Drawing.SystemColors.Control;
            this.tbPgServer.Controls.Add(this.groupBox2);
            this.tbPgServer.Controls.Add(this.groupBox1);
            this.tbPgServer.Location = new System.Drawing.Point(4, 22);
            this.tbPgServer.Name = "tbPgServer";
            this.tbPgServer.Size = new System.Drawing.Size(280, 220);
            this.tbPgServer.TabIndex = 1;
            this.tbPgServer.Text = "Server";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbRefreshPlayers);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.nudPlayerInterval);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(3, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(266, 67);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Players";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Refresh time in seconds:";
            // 
            // nudPlayerInterval
            // 
            this.nudPlayerInterval.Location = new System.Drawing.Point(143, 19);
            this.nudPlayerInterval.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudPlayerInterval.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudPlayerInterval.Name = "nudPlayerInterval";
            this.nudPlayerInterval.Size = new System.Drawing.Size(40, 20);
            this.nudPlayerInterval.TabIndex = 7;
            this.nudPlayerInterval.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(126, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(11, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "*";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nudChatInterval);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(3, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 50);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Fetch interval in seconds:";
            // 
            // nudChatInterval
            // 
            this.nudChatInterval.Location = new System.Drawing.Point(145, 19);
            this.nudChatInterval.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudChatInterval.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nudChatInterval.Name = "nudChatInterval";
            this.nudChatInterval.Size = new System.Drawing.Size(40, 20);
            this.nudChatInterval.TabIndex = 9;
            this.nudChatInterval.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(131, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "*";
            // 
            // ckbRefreshPlayers
            // 
            this.ckbRefreshPlayers.AutoSize = true;
            this.ckbRefreshPlayers.Location = new System.Drawing.Point(6, 46);
            this.ckbRefreshPlayers.Name = "ckbRefreshPlayers";
            this.ckbRefreshPlayers.Size = new System.Drawing.Size(125, 17);
            this.ckbRefreshPlayers.TabIndex = 10;
            this.ckbRefreshPlayers.Text = "Auto Refresh Players";
            this.ckbRefreshPlayers.UseVisualStyleBackColor = true;
            // 
            // FormSettings
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(434, 262);
            this.Controls.Add(this.tblPnl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.tblPnl.ResumeLayout(false);
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.pnlMain.ResumeLayout(false);
            this.tbCtrlPages.ResumeLayout(false);
            this.tbPgGeneral.ResumeLayout(false);
            this.tbPgGeneral.PerformLayout();
            this.grpDataPath.ResumeLayout(false);
            this.grpDataPath.PerformLayout();
            this.tbPgServer.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPlayerInterval)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudChatInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPnl;
        private System.Windows.Forms.TreeView tvMenu;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TabControl tbCtrlPages;
        private System.Windows.Forms.TabPage tbPgGeneral;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.GroupBox grpDataPath;
        private System.Windows.Forms.Button btnDataPath;
        private System.Windows.Forms.TextBox tbxDataPath;
        private System.Windows.Forms.FolderBrowserDialog fbdDataPath;
        private System.Windows.Forms.TabPage tbPgServer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudChatInterval;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPlayerInterval;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblRestart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ckbRefreshPlayers;
    }
}
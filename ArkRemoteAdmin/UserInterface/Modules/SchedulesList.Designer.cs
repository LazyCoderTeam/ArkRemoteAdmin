namespace ArkRemoteAdmin.UserInterface.Modules
{
    partial class SchedulesList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulesList));
            this.lvSchedules = new System.Windows.Forms.ListView();
            this.colScheduleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScheduleMessage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colScheduleType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsSchedule = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.runNowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.activateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deactivateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editBroadcastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBroadcastToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.tsbAdd = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbRun = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbEdit = new System.Windows.Forms.ToolStripButton();
            this.tsbDelete = new System.Windows.Forms.ToolStripButton();
            this.tsSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbActivate = new System.Windows.Forms.ToolStripButton();
            this.tsbDeactivate = new System.Windows.Forms.ToolStripButton();
            this.cmsSchedule.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSchedules
            // 
            this.lvSchedules.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colScheduleName,
            this.colScheduleMessage,
            this.colScheduleType});
            this.lvSchedules.ContextMenuStrip = this.cmsSchedule;
            this.lvSchedules.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSchedules.FullRowSelect = true;
            this.lvSchedules.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvSchedules.Location = new System.Drawing.Point(0, 25);
            this.lvSchedules.MultiSelect = false;
            this.lvSchedules.Name = "lvSchedules";
            this.lvSchedules.Size = new System.Drawing.Size(574, 299);
            this.lvSchedules.SmallImageList = this.smallImageList;
            this.lvSchedules.TabIndex = 2;
            this.lvSchedules.UseCompatibleStateImageBehavior = false;
            this.lvSchedules.View = System.Windows.Forms.View.Details;
            this.lvSchedules.SelectedIndexChanged += new System.EventHandler(this.lvSchedules_SelectedIndexChanged);
            // 
            // colScheduleName
            // 
            this.colScheduleName.Text = "Name";
            this.colScheduleName.Width = 103;
            // 
            // colScheduleMessage
            // 
            this.colScheduleMessage.Text = "Message";
            this.colScheduleMessage.Width = 291;
            // 
            // colScheduleType
            // 
            this.colScheduleType.Text = "Type";
            // 
            // cmsSchedule
            // 
            this.cmsSchedule.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runNowToolStripMenuItem,
            this.toolStripSeparator2,
            this.activateToolStripMenuItem,
            this.deactivateToolStripMenuItem,
            this.toolStripSeparator1,
            this.editBroadcastToolStripMenuItem,
            this.deleteBroadcastToolStripMenuItem});
            this.cmsSchedule.Name = "contextMenuStrip";
            this.cmsSchedule.Size = new System.Drawing.Size(163, 126);
            this.cmsSchedule.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip_Opening);
            // 
            // runNowToolStripMenuItem
            // 
            this.runNowToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("runNowToolStripMenuItem.Image")));
            this.runNowToolStripMenuItem.Name = "runNowToolStripMenuItem";
            this.runNowToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.runNowToolStripMenuItem.Text = "Run Now";
            this.runNowToolStripMenuItem.Click += new System.EventHandler(this.tsbRun_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(159, 6);
            // 
            // activateToolStripMenuItem
            // 
            this.activateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("activateToolStripMenuItem.Image")));
            this.activateToolStripMenuItem.Name = "activateToolStripMenuItem";
            this.activateToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.activateToolStripMenuItem.Text = "Activate";
            this.activateToolStripMenuItem.Click += new System.EventHandler(this.tsbActivate_Click);
            // 
            // deactivateToolStripMenuItem
            // 
            this.deactivateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deactivateToolStripMenuItem.Image")));
            this.deactivateToolStripMenuItem.Name = "deactivateToolStripMenuItem";
            this.deactivateToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deactivateToolStripMenuItem.Text = "Deactivate";
            this.deactivateToolStripMenuItem.Click += new System.EventHandler(this.tsbDeactivate_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // editBroadcastToolStripMenuItem
            // 
            this.editBroadcastToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editBroadcastToolStripMenuItem.Image")));
            this.editBroadcastToolStripMenuItem.Name = "editBroadcastToolStripMenuItem";
            this.editBroadcastToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.editBroadcastToolStripMenuItem.Text = "Edit Broadcast";
            this.editBroadcastToolStripMenuItem.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // deleteBroadcastToolStripMenuItem
            // 
            this.deleteBroadcastToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteBroadcastToolStripMenuItem.Image")));
            this.deleteBroadcastToolStripMenuItem.Name = "deleteBroadcastToolStripMenuItem";
            this.deleteBroadcastToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.deleteBroadcastToolStripMenuItem.Text = "Delete Broadcast";
            this.deleteBroadcastToolStripMenuItem.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // smallImageList
            // 
            this.smallImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("smallImageList.ImageStream")));
            this.smallImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.smallImageList.Images.SetKeyName(0, "accept.png");
            // 
            // toolStrip
            // 
            this.toolStrip.BackColor = System.Drawing.Color.Transparent;
            this.toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAdd,
            this.tsSeparator1,
            this.tsbRun,
            this.toolStripSeparator3,
            this.tsbEdit,
            this.tsbDelete,
            this.tsSeparator2,
            this.tsbActivate,
            this.tsbDeactivate});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(574, 25);
            this.toolStrip.Stretch = true;
            this.toolStrip.TabIndex = 3;
            this.toolStrip.Text = "toolStrip1";
            // 
            // tsbAdd
            // 
            this.tsbAdd.Image = ((System.Drawing.Image)(resources.GetObject("tsbAdd.Image")));
            this.tsbAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAdd.Name = "tsbAdd";
            this.tsbAdd.Size = new System.Drawing.Size(104, 22);
            this.tsbAdd.Text = "Add Broadcast";
            this.tsbAdd.Click += new System.EventHandler(this.tsbAdd_Click);
            // 
            // tsSeparator1
            // 
            this.tsSeparator1.Name = "tsSeparator1";
            this.tsSeparator1.Size = new System.Drawing.Size(6, 25);
            this.tsSeparator1.Visible = false;
            // 
            // tsbRun
            // 
            this.tsbRun.Image = ((System.Drawing.Image)(resources.GetObject("tsbRun.Image")));
            this.tsbRun.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbRun.Name = "tsbRun";
            this.tsbRun.Size = new System.Drawing.Size(76, 22);
            this.tsbRun.Text = "Run Now";
            this.tsbRun.Visible = false;
            this.tsbRun.Click += new System.EventHandler(this.tsbRun_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            this.toolStripSeparator3.Visible = false;
            // 
            // tsbEdit
            // 
            this.tsbEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbEdit.Image")));
            this.tsbEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEdit.Name = "tsbEdit";
            this.tsbEdit.Size = new System.Drawing.Size(47, 22);
            this.tsbEdit.Text = "Edit";
            this.tsbEdit.Visible = false;
            this.tsbEdit.Click += new System.EventHandler(this.tsbEdit_Click);
            // 
            // tsbDelete
            // 
            this.tsbDelete.Image = ((System.Drawing.Image)(resources.GetObject("tsbDelete.Image")));
            this.tsbDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDelete.Name = "tsbDelete";
            this.tsbDelete.Size = new System.Drawing.Size(60, 22);
            this.tsbDelete.Text = "Delete";
            this.tsbDelete.Visible = false;
            this.tsbDelete.Click += new System.EventHandler(this.tsbDelete_Click);
            // 
            // tsSeparator2
            // 
            this.tsSeparator2.Name = "tsSeparator2";
            this.tsSeparator2.Size = new System.Drawing.Size(6, 25);
            this.tsSeparator2.Visible = false;
            // 
            // tsbActivate
            // 
            this.tsbActivate.Image = ((System.Drawing.Image)(resources.GetObject("tsbActivate.Image")));
            this.tsbActivate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbActivate.Name = "tsbActivate";
            this.tsbActivate.Size = new System.Drawing.Size(70, 22);
            this.tsbActivate.Text = "Activate";
            this.tsbActivate.Visible = false;
            this.tsbActivate.Click += new System.EventHandler(this.tsbActivate_Click);
            // 
            // tsbDeactivate
            // 
            this.tsbDeactivate.Image = ((System.Drawing.Image)(resources.GetObject("tsbDeactivate.Image")));
            this.tsbDeactivate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeactivate.Name = "tsbDeactivate";
            this.tsbDeactivate.Size = new System.Drawing.Size(82, 22);
            this.tsbDeactivate.Text = "Deactivate";
            this.tsbDeactivate.Visible = false;
            this.tsbDeactivate.Click += new System.EventHandler(this.tsbDeactivate_Click);
            // 
            // SchedulesList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lvSchedules);
            this.Controls.Add(this.toolStrip);
            this.Name = "SchedulesList";
            this.Size = new System.Drawing.Size(574, 324);
            this.cmsSchedule.ResumeLayout(false);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvSchedules;
        private System.Windows.Forms.ColumnHeader colScheduleName;
        private System.Windows.Forms.ColumnHeader colScheduleMessage;
        private System.Windows.Forms.ColumnHeader colScheduleType;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton tsbAdd;
        private System.Windows.Forms.ToolStripButton tsbEdit;
        private System.Windows.Forms.ToolStripButton tsbDelete;
        private System.Windows.Forms.ToolStripSeparator tsSeparator2;
        private System.Windows.Forms.ToolStripButton tsbActivate;
        private System.Windows.Forms.ToolStripButton tsbDeactivate;
        private System.Windows.Forms.ContextMenuStrip cmsSchedule;
        private System.Windows.Forms.ToolStripMenuItem activateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deactivateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem editBroadcastToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBroadcastToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tsSeparator1;
        private System.Windows.Forms.ToolStripMenuItem runNowToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbRun;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ImageList smallImageList;
    }
}

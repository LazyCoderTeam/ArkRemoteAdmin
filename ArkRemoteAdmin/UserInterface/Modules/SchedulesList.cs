using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using ArkRemoteAdmin.Data;
//using BssFramework.Windows.Forms;
using Quartz;
using ArkRcon = ArkRemoteAdmin.Core.ArkRcon;

namespace ArkRemoteAdmin.UserInterface.Modules
{
    public partial class SchedulesList : UserControl, IJobListener
    {
        private readonly SynchronizationContext syncContext;

        public SchedulesList()
        {
            InitializeComponent();
            syncContext = SynchronizationContext.Current;
            //toolStrip.Renderer = new SevenToolStripRenderer();
            //cmsSchedule.Renderer = new SevenToolStripRenderer();

            Quartz.Impl.StdSchedulerFactory.GetDefaultScheduler().ListenerManager.AddJobListener(this);

            ArkRcon.Client.Connected += Client_Connected;
            ArkRcon.Client.Disconnected += Client_Disconnected;
        }

        private void Client_Disconnected(object sender, bool e)
        {
            Scheduler.ClearSchedules();
            syncContext.Send(state => lvSchedules.Items.Clear(), null);
        }

        private void Client_Connected(object sender, EventArgs e)
        {
            Scheduler.CreateAndActivateSchedules(Data.Data.Schedules.Where(s => s.ServerId == ArkRcon.ConnectedServer.Id));
            syncContext.Send(state => LoadSchedules(), null);
        }

        private void lvSchedules_SelectedIndexChanged(object sender, EventArgs e)
        {
            Schedule schedule = GetSelectedSchedule();

            tsbRun.Visible = schedule != null;
            tsbEdit.Visible = schedule != null;
            tsbDelete.Visible = schedule != null;
            tsbActivate.Visible = schedule != null && !schedule.Active;
            tsbDeactivate.Visible = schedule != null && schedule.Active;
            tsSeparator1.Visible = schedule != null;
            tsSeparator2.Visible = schedule != null;
            toolStripSeparator3.Visible = schedule != null;

            runNowToolStripMenuItem.Visible = schedule != null;
            editBroadcastToolStripMenuItem.Visible = schedule != null;
            deleteBroadcastToolStripMenuItem.Visible = schedule != null;
            activateToolStripMenuItem.Visible = schedule != null && !schedule.Active;
            deactivateToolStripMenuItem.Visible = schedule != null && schedule.Active;
            toolStripSeparator1.Visible = schedule != null;
            toolStripSeparator2.Visible = schedule != null;
        }

        private void contextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            Schedule schedule = GetSelectedSchedule();

            if (schedule == null)
                e.Cancel = true;
        }

        #region Menu Commands

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            using (WizardAddSchedule form = new WizardAddSchedule())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    Scheduler.AddSchedule(form.Schedule);
                    LoadSchedules();
                }
            }
        }

        private void tsbRun_Click(object sender, EventArgs e)
        {
            Schedule schedule = GetSelectedSchedule();
            schedule?.Run();
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            Schedule schedule = GetSelectedSchedule();

            if (schedule != null)
            {
                using (WizardAddSchedule form = new WizardAddSchedule(schedule))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        Scheduler.AddSchedule(form.Schedule);
                        LoadSchedules();
                    }
                }
            }
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            Schedule schedule = GetSelectedSchedule();

            if (schedule != null)
            {
                if (MessageBox.Show("Do you really want to delete this scheduled broadcast?", "Delete Broadcast", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Scheduler.DeleteSchedule(schedule);
                    Data.Data.Remove(schedule);
                    LoadSchedules();
                }
            }
        }

        private void tsbActivate_Click(object sender, EventArgs e)
        {
            Schedule schedule = GetSelectedSchedule();

            if (schedule != null)
            {
                Scheduler.ActivateSchedule(schedule);
                schedule.Active = true;
                Data.Data.Set(schedule);
                LoadSchedules();
            }
        }

        private void tsbDeactivate_Click(object sender, EventArgs e)
        {
            Schedule schedule = GetSelectedSchedule();

            if (schedule != null)
            {
                Scheduler.DeactivateSchedule(schedule);
                schedule.Active = false;
                Data.Data.Set(schedule);
                LoadSchedules();
            }
        }

        #endregion // Menu Commands

        #region Internal Methods

        private Schedule GetSelectedSchedule()
        {
            if (lvSchedules.SelectedItems.Count > 0)
                return lvSchedules.SelectedItems[0].Tag as Schedule;

            return null;
        }

        private void LoadSchedules()
        {
            lvSchedules.Items.Clear();

            foreach (Schedule schedule in Data.Data.Schedules.Where(s => s.ServerId == ArkRcon.ConnectedServer.Id))
                lvSchedules.Items.Add(new ListViewItem(new[] { schedule.Name, schedule.Message, schedule.Type.ToString() }) { Tag = schedule, ImageIndex = schedule.Active ? 0 : -1 });

            lvSchedules_SelectedIndexChanged(this, new EventArgs());
        }

        #endregion // Internal Methods

        public void JobToBeExecuted(IJobExecutionContext context)
        {
            
        }

        public void JobExecutionVetoed(IJobExecutionContext context)
        {
            
        }

        public void JobWasExecuted(IJobExecutionContext context, JobExecutionException jobException)
        {
            
        }
    }
}

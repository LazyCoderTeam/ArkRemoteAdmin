using System;
using System.Threading;
using System.Windows.Forms;
using ArkRemoteAdmin.Data;
using ArkRemoteAdmin.UserInterface;
//using BssFramework.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using Quartz;
using Rcon;

namespace ArkRemoteAdmin
{
    class Program : WindowsFormsApplicationBase
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.ThreadException += Application_ThreadException;
            //Data.Data.Upgrade();
            Settings.Load();
            Data.Data.Load();

            IScheduler scheduler = Quartz.Impl.StdSchedulerFactory.GetDefaultScheduler();
            scheduler.Start();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FormMain frmMain = new FormMain();
            frmMain.Height = 500;
            frmMain.Width = 500;
            Application.Run(frmMain);
            //new Program().Run(args);

            scheduler.Shutdown();
        }

        private void Test(object sender, CommandExecutedEventArgs e)
        {
            System.Console.WriteLine($"Command executed: {e.Successful} {e.Error} {e.Command}");
        }

        static void Application_ThreadException(object sender, ThreadExceptionEventArgs e)
        {
#if !DEBUG
            ErrorHandler.CaptureUnhandledException(e.Exception);
#endif
            System.Diagnostics.Debug.WriteLine("Blah");
            MessageBox.Show("Error:" + e.Exception.Message);

            //TaskDialog taskDialog = new TaskDialog();
            //taskDialog.WindowTitle = "Unhandled Error";
            //taskDialog.MainInstruction = "An unhandled error occured.";
            //taskDialog.Content = "An error report was generated and sent to the developer of this application." + Environment.NewLine + "The error report does not contain any personal information.";
            //taskDialog.CommonButtons = TaskDialogCommonButtons.Ok;
            //taskDialog.MainIcon = TaskDialogIcon.Error;
            //taskDialog.PositionRelativeToWindow = true;
            //taskDialog.Show();
        }

        public App App { get; private set; }

        public Program()
        {
            IsSingleInstance = !Settings.General.AllowMultipleInstances;
        }

        protected override bool OnStartup(StartupEventArgs e)
        {
            App = new App();
            App.Run();
            return false;
        }

        protected override void OnStartupNextInstance(
          StartupNextInstanceEventArgs eventArgs)
        {
            base.OnStartupNextInstance(eventArgs);
            App.Focus();
        }
    }
}

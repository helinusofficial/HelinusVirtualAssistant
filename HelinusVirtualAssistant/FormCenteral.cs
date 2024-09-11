using HVA.Services;
using HVA.Services.MonitoringEngine;
using HVA.UIFRMS.Help;
using HVA.UIFRMS.Reports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
//pfx password:DXُِّ345FG$@%^RGHDSFGیبا%ٍ&%!@4قل
namespace HelinusVirtualAssistant
{
    public partial class FormCenteral : Form
    {
        #region variablesRegion
        private FormAbout frmAbout;
        private FormShowDetails formShowDetails;
       // private TaskbarNotifierSrv taskbarNotifierService;
        private Thread th_ShowSystemDateTime;

     
        [DllImport("user32.dll")]
        private static extern
        bool SetForegroundWindow(IntPtr hWnd);
        [DllImport("user32.dll")]
        private static extern
        bool ShowWindowAsync(IntPtr hWnd, int nCmdShow);
        [DllImport("user32.dll")]
        private static extern
        bool IsIconic(IntPtr hWnd);

        private const int SW_HIDE = 0;
        private const int SW_SHOWNORMAL = 1;
        private const int SW_SHOWMINIMIZED = 2;
        private const int SW_SHOWMAXIMIZED = 3;
        private const int SW_SHOWNOACTIVATE = 4;
        private const int SW_RESTORE = 9;
        private const int SW_SHOWDEFAULT = 10;

        private SystemInfoService systemInfoService;
        private FormSplash kCMLogoForm = new FormSplash();

        private bool startToWork = true;

        private const int tryCount = 5;
        private const int tryTime = 10000;
        private bool shownShutdownWarning = false;
        #endregion

        public FormCenteral()
        {
            try
            {
                HideMainForm();
                Thread splashthread = new Thread(new ThreadStart(SplashSrv.ShowSplashScreen));
                splashthread.IsBackground = true;
                splashthread.Start();
                SplashSrv.UdpateStatusText("Please wait...");
                InitializeComponent();
                InitForm();
            }
            catch (Exception err)
            {
                startToWork = false;
            }
        }

        private void FormCenteral_Load(object sender, EventArgs e)
        {
            #region MyRegion
            SplashSrv.UdpateStatusText("Loading...");
            Thread.Sleep(500);
            SplashSrv.UdpateStatusText("Initializing...");
            Thread.Sleep(500);
            InitProgramm();
            if (!startToWork) { SplashSrv.CloseSplashScreen(); return; }

            SplashSrv.UdpateStatusText("Check failed shutdown");
            Thread.Sleep(500);
            if (!startToWork) { SplashSrv.CloseSplashScreen(); return; }

            SplashSrv.UdpateStatusText("Retriving settings");
            if (!startToWork) { SplashSrv.CloseSplashScreen(); return; }

            SplashSrv.UdpateStatusTextWithStatus("Successfully done.", TypeOfMessage.Success);
            Thread.Sleep(500);
            SplashSrv.UdpateStatusTextWithStatus("Starting.", TypeOfMessage.Success);
            Thread.Sleep(800);
            SplashSrv.UdpateStatusTextWithStatus("Starting..", TypeOfMessage.Success);
            Thread.Sleep(800);
            SplashSrv.UdpateStatusTextWithStatus("Starting...", TypeOfMessage.Success);
            Thread.Sleep(800);
            SplashSrv.UdpateStatusTextWithStatus("Starting.....", TypeOfMessage.Success);
            Thread.Sleep(800);

            SplashSrv.CloseSplashScreen();
            ShowMainForm();
            InitMainForm();
            #endregion

            th_ShowSystemDateTime =  new Thread(new ThreadStart(ShowSystemDateTime));
             th_ShowSystemDateTime.Start();

         //   taskbarNotifierService = new TaskbarNotifierSrv();
          //  StartModemListeningPort();

        }
        private void ShowSystemDateTime()
        {
            try
            {
                while (th_ShowSystemDateTime.IsAlive)
                {
                    lock (this)
                    {
                        labelSystemTime.BeginInvoke((MethodInvoker)delegate ()
                        {
                            labelSystemTime.Text = DateTime.Now.ToString();
                        });
                    }
                    Thread.Sleep(1000);
                }
            }
            catch { }
        }

        #region EventRegion
        private void FormCenteral_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (th_ShowSystemDateTime != null && th_ShowSystemDateTime.ThreadState != ThreadState.Stopped && th_ShowSystemDateTime.ThreadState != ThreadState.Unstarted)
            {
                th_ShowSystemDateTime.Interrupt();
                th_ShowSystemDateTime.Join();
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }
     
        private void monitoringCenterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
         
            this.Show();
        }
        private void toolStripMenuItemHelinus_Click(object sender, EventArgs e)
        {
        }
      
        private void toolStripMenuItemStopWorking_Click(object sender, EventArgs e)
        {
            StopWork();
            ProcessData();
            ShowMainForm();
            notifyIconMain.Visible = false;
        }
        private void exitAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopWork();
            Application.ExitThread();
        }
        private void toolStripMenuItemStartAll_Click(object sender, EventArgs e)
        {
            //StartToWork();
            StartLocalMonitoring();
            HideMainForm();
            notifyIconMain.Visible = true;
        }
        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowHelinusWebsite();
        }
        private void supportToolStripMenuItemSupport_Click(object sender, EventArgs e)
        {
           
        }
        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            ShowAbout();
        }
  
        private void V(DataGridViewCellEventArgs e)
        {
            var cellindex = dataGridViewReport.SelectedCells[0].RowIndex;
            var cellcollection = dataGridViewReport.Rows[cellindex].Cells[0].Value;

            dataGridViewReport.Rows[e.RowIndex].Selected = true;
            int id = int.Parse(dataGridViewReport.Rows[e.RowIndex].Cells[0].Value.ToString());
            formShowDetails = new FormShowDetails(packageService.appHash.GetEnumerator(), id);
            formShowDetails.ShowDialog();
        }
        private void dataGridViewReport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewReport.SelectedCells.Count <= 0) return;
            var g = dataGridViewReport.SelectedCells[0].ColumnIndex;
            if (g != 4) return;
            V(e);
        }


    
        #endregion

        #region MethodsRegion
        private void InitMainForm()
        {
            toolStripStatusLabelVersion.Text += UtilityService.FindProgrammVersion();
            systemInfoService = new SystemInfoService();
            labelCPU.Text = systemInfoService.SystemInfo.CPUModel;
            labelOS.Text = systemInfoService.SystemInfo.OS;
            labelComputer.Text = systemInfoService.SystemInfo.ComputerName;
            labelAccount.Text = systemInfoService.SystemInfo.AccountName;
        }
     
        private void ProcessData()
        {
            dataGridViewReport.Rows.Clear();
            IDictionaryEnumerator capturedPackageList = packageService.appHash.GetEnumerator();

            while (capturedPackageList.MoveNext())
            {
                List<CClientPacketModel> x = new List<CClientPacketModel>();
                x = (List<CClientPacketModel>)capturedPackageList.Value;

                CClientPacketModel tempdata = null;
                int itemp = 0;
                tempdata = new CClientPacketModel();
                foreach (var o in x)
                {
                    if (o.AppID == 0) continue;
                    if (o.AppName.ToLower() == "idle") continue;
                    if (o.AppName.ToLower() == "dllhost" && o.AppID <= 0) continue;
                    if (o.CaptureDate.Year == 0001) continue;
                    if (o.WorkTime == 0) continue;

                    tempdata.AppID = o.AppID;
                    tempdata.AppName = o.AppName;
                    tempdata.AppTitle = o.AppTitle;
                    tempdata.WorkTime += o.WorkTime;
                    tempdata.CaptureDate = o.CaptureDate;
                    if (o.AppName.ToLower() == "dllhost")
                        tempdata.AppName = "Operating System";
                }

                if (tempdata == null || tempdata.AppID <= 0) continue;

                int h = dataGridViewReport.Rows.Add();
                dataGridViewReport.Rows[h].Cells[itemp++].Value = tempdata.AppID;
                dataGridViewReport.Rows[h].Cells[itemp++].Value = tempdata.CaptureDate;
                dataGridViewReport.Rows[h].Cells[itemp++].Value = tempdata.AppName;
                dataGridViewReport.Rows[h].Cells[itemp++].Value = (new TimeSpan(Convert.ToInt64(tempdata.WorkTime) * 10000000)).ToString(@"hh\:mm\:ss");
                dataGridViewReport.Rows[h].Cells[itemp++].Value = "View";
            }
        }
        private void HideMainForm()
        {
            this.Hide();
            this.Visible = false;
            this.Opacity = 0;
            //this is old code to hide main form in winform
            //this line not works by telerik forms
            // this.WindowState = FormWindowState.Minimized;
            this.Text = string.Empty;
        }
        private void ShowMainForm()
        {
            notifyIconMain.Visible = false;
            this.Visible = true;
            this.Text = HVA.RS.FormsRS.FormMainRS.Title;
            this.Opacity = 100;
            this.WindowState = FormWindowState.Normal;
        }
        private void StartToWork()
        {
            if (startToWork)
            {
                StartLocalMonitoring();
                //StartThShutdownTimer();  
            }
        }
        private void InitForm()
        {
            notifyIconMain.Visible = true;
            try
            {


            }
            catch (Exception err)
            {

               startToWork = false;
            }
        }
        private void InitProgramm()
        {
            try
            {
                systemInfoService = new SystemInfoService();
               // toolStripStatusLabelVersion.Text = UtilityService.FindProgrammVersion();
            }
            catch (Exception err)
            {
                startToWork = false;
            }
        }
        private void StopWork()
        {
            try
            {
                if ((object)thCapturePackets != null && thCapturePackets.IsAlive)
                {
                    if (thCapturePackets != null && thCapturePackets.ThreadState != ThreadState.Stopped && thCapturePackets.ThreadState != ThreadState.Unstarted)
                    {
                        thCapturePackets.Interrupt();
                        thCapturePackets.Join(1); 
                    }
                }
                if ((object)thShutdownTimer != null && thShutdownTimer.IsAlive)
                {
                    if (thShutdownTimer != null && thShutdownTimer.ThreadState != ThreadState.Stopped && thShutdownTimer.ThreadState != ThreadState.Unstarted)
                    {
                        thShutdownTimer.Interrupt();
                        thShutdownTimer.Join(1);
                    }
                }
            }
            catch (Exception err)
            {

            }


        }
        private void ShowAbout()
        {
            frmAbout = new FormAbout();
            frmAbout.ShowDialog();
        }
     
        private void ShowHelinusWebsite()
        {
            System.Diagnostics.Process.Start("explorer.exe", "http://www.helinus.com");
        }

        #endregion

        #region StartSystemToWorkRegion

        Thread thCapturePackets;
        Thread thShutdownTimer;

        #region LocalWorksRegion


        private PackageService packageService;
        private void StartLocalMonitoring()
        {
            packageService = new PackageService();
            thCapturePackets = new Thread(new ThreadStart(thCapturePacketsWorks));
            thCapturePackets.Priority = ThreadPriority.Normal;
            thCapturePackets.Name = "thCapturePackets";
            thCapturePackets.IsBackground = true;

            //thRestTimer = new Thread(new ThreadStart(thRestTimerWork));
            //thRestTimer.Priority = ThreadPriority.Normal;
            //thRestTimer.Name = "thRestTimer";
            //thRestTimer.IsBackground = true;

            thCapturePackets.Start();//collect information in hashtable
            // thRestTimer.Start();
        }
        private void thCapturePacketsWorks()
        {

            while (thCapturePackets.IsAlive)
            {
                try
                {
                    packageService.StartMonitoring();
                    Thread.Sleep(100);
                }
                catch (Exception err)
                {
                    //  HVA.LGR.PointLoger.LogIt(err.Message);

                }
                finally
                {
                  
                }
               
            }
        }

        private void StartThShutdownTimer()
        {
            DateTime shutdownTime = new DateTime();
            // shutdownTime = Convert.ToDateTime(this.computerSettings.AutoShutdown.ShutdownDateTime_SettingValue);
            shownShutdownWarning = false;
            if (DateTime.Now.AddMinutes(5) >= shutdownTime)
                return;
            thShutdownTimer = new Thread(new ThreadStart(ThShutdownWorks));
            thShutdownTimer.Priority = ThreadPriority.Normal;
            thShutdownTimer.Name = "shutdownTimer";
            thShutdownTimer.IsBackground = true;
            // if (this.computerSettings.AutoShutdown.ShutdownStatus_SettingValue)
            //  thShutdownTimer.Start();
        }
        private void ThShutdownWorks()
        {
            DateTime shutdownTime = new DateTime();
            // shutdownTime = Convert.ToDateTime(this.computerSettings.AutoShutdown.ShutdownDateTime_SettingValue);
            while (thShutdownTimer.IsAlive)
            {
                //show shutdown warning to user
                if (!shownShutdownWarning)
                {
                    if (DateTime.Now.AddMinutes(5) >= shutdownTime)
                    {
                        //alertBox.CreateAlert(this);
                        shownShutdownWarning = true;
                    }
                }
                #region MyRegion
                if (DateTime.Now.TimeOfDay >= shutdownTime.TimeOfDay)
                {
                    #region MyRegion

                    System.Diagnostics.Process[] processes = System.Diagnostics.Process.GetProcesses();

                    foreach (System.Diagnostics.Process processParent in processes)
                    {
                        System.Diagnostics.Process[] processNames = System.Diagnostics.Process.GetProcessesByName(processParent.ProcessName);

                        foreach (System.Diagnostics.Process processChild in processNames)
                        {
                            try
                            {
                                System.IntPtr hWnd = processChild.MainWindowHandle;

                                if (IsIconic(hWnd))
                                {
                                    ShowWindowAsync(hWnd, SW_RESTORE);
                                }

                                SetForegroundWindow(hWnd);

                                if (!(processChild.MainWindowTitle.Equals(this.Text)))
                                {
                                    processChild.CloseMainWindow();
                                    processChild.Kill();
                                    processChild.WaitForExit();
                                }
                            }
                            catch (Exception err)
                            {
                                // HVA.LGR.PointLoger.LogIt(err.Message);

                            }
                        }
                    }
                    #endregion

                    // System.Windows.Forms.Application.Exit();
                    // HVA.PrcsDt.WindowsController.ExitWindows(HVA.PrcsDt.RestartOptions.PowerOff, false);

                }
                #endregion
                Thread.Sleep(1000);
            }
        }

        #endregion

        #endregion
    }
}
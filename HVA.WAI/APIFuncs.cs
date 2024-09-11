using System;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Net;
using System.Management;
using System.Net.NetworkInformation;
using System.Collections.Generic;
using System.IO;

namespace HVA.WAI
{
    public class APIFuncs
    {
        #region DllImport
        //This Function is used to get Active Window Title...
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        public static extern int GetWindowText(IntPtr hwnd, string lpString, int cch);

        //This Function is used to get Handle for Active Window...
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern IntPtr GetForegroundWindow();

        //This Function is used to get Active process ID...
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern Int32 GetWindowThreadProcessId(IntPtr hWnd, out Int32 lpdwProcessId);
        #endregion
        List<PhysicalAddress> physicalAddress;
        public string ComputerName { get; private set; }
        public string AccountName { get; set; }
        public string OperatingSystem { get; set; }
        public IPAddress[] Ip { get; set; }
        public bool Is64BitOperatingSystem { get; set; }
        public bool Is64BitProcess { get; set; }
        public string CPUName { get; private set; }
        public string CPUID { get; private set; }
        public string[] MacAddresses { get; set; }
        public List<string> ValuemInfo{ get;private set; }
    
        public APIFuncs()
        {
            this.ComputerName = System.Environment.MachineName;
            this.OperatingSystem = System.Environment.OSVersion.ToString();
            this.Ip = Dns.GetHostByName(Dns.GetHostName()).AddressList;
            this.AccountName = System.Security.Principal.WindowsIdentity.GetCurrent().Name.ToString();
            this.Is64BitOperatingSystem = System.Environment.Is64BitOperatingSystem;
            this.Is64BitProcess = System.Environment.Is64BitProcess;
            GetCpuInfo();
            FindMacAddresses();
        }

        private void FindMacAddresses()
        {
            physicalAddress = new List<PhysicalAddress>();
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
                if (nic.OperationalStatus == OperationalStatus.Up)
                    physicalAddress.Add(nic.GetPhysicalAddress());
            int i = 0;
            this.MacAddresses = new string[physicalAddress.Count];
            foreach (PhysicalAddress pa in physicalAddress)
                this.MacAddresses[i++] = pa.ToString();
        }
        private void GetCpuInfo()
        {
            ManagementObjectSearcher oManagementObjectSearcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");
            ManagementObjectCollection oCollection = oManagementObjectSearcher.Get();

            foreach (ManagementObject oManagementObject in oCollection)
            {
                this.CPUID = (string)oManagementObject["ProcessorId"];
                this.CPUName = (string)oManagementObject["Name"];
                break;
            }
        }

        public List<string> GetValumesInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            this.ValuemInfo = new List<string>();
            foreach (DriveInfo d in allDrives)
            {
               if(d.IsReady)
                this.ValuemInfo.Add(d.VolumeLabel + "(" + d.Name + ")");
               else
                   this.ValuemInfo.Add(d.DriveType + "(" + d.Name + ")");
            }        
            return this.ValuemInfo;
        }
        public static Int32 GetWindowProcessID(IntPtr hwnd)
        {
            //This Function is used to get Active process ID...
            Int32 pid;
            GetWindowThreadProcessId(hwnd, out pid);
            return pid;
        }
        public static IntPtr getforegroundWindow()
        {
            //This method is used to get Handle for Active Window using GetForegroundWindow() method present in user32.dll
            return GetForegroundWindow();
        }
        public static string ActiveApplTitle()
        {
            //This method is used to get active application's title using GetWindowText() method present in user32.dll
            IntPtr hwnd = getforegroundWindow();
            if (hwnd.Equals(IntPtr.Zero)) return "";
            string lpText = new string((char)0, 100);
            int intLength = GetWindowText(hwnd, lpText, lpText.Length);
            if ((intLength <= 0) || (intLength > lpText.Length)) return "unknown";
            return lpText.Trim();
        }

    }
}

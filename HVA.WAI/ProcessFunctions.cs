using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace HVA.WAI
{

    public class ProcessFunctions
    {
        public static bool KillProcess(string processName)
        {
            try
            {
                Process[] processlist = Process.GetProcesses();

                foreach (Process p in processlist)
                {
                    if (p.ProcessName.ToLower() == processName.ToLower())
                    {
                        p.Kill();
                        p.WaitForExit();
                        return true;
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public static int KillThread(string className, string windowTitle)
        {
            int result = -1;
            try
            {
                // Determine the handle to the Calculator window.
                int i = Win32.FindWindow(className, windowTitle);
                // Post a message to Calc to end its existence.
                 result = Win32.SendMessage(i, Win32.WM_SYSCOMMAND, Win32.SC_CLOSE, 0);
            }
            catch (Exception)
            {

                return result;
            }
            return result;
        }
    }
    public class Win32
    {
        public const int WM_SYSCOMMAND = 0x0112;
        public const int SC_CLOSE = 0xF060;

        [DllImport("user32.dll")]
        public static extern int FindWindow(
            string lpClassName,  // class name
            string lpWindowName  // window name
            );
        [DllImport("user32.dll")]
        public static extern int SendMessage(
            int hWnd,      // handle to destination window
            uint Msg,       // message
            int wParam,  // first message parameter
            int lParam   // second message parameter
            );

    }
}

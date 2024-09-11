using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace HVA.WAI
{
    public class OSDateTime
    {
        public struct SystemTime
        {
            public ushort Year;
            public ushort Month;
            public ushort DayOfWeek;
            public ushort Day;
            public ushort Hour;
            public ushort Minute;
            public ushort Second;
            public ushort Millisecond;
        };
      
        #region MyRegion
        [DllImport("kernel32.dll")]
        static extern bool SetLocalTime([In] ref SystemTime lpLocalTime);

        [DllImport("kernel32.dll")]
        static extern bool GetLocalTime([In] ref SystemTime lpLocalTime);

        public static bool ChangeLocalDatetime(DateTime date)
        {
            try
            {
                SystemTime updatedTime = new SystemTime();
                updatedTime.Year = (ushort)date.Year;
                updatedTime.Month = (ushort)date.Month;
                updatedTime.Day = (ushort)date.Day;
                updatedTime.Hour = (ushort)date.Hour;
                updatedTime.Minute = (ushort)date.Minute;
                updatedTime.Second = (ushort)date.Second;
                // Call the unmanaged function that sets the new date and time instantly
                SetLocalTime(ref updatedTime);
                return true;
            }
            catch { return false; }
            return false;
        }
        public static bool ChangeLocalDatetime(ushort year, ushort month, ushort day,
                                                ushort hour, ushort minute, ushort second)
        {
            try
            {
                SystemTime updatedTime = new SystemTime();
                updatedTime.Year = year;
                updatedTime.Month = month;
                updatedTime.Day = day;
                updatedTime.Hour = hour;
                updatedTime.Minute = minute;
                updatedTime.Second = second;
                // Call the unmanaged function that sets the new date and time instantly
                SetLocalTime(ref updatedTime);
                return true;
            }
            catch { return false; }
            return false;
        }
        public static SystemTime GetLocalDatetime()
        {
            SystemTime systemTime = new SystemTime();
            try
            {
                GetLocalTime(ref systemTime);
            }
            catch { }
            return systemTime;
        }
        #endregion
        
        #region MyRegion
        [DllImport("kernel32.dll", EntryPoint = "GetSystemTime", SetLastError = true)]
        public extern static void Win32GetSystemTime(ref SystemTime sysTime);

        [DllImport("kernel32.dll", EntryPoint = "SetSystemTime", SetLastError = true)]
        public extern static bool Win32SetSystemTime(ref SystemTime sysTime);


        public static bool ChangeSystemDatetime(DateTime date)
        {
            try
            {
               SystemTime updatedTime = new SystemTime();
                updatedTime.Year = (ushort)date.Year;
                updatedTime.Month = (ushort)date.Month;
                updatedTime.Day = (ushort)date.Day;
                updatedTime.Hour = (ushort)date.Hour;
                updatedTime.Minute = (ushort)date.Minute;
                updatedTime.Second = (ushort)date.Second;
                // Call the unmanaged function that sets the new date and time instantly
                Win32SetSystemTime(ref updatedTime);
                return true;
            }
            catch { return false; }
            return false;
        }
        public static bool ChangeSystemDatetime(ushort year, ushort month, ushort day,
                                                ushort hour, ushort minute, ushort second)
        {
            try
            {
                SystemTime updatedTime = new SystemTime();
                updatedTime.Year = year;
                updatedTime.Month = month;
                updatedTime.Day = day;
                updatedTime.Hour = hour;
                updatedTime.Minute = minute;
                updatedTime.Second = second;
                // Call the unmanaged function that sets the new date and time instantly
                Win32SetSystemTime(ref updatedTime);
                return true;
            }
            catch { return false; }
            return false;
        }
        public static SystemTime GetSystemDatetime()
        {
            SystemTime systemTime = new SystemTime();
            try
            {
                Win32GetSystemTime(ref systemTime);
            }
            catch { }
            return systemTime;
        }
        #endregion
    }
}

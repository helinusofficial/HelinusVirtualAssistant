using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;


namespace HVA.Services
{
   public class UtilityService
    {
       public static string FindProgrammVersion()
       {
           FileVersionInfo myFileVersionInfo = FileVersionInfo.GetVersionInfo(AppDomain.CurrentDomain.BaseDirectory + "\\" +
                                                                               AppDomain.CurrentDomain.FriendlyName + ".exe");
           return myFileVersionInfo.FileVersion;
       }

       public static  DateTime CalculateTimeSpan(decimal hour, decimal minute)
       {
           return new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, (int)hour, (int)minute, 0);
       }
    }
}

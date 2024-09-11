using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace HVA.Services
{
   public sealed class AppSecurity
	{
	   private readonly string AppName;

	   public AppSecurity(string appName)
	   {
		   this.AppName = appName;
	   }

	   public bool IsDoubleInstance()
	   {
		   Process[] appProcesses = Process.GetProcessesByName(this.AppName);
			if (appProcesses.Length <=1)
				return false;
			return true;
	   }
	}
}

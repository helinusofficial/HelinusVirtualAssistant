using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace HVA.WAI
{
   public class DllInfo
    {
       public string File { get; set; }
       public FileVersionInfo FileVerInfo{ get; set; }
       public string Version { get; set; }

       public DllInfo(string filename)
       {
           this.File = filename;
          InitDllInfo();
       }
     

       private void InitDllInfo()
       {
           //System.Reflection.Assembly o = System.Reflection.Assembly.Load(this.Filename);
           this.FileVerInfo = FileVersionInfo.GetVersionInfo(this.File);
           this.Version = this.FileVerInfo.FileVersion;
       }
    }
}

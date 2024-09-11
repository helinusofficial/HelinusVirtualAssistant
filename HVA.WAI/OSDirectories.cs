using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HVA.WAI
{
    public class OSDirectories
    {
        public string ProgramFilesDirectory;
        public string IEDirectory;
        public string IEFilename = "iexplore.exe";

        public OSDirectories()
        {
            ProgramFilesDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.ProgramFiles);
            IEDirectory = ProgramFilesDirectory + "\\" + "Internet Explorer";
        }
        
    }
}

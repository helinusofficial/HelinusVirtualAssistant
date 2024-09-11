using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HVA.Services
{
    public class FileProcessService
    {
        StreamReader reader;
        StreamWriter writer;
        string fName = string.Empty;
        string fPath = string.Empty;
        string file = string.Empty;

        public FileProcessService(string fname)
        {
            fPath = AppDomain.CurrentDomain.BaseDirectory;
            file = fPath + "\\" + fname;
        }
        public bool IsValid()
        {
            FileInfo fi = new FileInfo(file);
            return fi.Exists;
        }
        public FileProcessService()
        {
            fPath = AppDomain.CurrentDomain.BaseDirectory;
        }

        public string ReadFileContent()
        {
            using (reader = new StreamReader(file))
            {
                if (IsValid())
                    return reader.ReadToEnd();
            }
            return string.Empty;
        }
        public bool WriteTofile(string value, bool checkFileValidate)
        {
            try
            {
                using (writer = new StreamWriter(file, checkFileValidate))
                {
                    writer.WriteLine(value);
                }
            }
            catch (Exception err)
            {
                       return false;
            }
            return true;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace HVA.WAI
{
    public class APIRegistery
    {
        RegistryKey rk;
        private RegistryKey baseRegistryKey = Registry.LocalMachine;
        public APIRegistery()
        {
            this.ShowError = false;
            this.SubKey = "SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run";
            rk = baseRegistryKey;
        }
        public APIRegistery(string path)
        {
            this.ShowError = false;
            this.SubKey = path;
            rk = baseRegistryKey;
        }

        public bool ShowError { get; set; }
        public string SubKey { get; set; }

        public RegistryKey BaseRegistryKey { get { return baseRegistryKey; } set { baseRegistryKey = value; } }

        public string Read(string KeyName)
        {
           RegistryKey sk1 = rk.OpenSubKey(this.SubKey);
            if (sk1 == null)
                return null;
            else
            {
                try
                {
                    return (string)sk1.GetValue(KeyName.ToUpper());
                }
                catch (Exception e)
                {

                    ShowErrorMessage(e, "Reading registry " + KeyName.ToUpper());
                    return null;
                }
            }
        }
        public bool Write(string KeyName, object Value)
        {
            try
            {
                RegistryKey sk1 = rk.CreateSubKey(this.SubKey);
                sk1.SetValue(KeyName.ToUpper(), Value);
                return true;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Writing registry " + KeyName.ToUpper());
                return false;
            }
        }
        public bool DeleteKey(string KeyName)
        {
            try
            {
                RegistryKey sk1 = rk.CreateSubKey(this.SubKey);
                if (sk1 == null)
                    return true;
                else
                    sk1.DeleteValue(KeyName);
              return true;
            }
            catch (Exception e)
            {

                ShowErrorMessage(e, "Deleting SubKey " + this.SubKey);
                return false;
            }
        }
        public bool DeleteSubKeyTree()
        {
            try
            {
                RegistryKey sk1 = rk.OpenSubKey(this.SubKey);
                if (sk1 != null)
                    rk.DeleteSubKeyTree(this.SubKey);

                return true;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Deleting SubKey " + this.SubKey);
                return false;
            }
        }
        public int SubKeyCount()
        {
            try
            {
                RegistryKey sk1 = rk.OpenSubKey(this.SubKey);
                if (sk1 != null)
                    return sk1.SubKeyCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Retriving subkeys of " + this.SubKey);
                return 0;
            }
        }
        public int ValueCount()
        {
            try
            {
                RegistryKey sk1 = rk.OpenSubKey(this.SubKey);
                if (sk1 != null)
                    return sk1.ValueCount;
                else
                    return 0;
            }
            catch (Exception e)
            {
                ShowErrorMessage(e, "Retriving keys of " + this.SubKey);
                return 0;
            }
        }
        private void ShowErrorMessage(Exception e, string Title)
        {
            if (this.ShowError) { }
            //MessageBox.Show(e.Message,
            //                Title
            //                , MessageBoxButtons.OK
            //                , MessageBoxIcon.Error);
        }

        public static bool SetRemoveAsStartUp(string appName, string appExecutablePath, bool set)
        {
            try
            {
               RegistryKey rkapp = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
                if (set)
                    rkapp.SetValue(appName, appExecutablePath);
                else
                    rkapp.DeleteValue(appName, false);
            }
            catch { return false; }
            return true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelinusVirtualAssistant
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            HVA.Services.AppSecurity appSecurity =
               new HVA.Services.AppSecurity(Application.ProductName);

            if (appSecurity.IsDoubleInstance())
            {
                MessageBox.Show(HVA.RS.FormsRS.AllPublicRS.DoubleInstance);
                return;
            }
            else
            {

                HVA.Services.ProcessSecurity processSecurity = new HVA.Services.ProcessSecurity();
                processSecurity.SetPermissions();
                Application.SetHighDpiMode(HighDpiMode.SystemAware);
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FormCenteral());
                // Application.Run(new HVAInfoBank.Forms.FormContactsEditor());
            }
        }
    }
}

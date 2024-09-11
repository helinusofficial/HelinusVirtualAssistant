using HVA.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HVA.UIFRMS.Help
{
    public partial class FormAbout : Form
    {
        public FormAbout()
        {
            InitializeComponent();
        }

        private void FormAbout_Load(object sender, EventArgs e)
        {
            labelVer.Text = UtilityService.FindProgrammVersion();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
      
        private void linkLabelCompanyLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(new ProcessStartInfo
            {
                FileName = linkLabelCompanyLink.Text,
                UseShellExecute = true
            });
        }
    }
}

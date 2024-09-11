using HVA.Services.MonitoringEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HVA.UIFRMS.Reports
{
    public partial class FormShowDetails : Form
    {
        private IDictionaryEnumerator capturedPackageList;
        private int selectedId;
        public FormShowDetails(IDictionaryEnumerator _capturedPackageList, int _selectedId)
        {
            capturedPackageList = _capturedPackageList;
            selectedId = _selectedId;
            InitializeComponent();
        }

        private void FormShowDetails_Load(object sender, EventArgs e)
        {
            Find();
        }

        private void Find()
        {
            try
            {
                dataGridViewDetailsReport.Rows.Clear();
                while (capturedPackageList.MoveNext())
                {
                    List<CClientPacketModel> x = new List<CClientPacketModel>();
                    x = (List<CClientPacketModel>)capturedPackageList.Value;

                    foreach (var o in x)
                    {
                        if (o.AppID == 0 || o.AppID != selectedId) continue;
                        if (o.AppName.ToLower() == "idle") continue;
                        if (o.AppName.ToLower() == "dllhost" && o.AppID <= 0) continue;
                        if (o.CaptureDate.Year == 0001) continue;
                        int itemp = 0;
                        if (o.AppName.ToLower() == "dllhost")
                            o.AppName = "Operating System";

                        base.Text = "Details View | " + o.AppName;
                        int h = dataGridViewDetailsReport.Rows.Add();
                        dataGridViewDetailsReport.Rows[h].Cells[itemp++].Value = o.AppID;
                        dataGridViewDetailsReport.Rows[h].Cells[itemp++].Value = o.CaptureDate;
                        dataGridViewDetailsReport.Rows[h].Cells[itemp++].Value = o.AppName;
                        dataGridViewDetailsReport.Rows[h].Cells[itemp++].Value = o.AppTitle;
                        dataGridViewDetailsReport.Rows[h].Cells[itemp++].Value = (new TimeSpan(Convert.ToInt64(o.WorkTime) * 10000000)).ToString(@"hh\:mm\:ss");
                    }
                }
            }
            catch { }
        }
    }
}

namespace HVA.UIFRMS.Reports
{
    partial class FormShowDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowDetails));
            this.dataGridViewDetailsReport = new System.Windows.Forms.DataGridView();
            this.APPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CapturedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.APPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailsReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewDetailsReport
            // 
            this.dataGridViewDetailsReport.AllowUserToAddRows = false;
            this.dataGridViewDetailsReport.AllowUserToDeleteRows = false;
            this.dataGridViewDetailsReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewDetailsReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetailsReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.APPID,
            this.CapturedDate,
            this.APPName,
            this.Title,
            this.TotalWork});
            this.dataGridViewDetailsReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewDetailsReport.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewDetailsReport.Name = "dataGridViewDetailsReport";
            this.dataGridViewDetailsReport.ReadOnly = true;
            this.dataGridViewDetailsReport.Size = new System.Drawing.Size(767, 496);
            this.dataGridViewDetailsReport.TabIndex = 6;
            // 
            // APPID
            // 
            this.APPID.HeaderText = "ID";
            this.APPID.Name = "APPID";
            this.APPID.ReadOnly = true;
            this.APPID.Width = 50;
            // 
            // CapturedDate
            // 
            this.CapturedDate.HeaderText = "Captured Date";
            this.CapturedDate.Name = "CapturedDate";
            this.CapturedDate.ReadOnly = true;
            this.CapturedDate.Width = 150;
            // 
            // APPName
            // 
            this.APPName.HeaderText = "Name";
            this.APPName.Name = "APPName";
            this.APPName.ReadOnly = true;
            this.APPName.Width = 150;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // TotalWork
            // 
            this.TotalWork.HeaderText = "Total Work";
            this.TotalWork.Name = "TotalWork";
            this.TotalWork.ReadOnly = true;
            // 
            // FormShowDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 496);
            this.Controls.Add(this.dataGridViewDetailsReport);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "FormShowDetails";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details View";
            this.Load += new System.EventHandler(this.FormShowDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetailsReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewDetailsReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapturedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWork;
    }
}
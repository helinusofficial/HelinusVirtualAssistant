namespace HelinusVirtualAssistant
{
    partial class FormCenteral
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCenteral));
            statusStripMain = new System.Windows.Forms.StatusStrip();
            toolStripStatusLabelVersion = new System.Windows.Forms.ToolStripStatusLabel();
            panelUpHolder = new System.Windows.Forms.Panel();
            panelControls = new System.Windows.Forms.Panel();
            labelLogoDetail = new System.Windows.Forms.Label();
            labelLogo = new System.Windows.Forms.Label();
            menuStripMain = new System.Windows.Forms.MenuStrip();
            fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItemStartAll = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            exitAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            panelCenter = new System.Windows.Forms.Panel();
            tabControlMain = new System.Windows.Forms.TabControl();
            tabPageInfo = new System.Windows.Forms.TabPage();
            groupBoxPCInfo = new System.Windows.Forms.GroupBox();
            labelSystemTime = new System.Windows.Forms.Label();
            label28 = new System.Windows.Forms.Label();
            labelAccount = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            labelComputer = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            labelOS = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            labelCPU = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            tabPageMonitoring = new System.Windows.Forms.TabPage();
            panelMonitoringDown = new System.Windows.Forms.Panel();
            dataGridViewReport = new System.Windows.Forms.DataGridView();
            APPID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            CapturedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            APPName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            TotalWork = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ShowDetails = new System.Windows.Forms.DataGridViewButtonColumn();
            panelMonitoringUp = new System.Windows.Forms.Panel();
            menuStripMonitoring = new System.Windows.Forms.MenuStrip();
            contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(components);
            toolStripMenuItemStopWorking = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            notifyIconMain = new System.Windows.Forms.NotifyIcon(components);
            statusStripMain.SuspendLayout();
            panelUpHolder.SuspendLayout();
            panelControls.SuspendLayout();
            menuStripMain.SuspendLayout();
            panelCenter.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabPageInfo.SuspendLayout();
            groupBoxPCInfo.SuspendLayout();
            tabPageMonitoring.SuspendLayout();
            panelMonitoringDown.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            panelMonitoringUp.SuspendLayout();
            contextMenuStripMain.SuspendLayout();
            SuspendLayout();
            // 
            // statusStripMain
            // 
            statusStripMain.BackColor = System.Drawing.Color.Transparent;
            statusStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripStatusLabelVersion });
            statusStripMain.Location = new System.Drawing.Point(0, 344);
            statusStripMain.Name = "statusStripMain";
            statusStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            statusStripMain.Size = new System.Drawing.Size(834, 22);
            statusStripMain.TabIndex = 2;
            statusStripMain.Text = "statusStrip1";
            // 
            // toolStripStatusLabelVersion
            // 
            toolStripStatusLabelVersion.Name = "toolStripStatusLabelVersion";
            toolStripStatusLabelVersion.Size = new System.Drawing.Size(51, 17);
            toolStripStatusLabelVersion.Text = "Version: ";
            // 
            // panelUpHolder
            // 
            panelUpHolder.Controls.Add(panelControls);
            panelUpHolder.Dock = System.Windows.Forms.DockStyle.Top;
            panelUpHolder.Location = new System.Drawing.Point(0, 24);
            panelUpHolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelUpHolder.Name = "panelUpHolder";
            panelUpHolder.Size = new System.Drawing.Size(834, 39);
            panelUpHolder.TabIndex = 3;
            // 
            // panelControls
            // 
            panelControls.BackColor = System.Drawing.Color.FromArgb(15, 78, 132);
            panelControls.Controls.Add(labelLogoDetail);
            panelControls.Controls.Add(labelLogo);
            panelControls.Dock = System.Windows.Forms.DockStyle.Top;
            panelControls.Location = new System.Drawing.Point(0, 0);
            panelControls.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelControls.Name = "panelControls";
            panelControls.Size = new System.Drawing.Size(834, 37);
            panelControls.TabIndex = 1;
            // 
            // labelLogoDetail
            // 
            labelLogoDetail.AutoSize = true;
            labelLogoDetail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLogoDetail.ForeColor = System.Drawing.Color.Silver;
            labelLogoDetail.Location = new System.Drawing.Point(96, 15);
            labelLogoDetail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLogoDetail.Name = "labelLogoDetail";
            labelLogoDetail.Size = new System.Drawing.Size(96, 12);
            labelLogoDetail.TabIndex = 3;
            labelLogoDetail.Text = "Virtual Assistant";
            // 
            // labelLogo
            // 
            labelLogo.AutoSize = true;
            labelLogo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            labelLogo.ForeColor = System.Drawing.Color.White;
            labelLogo.Location = new System.Drawing.Point(8, 6);
            labelLogo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelLogo.Name = "labelLogo";
            labelLogo.Size = new System.Drawing.Size(77, 22);
            labelLogo.TabIndex = 2;
            labelLogo.Text = "Helinus";
            // 
            // menuStripMain
            // 
            menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { fileToolStripMenuItem, helpToolStripMenuItem });
            menuStripMain.Location = new System.Drawing.Point(0, 0);
            menuStripMain.Name = "menuStripMain";
            menuStripMain.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStripMain.Size = new System.Drawing.Size(834, 24);
            menuStripMain.TabIndex = 4;
            menuStripMain.Text = "menuStripMain";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItemStartAll, toolStripSeparator6, exitAllToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // toolStripMenuItemStartAll
            // 
            toolStripMenuItemStartAll.Name = "toolStripMenuItemStartAll";
            toolStripMenuItemStartAll.Size = new System.Drawing.Size(98, 22);
            toolStripMenuItemStartAll.Text = "Start";
            toolStripMenuItemStartAll.Click += toolStripMenuItemStartAll_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(95, 6);
            // 
            // exitAllToolStripMenuItem
            // 
            exitAllToolStripMenuItem.Name = "exitAllToolStripMenuItem";
            exitAllToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            exitAllToolStripMenuItem.Text = "Exit";
            exitAllToolStripMenuItem.Click += exitAllToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { aboutToolStripMenuItem });
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            aboutToolStripMenuItem.Text = "About";
            aboutToolStripMenuItem.Click += aboutToolStripMenuItem_Click;
            // 
            // panelCenter
            // 
            panelCenter.Controls.Add(tabControlMain);
            panelCenter.Dock = System.Windows.Forms.DockStyle.Fill;
            panelCenter.Location = new System.Drawing.Point(0, 63);
            panelCenter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelCenter.Name = "panelCenter";
            panelCenter.Size = new System.Drawing.Size(834, 281);
            panelCenter.TabIndex = 6;
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPageInfo);
            tabControlMain.Controls.Add(tabPageMonitoring);
            tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            tabControlMain.Location = new System.Drawing.Point(0, 0);
            tabControlMain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new System.Drawing.Size(834, 281);
            tabControlMain.TabIndex = 6;
            // 
            // tabPageInfo
            // 
            tabPageInfo.Controls.Add(groupBoxPCInfo);
            tabPageInfo.Location = new System.Drawing.Point(4, 24);
            tabPageInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageInfo.Name = "tabPageInfo";
            tabPageInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageInfo.Size = new System.Drawing.Size(826, 253);
            tabPageInfo.TabIndex = 0;
            tabPageInfo.Text = "Information";
            tabPageInfo.UseVisualStyleBackColor = true;
            // 
            // groupBoxPCInfo
            // 
            groupBoxPCInfo.Controls.Add(labelSystemTime);
            groupBoxPCInfo.Controls.Add(label28);
            groupBoxPCInfo.Controls.Add(labelAccount);
            groupBoxPCInfo.Controls.Add(label3);
            groupBoxPCInfo.Controls.Add(labelComputer);
            groupBoxPCInfo.Controls.Add(label4);
            groupBoxPCInfo.Controls.Add(labelOS);
            groupBoxPCInfo.Controls.Add(label2);
            groupBoxPCInfo.Controls.Add(labelCPU);
            groupBoxPCInfo.Controls.Add(label1);
            groupBoxPCInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            groupBoxPCInfo.Location = new System.Drawing.Point(4, 3);
            groupBoxPCInfo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxPCInfo.Name = "groupBoxPCInfo";
            groupBoxPCInfo.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            groupBoxPCInfo.Size = new System.Drawing.Size(818, 247);
            groupBoxPCInfo.TabIndex = 5;
            groupBoxPCInfo.TabStop = false;
            groupBoxPCInfo.Text = "Computer information";
            // 
            // labelSystemTime
            // 
            labelSystemTime.AutoSize = true;
            labelSystemTime.Location = new System.Drawing.Point(509, 25);
            labelSystemTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelSystemTime.Name = "labelSystemTime";
            labelSystemTime.Size = new System.Drawing.Size(12, 15);
            labelSystemTime.TabIndex = 9;
            labelSystemTime.Text = "-";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new System.Drawing.Point(425, 25);
            label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label28.Name = "label28";
            label28.Size = new System.Drawing.Size(67, 15);
            label28.TabIndex = 8;
            label28.Text = "Local Time:";
            // 
            // labelAccount
            // 
            labelAccount.AutoSize = true;
            labelAccount.Location = new System.Drawing.Point(71, 46);
            labelAccount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelAccount.Name = "labelAccount";
            labelAccount.Size = new System.Drawing.Size(12, 15);
            labelAccount.TabIndex = 7;
            labelAccount.Text = "-";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(7, 46);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(55, 15);
            label3.TabIndex = 6;
            label3.Text = "Account:";
            // 
            // labelComputer
            // 
            labelComputer.AutoSize = true;
            labelComputer.Location = new System.Drawing.Point(71, 25);
            labelComputer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelComputer.Name = "labelComputer";
            labelComputer.Size = new System.Drawing.Size(12, 15);
            labelComputer.TabIndex = 5;
            labelComputer.Text = "-";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(7, 25);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(64, 15);
            label4.TabIndex = 4;
            label4.Text = "Computer:";
            // 
            // labelOS
            // 
            labelOS.AutoSize = true;
            labelOS.Location = new System.Drawing.Point(71, 67);
            labelOS.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelOS.Name = "labelOS";
            labelOS.Size = new System.Drawing.Size(12, 15);
            labelOS.TabIndex = 3;
            labelOS.Text = "-";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(7, 67);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(25, 15);
            label2.TabIndex = 2;
            label2.Text = "OS:";
            // 
            // labelCPU
            // 
            labelCPU.AutoSize = true;
            labelCPU.Location = new System.Drawing.Point(71, 88);
            labelCPU.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            labelCPU.Name = "labelCPU";
            labelCPU.Size = new System.Drawing.Size(12, 15);
            labelCPU.TabIndex = 1;
            labelCPU.Text = "-";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(7, 88);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(33, 15);
            label1.TabIndex = 0;
            label1.Text = "CPU:";
            // 
            // tabPageMonitoring
            // 
            tabPageMonitoring.Controls.Add(panelMonitoringDown);
            tabPageMonitoring.Controls.Add(panelMonitoringUp);
            tabPageMonitoring.Location = new System.Drawing.Point(4, 24);
            tabPageMonitoring.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageMonitoring.Name = "tabPageMonitoring";
            tabPageMonitoring.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            tabPageMonitoring.Size = new System.Drawing.Size(826, 253);
            tabPageMonitoring.TabIndex = 1;
            tabPageMonitoring.Text = "Monitoring";
            tabPageMonitoring.UseVisualStyleBackColor = true;
            // 
            // panelMonitoringDown
            // 
            panelMonitoringDown.Controls.Add(dataGridViewReport);
            panelMonitoringDown.Dock = System.Windows.Forms.DockStyle.Fill;
            panelMonitoringDown.Location = new System.Drawing.Point(4, 36);
            panelMonitoringDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelMonitoringDown.Name = "panelMonitoringDown";
            panelMonitoringDown.Size = new System.Drawing.Size(818, 214);
            panelMonitoringDown.TabIndex = 8;
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.AllowUserToAddRows = false;
            dataGridViewReport.AllowUserToDeleteRows = false;
            dataGridViewReport.BackgroundColor = System.Drawing.Color.White;
            dataGridViewReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { APPID, CapturedDate, APPName, TotalWork, ShowDetails });
            dataGridViewReport.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridViewReport.Location = new System.Drawing.Point(0, 0);
            dataGridViewReport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.ReadOnly = true;
            dataGridViewReport.Size = new System.Drawing.Size(818, 214);
            dataGridViewReport.TabIndex = 6;
            dataGridViewReport.CellClick += dataGridViewReport_CellClick;
            // 
            // APPID
            // 
            APPID.HeaderText = "ID";
            APPID.Name = "APPID";
            APPID.ReadOnly = true;
            APPID.Width = 50;
            // 
            // CapturedDate
            // 
            CapturedDate.HeaderText = "Captured Date";
            CapturedDate.Name = "CapturedDate";
            CapturedDate.ReadOnly = true;
            CapturedDate.Width = 150;
            // 
            // APPName
            // 
            APPName.HeaderText = "Name";
            APPName.Name = "APPName";
            APPName.ReadOnly = true;
            APPName.Width = 250;
            // 
            // TotalWork
            // 
            TotalWork.HeaderText = "Total Work";
            TotalWork.Name = "TotalWork";
            TotalWork.ReadOnly = true;
            // 
            // ShowDetails
            // 
            ShowDetails.HeaderText = "Show Details";
            ShowDetails.Name = "ShowDetails";
            ShowDetails.ReadOnly = true;
            ShowDetails.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            ShowDetails.Text = "View";
            ShowDetails.ToolTipText = "View Details";
            // 
            // panelMonitoringUp
            // 
            panelMonitoringUp.Controls.Add(menuStripMonitoring);
            panelMonitoringUp.Dock = System.Windows.Forms.DockStyle.Top;
            panelMonitoringUp.Location = new System.Drawing.Point(4, 3);
            panelMonitoringUp.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            panelMonitoringUp.Name = "panelMonitoringUp";
            panelMonitoringUp.Size = new System.Drawing.Size(818, 33);
            panelMonitoringUp.TabIndex = 7;
            // 
            // menuStripMonitoring
            // 
            menuStripMonitoring.Enabled = false;
            menuStripMonitoring.Location = new System.Drawing.Point(0, 0);
            menuStripMonitoring.Name = "menuStripMonitoring";
            menuStripMonitoring.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            menuStripMonitoring.Size = new System.Drawing.Size(818, 24);
            menuStripMonitoring.TabIndex = 0;
            menuStripMonitoring.Text = "menuStrip1";
            // 
            // contextMenuStripMain
            // 
            contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItemStopWorking, toolStripSeparator2, toolStripMenuItemAbout });
            contextMenuStripMain.Name = "contextMenuStripMain";
            contextMenuStripMain.Size = new System.Drawing.Size(147, 54);
            contextMenuStripMain.Text = "Stop";
            // 
            // toolStripMenuItemStopWorking
            // 
            toolStripMenuItemStopWorking.Image = Resources.stop;
            toolStripMenuItemStopWorking.Name = "toolStripMenuItemStopWorking";
            toolStripMenuItemStopWorking.Size = new System.Drawing.Size(146, 22);
            toolStripMenuItemStopWorking.Text = "Stop Working";
            toolStripMenuItemStopWorking.Click += toolStripMenuItemStopWorking_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // toolStripMenuItemAbout
            // 
            toolStripMenuItemAbout.Image = Resources.information;
            toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            toolStripMenuItemAbout.Size = new System.Drawing.Size(146, 22);
            toolStripMenuItemAbout.Text = "About";
            toolStripMenuItemAbout.Click += toolStripMenuItemAbout_Click;
            // 
            // notifyIconMain
            // 
            notifyIconMain.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            notifyIconMain.BalloonTipText = "Helinus Virtual Assistant";
            notifyIconMain.ContextMenuStrip = contextMenuStripMain;
            notifyIconMain.Icon = (System.Drawing.Icon)resources.GetObject("notifyIconMain.Icon");
            notifyIconMain.Text = "Helinus Virtual Assistant";
            // 
            // FormCenteral
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(834, 366);
            Controls.Add(panelCenter);
            Controls.Add(panelUpHolder);
            Controls.Add(statusStripMain);
            Controls.Add(menuStripMain);
            Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStripMain;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            Name = "FormCenteral";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Helinus Virtual Assistant";
            FormClosing += FormCenteral_FormClosing;
            Load += FormCenteral_Load;
            statusStripMain.ResumeLayout(false);
            statusStripMain.PerformLayout();
            panelUpHolder.ResumeLayout(false);
            panelControls.ResumeLayout(false);
            panelControls.PerformLayout();
            menuStripMain.ResumeLayout(false);
            menuStripMain.PerformLayout();
            panelCenter.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabPageInfo.ResumeLayout(false);
            groupBoxPCInfo.ResumeLayout(false);
            groupBoxPCInfo.PerformLayout();
            tabPageMonitoring.ResumeLayout(false);
            panelMonitoringDown.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            panelMonitoringUp.ResumeLayout(false);
            panelMonitoringUp.PerformLayout();
            contextMenuStripMain.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStripMain;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelVersion;
        private System.Windows.Forms.Panel panelUpHolder;
        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Label labelLogoDetail;
        private System.Windows.Forms.Label labelLogo;
        private System.Windows.Forms.Panel panelCenter;
        private System.Windows.Forms.ToolStripMenuItem exitAllToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStopWorking;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.NotifyIcon notifyIconMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemStartAll;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageInfo;
        private System.Windows.Forms.GroupBox groupBoxPCInfo;
        private System.Windows.Forms.Label labelSystemTime;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label labelAccount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelComputer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelOS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCPU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageMonitoring;
        private System.Windows.Forms.Panel panelMonitoringDown;
        private System.Windows.Forms.DataGridView dataGridViewReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CapturedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn APPName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalWork;
        private System.Windows.Forms.DataGridViewButtonColumn ShowDetails;
        private System.Windows.Forms.Panel panelMonitoringUp;
        private System.Windows.Forms.MenuStrip menuStripMonitoring;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    }
}
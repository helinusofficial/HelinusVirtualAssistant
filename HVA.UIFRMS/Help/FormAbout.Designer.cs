namespace HVA.UIFRMS.Help
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            labelVer = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonClose = new Button();
            label8 = new Label();
            linkLabelCompanyLink = new LinkLabel();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // labelVer
            // 
            labelVer.AutoSize = true;
            labelVer.Location = new Point(110, 55);
            labelVer.Margin = new Padding(4, 0, 4, 0);
            labelVer.Name = "labelVer";
            labelVer.Size = new Size(26, 15);
            labelVer.TabIndex = 16;
            labelVer.Text = "Ver:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 55);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 17;
            label6.Text = "Version:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(123, 168);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(251, 15);
            label5.TabIndex = 25;
            label5.Text = "All Right Reserved . Copyright © Helinus  2024";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 82);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 11;
            label1.Text = "Developed by:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(110, 29);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 15);
            label2.TabIndex = 12;
            label2.Text = "Helinus Virtual Assistant (HVA)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 29);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(42, 15);
            label3.TabIndex = 13;
            label3.Text = "Name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 8.25F);
            label4.Location = new Point(110, 82);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(117, 13);
            label4.TabIndex = 14;
            label4.Text = "Davood Motevalizadeh";
            // 
            // buttonClose
            // 
            buttonClose.Location = new Point(16, 162);
            buttonClose.Margin = new Padding(4, 3, 4, 3);
            buttonClose.Name = "buttonClose";
            buttonClose.Size = new Size(88, 27);
            buttonClose.TabIndex = 24;
            buttonClose.Text = "Close";
            buttonClose.UseVisualStyleBackColor = true;
            buttonClose.Click += buttonClose_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(36, 108);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(62, 15);
            label8.TabIndex = 21;
            label8.Text = "Company:";
            // 
            // linkLabelCompanyLink
            // 
            linkLabelCompanyLink.AutoSize = true;
            linkLabelCompanyLink.Location = new Point(110, 108);
            linkLabelCompanyLink.Margin = new Padding(4, 0, 4, 0);
            linkLabelCompanyLink.Name = "linkLabelCompanyLink";
            linkLabelCompanyLink.Size = new Size(137, 15);
            linkLabelCompanyLink.TabIndex = 20;
            linkLabelCompanyLink.TabStop = true;
            linkLabelCompanyLink.Text = "http://www.helinus.com";
            linkLabelCompanyLink.Click += linkLabelCompanyLink_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelVer);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(linkLabelCompanyLink);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label6);
            groupBox1.Location = new Point(14, 12);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(363, 142);
            groupBox1.TabIndex = 27;
            groupBox1.TabStop = false;
            groupBox1.Text = "About";
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(391, 199);
            Controls.Add(label5);
            Controls.Add(buttonClose);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "About | Helinus Virtual Assistant (HVA)";
            Load += FormAbout_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label labelVer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel linkLabelCompanyLink;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
namespace DVLD___System.Driving_License.Local
{
    partial class ShowLicenseHistory_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowLicenseHistory_Form));
            this.L_PageTitle = new System.Windows.Forms.Label();
            this.PB_PageIcon = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.L_LRecordsLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_LocalLicenses = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.L_IRecordsLength = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.DGV_InternationalLicenses = new System.Windows.Forms.DataGridView();
            this.BT_Close = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PCWF_PersonInfo = new DVLD___System.People.PersonCardWithFilter();
            ((System.ComponentModel.ISupportInitialize)(this.PB_PageIcon)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LocalLicenses)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InternationalLicenses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // L_PageTitle
            // 
            this.L_PageTitle.AutoSize = true;
            this.L_PageTitle.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PageTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.L_PageTitle.Location = new System.Drawing.Point(584, 49);
            this.L_PageTitle.Name = "L_PageTitle";
            this.L_PageTitle.Size = new System.Drawing.Size(307, 51);
            this.L_PageTitle.TabIndex = 8;
            this.L_PageTitle.Text = "License History";
            // 
            // PB_PageIcon
            // 
            this.PB_PageIcon.Image = ((System.Drawing.Image)(resources.GetObject("PB_PageIcon.Image")));
            this.PB_PageIcon.Location = new System.Drawing.Point(439, 18);
            this.PB_PageIcon.Name = "PB_PageIcon";
            this.PB_PageIcon.Size = new System.Drawing.Size(129, 106);
            this.PB_PageIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_PageIcon.TabIndex = 7;
            this.PB_PageIcon.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tabControl1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(14, 889);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1258, 551);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Driver Licenses";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 47);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1227, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage1.Controls.Add(this.L_LRecordsLength);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.DGV_LocalLicenses);
            this.tabPage1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1219, 454);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Local";
            // 
            // L_LRecordsLength
            // 
            this.L_LRecordsLength.AutoSize = true;
            this.L_LRecordsLength.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.L_LRecordsLength.Location = new System.Drawing.Point(156, 411);
            this.L_LRecordsLength.Name = "L_LRecordsLength";
            this.L_LRecordsLength.Size = new System.Drawing.Size(28, 32);
            this.L_LRecordsLength.TabIndex = 20;
            this.L_LRecordsLength.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 28);
            this.label3.TabIndex = 18;
            this.label3.Text = "Local Licenses History";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 19;
            this.label2.Text = "# Records: ";
            // 
            // DGV_LocalLicenses
            // 
            this.DGV_LocalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LocalLicenses.Location = new System.Drawing.Point(15, 73);
            this.DGV_LocalLicenses.Name = "DGV_LocalLicenses";
            this.DGV_LocalLicenses.RowHeadersWidth = 62;
            this.DGV_LocalLicenses.RowTemplate.Height = 28;
            this.DGV_LocalLicenses.Size = new System.Drawing.Size(1175, 322);
            this.DGV_LocalLicenses.TabIndex = 17;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkGray;
            this.tabPage2.Controls.Add(this.L_IRecordsLength);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.DGV_InternationalLicenses);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1219, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "International";
            // 
            // L_IRecordsLength
            // 
            this.L_IRecordsLength.AutoSize = true;
            this.L_IRecordsLength.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.L_IRecordsLength.Location = new System.Drawing.Point(160, 401);
            this.L_IRecordsLength.Name = "L_IRecordsLength";
            this.L_IRecordsLength.Size = new System.Drawing.Size(28, 32);
            this.L_IRecordsLength.TabIndex = 24;
            this.L_IRecordsLength.Text = "3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(316, 28);
            this.label4.TabIndex = 22;
            this.label4.Text = "International Licenses History";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 32);
            this.label5.TabIndex = 23;
            this.label5.Text = "# Records: ";
            // 
            // DGV_InternationalLicenses
            // 
            this.DGV_InternationalLicenses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_InternationalLicenses.Location = new System.Drawing.Point(19, 63);
            this.DGV_InternationalLicenses.Name = "DGV_InternationalLicenses";
            this.DGV_InternationalLicenses.RowHeadersWidth = 62;
            this.DGV_InternationalLicenses.RowTemplate.Height = 28;
            this.DGV_InternationalLicenses.Size = new System.Drawing.Size(1182, 322);
            this.DGV_InternationalLicenses.TabIndex = 21;
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Close.Image = ((System.Drawing.Image)(resources.GetObject("BT_Close.Image")));
            this.BT_Close.Location = new System.Drawing.Point(1151, 1446);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(121, 46);
            this.BT_Close.TabIndex = 18;
            this.BT_Close.Text = "Close";
            this.BT_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.DimGray;
            this.pictureBox2.Location = new System.Drawing.Point(548, 1446);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(204, 67);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // PCWF_PersonInfo
            // 
            this.PCWF_PersonInfo.BackColor = System.Drawing.Color.DimGray;
            this.PCWF_PersonInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PCWF_PersonInfo.Location = new System.Drawing.Point(5, 114);
            this.PCWF_PersonInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PCWF_PersonInfo.Name = "PCWF_PersonInfo";
            this.PCWF_PersonInfo.Size = new System.Drawing.Size(1267, 740);
            this.PCWF_PersonInfo.TabIndex = 0;
            // 
            // ShowLicenseHistory_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1323, 1050);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.L_PageTitle);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PB_PageIcon);
            this.Controls.Add(this.PCWF_PersonInfo);
            this.Name = "ShowLicenseHistory_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "License History";
            ((System.ComponentModel.ISupportInitialize)(this.PB_PageIcon)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LocalLicenses)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InternationalLicenses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private People.PersonCardWithFilter PCWF_PersonInfo;
        private System.Windows.Forms.Label L_PageTitle;
        private System.Windows.Forms.PictureBox PB_PageIcon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label L_LRecordsLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_LocalLicenses;
        private System.Windows.Forms.Label L_IRecordsLength;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView DGV_InternationalLicenses;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
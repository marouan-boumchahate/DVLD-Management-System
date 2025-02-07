namespace DVLD___System.Driving_License.Tests
{
    partial class TestAppointment_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TestAppointment_Form));
            this.L_RecordsLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_AppointmentsData = new System.Windows.Forms.DataGridView();
            this.CMS_AppointmentsShorcut = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ReSchedule_ShortCut = new System.Windows.Forms.ToolStripMenuItem();
            this.TakeTest_ShortCut = new System.Windows.Forms.ToolStripMenuItem();
            this.L_Title = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.PB_Title = new System.Windows.Forms.PictureBox();
            this.BT_Close = new System.Windows.Forms.Button();
            this.PB_ApplyForLocalDrivingLicense = new System.Windows.Forms.PictureBox();
            this.DLAC_DrivingLicenseApplication = new DVLD___System.Driving_License.Tests.DrivingLicenseApplicationCard();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AppointmentsData)).BeginInit();
            this.CMS_AppointmentsShorcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Title)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ApplyForLocalDrivingLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // L_RecordsLength
            // 
            this.L_RecordsLength.AutoSize = true;
            this.L_RecordsLength.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.L_RecordsLength.Location = new System.Drawing.Point(149, 1105);
            this.L_RecordsLength.Name = "L_RecordsLength";
            this.L_RecordsLength.Size = new System.Drawing.Size(28, 32);
            this.L_RecordsLength.TabIndex = 22;
            this.L_RecordsLength.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 766);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 32);
            this.label3.TabIndex = 20;
            this.label3.Text = "Appointments: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 1105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 21;
            this.label2.Text = "# Records: ";
            // 
            // DGV_AppointmentsData
            // 
            this.DGV_AppointmentsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_AppointmentsData.ContextMenuStrip = this.CMS_AppointmentsShorcut;
            this.DGV_AppointmentsData.Location = new System.Drawing.Point(8, 818);
            this.DGV_AppointmentsData.Name = "DGV_AppointmentsData";
            this.DGV_AppointmentsData.RowHeadersWidth = 62;
            this.DGV_AppointmentsData.RowTemplate.Height = 28;
            this.DGV_AppointmentsData.Size = new System.Drawing.Size(1003, 271);
            this.DGV_AppointmentsData.TabIndex = 19;
            // 
            // CMS_AppointmentsShorcut
            // 
            this.CMS_AppointmentsShorcut.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMS_AppointmentsShorcut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReSchedule_ShortCut,
            this.TakeTest_ShortCut});
            this.CMS_AppointmentsShorcut.Name = "CMS_ManagePeopleShortcuts";
            this.CMS_AppointmentsShorcut.Size = new System.Drawing.Size(327, 68);
            this.CMS_AppointmentsShorcut.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_AppointmentsShorcut_Opening);
            // 
            // ReSchedule_ShortCut
            // 
            this.ReSchedule_ShortCut.Image = ((System.Drawing.Image)(resources.GetObject("ReSchedule_ShortCut.Image")));
            this.ReSchedule_ShortCut.Name = "ReSchedule_ShortCut";
            this.ReSchedule_ShortCut.Size = new System.Drawing.Size(326, 32);
            this.ReSchedule_ShortCut.Text = "ReSchedule The Appointment";
            this.ReSchedule_ShortCut.Click += new System.EventHandler(this.ReSchedule_ShortCut_Click);
            // 
            // TakeTest_ShortCut
            // 
            this.TakeTest_ShortCut.Image = ((System.Drawing.Image)(resources.GetObject("TakeTest_ShortCut.Image")));
            this.TakeTest_ShortCut.Name = "TakeTest_ShortCut";
            this.TakeTest_ShortCut.Size = new System.Drawing.Size(326, 32);
            this.TakeTest_ShortCut.Text = "Take The Test";
            this.TakeTest_ShortCut.Click += new System.EventHandler(this.TakeTest_ShortCut_Click);
            // 
            // L_Title
            // 
            this.L_Title.AutoSize = true;
            this.L_Title.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Title.ForeColor = System.Drawing.Color.MediumBlue;
            this.L_Title.Location = new System.Drawing.Point(347, 129);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(254, 36);
            this.L_Title.TabIndex = 25;
            this.L_Title.Text = "Test Appointments";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(544, 1113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // PB_Title
            // 
            this.PB_Title.Image = global::DVLD___System.Properties.Resources.VisionTestLDLApplication;
            this.PB_Title.Location = new System.Drawing.Point(444, 12);
            this.PB_Title.Name = "PB_Title";
            this.PB_Title.Size = new System.Drawing.Size(150, 114);
            this.PB_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Title.TabIndex = 24;
            this.PB_Title.TabStop = false;
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Close.Image = ((System.Drawing.Image)(resources.GetObject("BT_Close.Image")));
            this.BT_Close.Location = new System.Drawing.Point(889, 1100);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(121, 46);
            this.BT_Close.TabIndex = 23;
            this.BT_Close.Text = "Close";
            this.BT_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // PB_ApplyForLocalDrivingLicense
            // 
            this.PB_ApplyForLocalDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("PB_ApplyForLocalDrivingLicense.Image")));
            this.PB_ApplyForLocalDrivingLicense.Location = new System.Drawing.Point(960, 754);
            this.PB_ApplyForLocalDrivingLicense.Name = "PB_ApplyForLocalDrivingLicense";
            this.PB_ApplyForLocalDrivingLicense.Size = new System.Drawing.Size(51, 62);
            this.PB_ApplyForLocalDrivingLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ApplyForLocalDrivingLicense.TabIndex = 18;
            this.PB_ApplyForLocalDrivingLicense.TabStop = false;
            this.PB_ApplyForLocalDrivingLicense.Click += new System.EventHandler(this.PB_ApplyForLocalDrivingLicense_Click);
            // 
            // DLAC_DrivingLicenseApplication
            // 
            this.DLAC_DrivingLicenseApplication.BackColor = System.Drawing.Color.Silver;
            this.DLAC_DrivingLicenseApplication.Location = new System.Drawing.Point(8, 196);
            this.DLAC_DrivingLicenseApplication.Name = "DLAC_DrivingLicenseApplication";
            this.DLAC_DrivingLicenseApplication.Size = new System.Drawing.Size(1003, 531);
            this.DLAC_DrivingLicenseApplication.TabIndex = 0;
            // 
            // TestAppointment_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1052, 1050);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.L_Title);
            this.Controls.Add(this.PB_Title);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.L_RecordsLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_AppointmentsData);
            this.Controls.Add(this.PB_ApplyForLocalDrivingLicense);
            this.Controls.Add(this.DLAC_DrivingLicenseApplication);
            this.Name = "TestAppointment_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Test";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_AppointmentsData)).EndInit();
            this.CMS_AppointmentsShorcut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Title)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ApplyForLocalDrivingLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DrivingLicenseApplicationCard DLAC_DrivingLicenseApplication;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Label L_RecordsLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_AppointmentsData;
        private System.Windows.Forms.PictureBox PB_ApplyForLocalDrivingLicense;
        private System.Windows.Forms.Label L_Title;
        private System.Windows.Forms.PictureBox PB_Title;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ContextMenuStrip CMS_AppointmentsShorcut;
        private System.Windows.Forms.ToolStripMenuItem ReSchedule_ShortCut;
        private System.Windows.Forms.ToolStripMenuItem TakeTest_ShortCut;
    }
}
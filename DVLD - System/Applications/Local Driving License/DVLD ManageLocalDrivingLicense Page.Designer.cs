namespace DVLD___System.Driving_License.Local
{
    partial class ManageLocalDrivingLicense_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageLocalDrivingLicense_Form));
            this.DT_ApplicationDate = new System.Windows.Forms.DateTimePicker();
            this.CB_Status = new System.Windows.Forms.ComboBox();
            this.TB_TextFilter = new System.Windows.Forms.TextBox();
            this.CB_FindApplicationBy = new System.Windows.Forms.ComboBox();
            this.l_RecordsLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_LDLAppData = new System.Windows.Forms.DataGridView();
            this.CMS_ManageLDLAppShortcuts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelApplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.writtenTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.streetTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueDrivingLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Close = new System.Windows.Forms.Button();
            this.PB_ApplyForLocalDrivingLicense = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LDLAppData)).BeginInit();
            this.CMS_ManageLDLAppShortcuts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ApplyForLocalDrivingLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DT_ApplicationDate
            // 
            this.DT_ApplicationDate.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DT_ApplicationDate.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.DT_ApplicationDate.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DT_ApplicationDate.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DT_ApplicationDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_ApplicationDate.Location = new System.Drawing.Point(405, 189);
            this.DT_ApplicationDate.Name = "DT_ApplicationDate";
            this.DT_ApplicationDate.Size = new System.Drawing.Size(179, 35);
            this.DT_ApplicationDate.TabIndex = 21;
            this.DT_ApplicationDate.Visible = false;
            this.DT_ApplicationDate.CloseUp += new System.EventHandler(this.DT_ApplicationDate_CloseUp);
            // 
            // CB_Status
            // 
            this.CB_Status.BackColor = System.Drawing.Color.DimGray;
            this.CB_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Status.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CB_Status.FormattingEnabled = true;
            this.CB_Status.Items.AddRange(new object[] {
            "All",
            "New",
            "Completed",
            "Cancelled"});
            this.CB_Status.Location = new System.Drawing.Point(405, 187);
            this.CB_Status.Name = "CB_Status";
            this.CB_Status.Size = new System.Drawing.Size(140, 36);
            this.CB_Status.TabIndex = 20;
            this.CB_Status.Visible = false;
            this.CB_Status.SelectedIndexChanged += new System.EventHandler(this.CB_Status_SelectedIndexChanged);
            // 
            // TB_TextFilter
            // 
            this.TB_TextFilter.BackColor = System.Drawing.Color.DimGray;
            this.TB_TextFilter.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TB_TextFilter.Location = new System.Drawing.Point(405, 188);
            this.TB_TextFilter.Name = "TB_TextFilter";
            this.TB_TextFilter.Size = new System.Drawing.Size(216, 35);
            this.TB_TextFilter.TabIndex = 19;
            this.TB_TextFilter.Visible = false;
            this.TB_TextFilter.TextChanged += new System.EventHandler(this.TB_TextFilter_TextChanged);
            this.TB_TextFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_TextFilter_KeyPress);
            // 
            // CB_FindApplicationBy
            // 
            this.CB_FindApplicationBy.BackColor = System.Drawing.Color.DimGray;
            this.CB_FindApplicationBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FindApplicationBy.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_FindApplicationBy.FormattingEnabled = true;
            this.CB_FindApplicationBy.Items.AddRange(new object[] {
            "None",
            "L.D.L.App ID",
            "Full Name",
            "National No",
            "Driving Class",
            "Application Date",
            "Passed Tests",
            "Status"});
            this.CB_FindApplicationBy.Location = new System.Drawing.Point(133, 188);
            this.CB_FindApplicationBy.Name = "CB_FindApplicationBy";
            this.CB_FindApplicationBy.Size = new System.Drawing.Size(252, 36);
            this.CB_FindApplicationBy.TabIndex = 18;
            this.CB_FindApplicationBy.SelectedIndexChanged += new System.EventHandler(this.CB_FindApplicationBy_SelectedIndexChanged);
            // 
            // l_RecordsLength
            // 
            this.l_RecordsLength.AutoSize = true;
            this.l_RecordsLength.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.l_RecordsLength.Location = new System.Drawing.Point(151, 590);
            this.l_RecordsLength.Name = "l_RecordsLength";
            this.l_RecordsLength.Size = new System.Drawing.Size(28, 32);
            this.l_RecordsLength.TabIndex = 16;
            this.l_RecordsLength.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Find By: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 590);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "# Records: ";
            // 
            // DGV_LDLAppData
            // 
            this.DGV_LDLAppData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_LDLAppData.ContextMenuStrip = this.CMS_ManageLDLAppShortcuts;
            this.DGV_LDLAppData.Location = new System.Drawing.Point(10, 252);
            this.DGV_LDLAppData.Name = "DGV_LDLAppData";
            this.DGV_LDLAppData.RowHeadersWidth = 62;
            this.DGV_LDLAppData.RowTemplate.Height = 28;
            this.DGV_LDLAppData.Size = new System.Drawing.Size(1227, 322);
            this.DGV_LDLAppData.TabIndex = 13;
            // 
            // CMS_ManageLDLAppShortcuts
            // 
            this.CMS_ManageLDLAppShortcuts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMS_ManageLDLAppShortcuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showApplicationToolStripMenuItem,
            this.editApplicationToolStripMenuItem,
            this.deleteApplicationToolStripMenuItem,
            this.cancelApplicationToolStripMenuItem,
            this.scheduleTestToolStripMenuItem,
            this.issueDrivingLicenseToolStripMenuItem,
            this.showLicenseToolStripMenuItem,
            this.showPersonLicenseHistoryToolStripMenuItem});
            this.CMS_ManageLDLAppShortcuts.Name = "CMS_ManagePeopleShortcuts";
            this.CMS_ManageLDLAppShortcuts.Size = new System.Drawing.Size(347, 293);
            this.CMS_ManageLDLAppShortcuts.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_ManageLDLAppShortcuts_Opening);
            this.CMS_ManageLDLAppShortcuts.Opened += new System.EventHandler(this.CMS_ManageLDLAppShortcuts_opened);
            // 
            // showApplicationToolStripMenuItem
            // 
            this.showApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showApplicationToolStripMenuItem.Image")));
            this.showApplicationToolStripMenuItem.Name = "showApplicationToolStripMenuItem";
            this.showApplicationToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.showApplicationToolStripMenuItem.Text = "Show Application Details";
            this.showApplicationToolStripMenuItem.Click += new System.EventHandler(this.showApplicationToolStripMenuItem_Click);
            // 
            // editApplicationToolStripMenuItem
            // 
            this.editApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editApplicationToolStripMenuItem.Image")));
            this.editApplicationToolStripMenuItem.Name = "editApplicationToolStripMenuItem";
            this.editApplicationToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.editApplicationToolStripMenuItem.Text = "Edit Application";
            this.editApplicationToolStripMenuItem.Click += new System.EventHandler(this.editApplicationToolStripMenuItem_Click);
            // 
            // deleteApplicationToolStripMenuItem
            // 
            this.deleteApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteApplicationToolStripMenuItem.Image")));
            this.deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            this.deleteApplicationToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.deleteApplicationToolStripMenuItem.Text = "Delete Application";
            this.deleteApplicationToolStripMenuItem.Click += new System.EventHandler(this.deleteApplicationToolStripMenuItem_Click);
            // 
            // cancelApplicationToolStripMenuItem
            // 
            this.cancelApplicationToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cancelApplicationToolStripMenuItem.Image")));
            this.cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            this.cancelApplicationToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            this.cancelApplicationToolStripMenuItem.Click += new System.EventHandler(this.cancelApplicationToolStripMenuItem_Click);
            // 
            // scheduleTestToolStripMenuItem
            // 
            this.scheduleTestToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.visionTestToolStripMenuItem,
            this.writtenTestToolStripMenuItem,
            this.streetTestToolStripMenuItem});
            this.scheduleTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("scheduleTestToolStripMenuItem.Image")));
            this.scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            this.scheduleTestToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.scheduleTestToolStripMenuItem.Text = "Schedule Test";
            // 
            // visionTestToolStripMenuItem
            // 
            this.visionTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("visionTestToolStripMenuItem.Image")));
            this.visionTestToolStripMenuItem.Name = "visionTestToolStripMenuItem";
            this.visionTestToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.visionTestToolStripMenuItem.Tag = "1";
            this.visionTestToolStripMenuItem.Text = "Schedule Vision Test";
            this.visionTestToolStripMenuItem.Click += new System.EventHandler(this.TestToolStripMenuItem_Click);
            // 
            // writtenTestToolStripMenuItem
            // 
            this.writtenTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("writtenTestToolStripMenuItem.Image")));
            this.writtenTestToolStripMenuItem.Name = "writtenTestToolStripMenuItem";
            this.writtenTestToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.writtenTestToolStripMenuItem.Tag = "2";
            this.writtenTestToolStripMenuItem.Text = "Schedule Written Test";
            this.writtenTestToolStripMenuItem.Click += new System.EventHandler(this.TestToolStripMenuItem_Click);
            // 
            // streetTestToolStripMenuItem
            // 
            this.streetTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("streetTestToolStripMenuItem.Image")));
            this.streetTestToolStripMenuItem.Name = "streetTestToolStripMenuItem";
            this.streetTestToolStripMenuItem.Size = new System.Drawing.Size(283, 34);
            this.streetTestToolStripMenuItem.Tag = "3";
            this.streetTestToolStripMenuItem.Text = "Schedule Street Test";
            this.streetTestToolStripMenuItem.Click += new System.EventHandler(this.TestToolStripMenuItem_Click);
            // 
            // issueDrivingLicenseToolStripMenuItem
            // 
            this.issueDrivingLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("issueDrivingLicenseToolStripMenuItem.Image")));
            this.issueDrivingLicenseToolStripMenuItem.Name = "issueDrivingLicenseToolStripMenuItem";
            this.issueDrivingLicenseToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.issueDrivingLicenseToolStripMenuItem.Text = "Issue Driving License (First Time)";
            this.issueDrivingLicenseToolStripMenuItem.Click += new System.EventHandler(this.issueDrivingLicenseToolStripMenuItem_Click);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem.Image")));
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showPersonLicenseHistoryToolStripMenuItem
            // 
            this.showPersonLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonLicenseHistoryToolStripMenuItem.Image")));
            this.showPersonLicenseHistoryToolStripMenuItem.Name = "showPersonLicenseHistoryToolStripMenuItem";
            this.showPersonLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(346, 32);
            this.showPersonLicenseHistoryToolStripMenuItem.Text = "Show Person License History";
            this.showPersonLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showPersonLicenseHistoryToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(425, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(421, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Manage Local Driving License";
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Close.Image = ((System.Drawing.Image)(resources.GetObject("BT_Close.Image")));
            this.BT_Close.Location = new System.Drawing.Point(1114, 580);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(121, 46);
            this.BT_Close.TabIndex = 17;
            this.BT_Close.Text = "Close";
            this.BT_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // PB_ApplyForLocalDrivingLicense
            // 
            this.PB_ApplyForLocalDrivingLicense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_ApplyForLocalDrivingLicense.Cursor = System.Windows.Forms.Cursors.Default;
            this.PB_ApplyForLocalDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("PB_ApplyForLocalDrivingLicense.Image")));
            this.PB_ApplyForLocalDrivingLicense.Location = new System.Drawing.Point(1160, 161);
            this.PB_ApplyForLocalDrivingLicense.Name = "PB_ApplyForLocalDrivingLicense";
            this.PB_ApplyForLocalDrivingLicense.Size = new System.Drawing.Size(75, 85);
            this.PB_ApplyForLocalDrivingLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ApplyForLocalDrivingLicense.TabIndex = 10;
            this.PB_ApplyForLocalDrivingLicense.TabStop = false;
            this.PB_ApplyForLocalDrivingLicense.Click += new System.EventHandler(this.PB_ApplyForLocalDrivingLicense_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(552, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ManageLocalDrivingLicense_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1252, 650);
            this.Controls.Add(this.DT_ApplicationDate);
            this.Controls.Add(this.CB_Status);
            this.Controls.Add(this.TB_TextFilter);
            this.Controls.Add(this.CB_FindApplicationBy);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.l_RecordsLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_LDLAppData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_ApplyForLocalDrivingLicense);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageLocalDrivingLicense_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Local Driving License";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_LDLAppData)).EndInit();
            this.CMS_ManageLDLAppShortcuts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_ApplyForLocalDrivingLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DT_ApplicationDate;
        private System.Windows.Forms.ComboBox CB_Status;
        private System.Windows.Forms.TextBox TB_TextFilter;
        private System.Windows.Forms.ComboBox CB_FindApplicationBy;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Label l_RecordsLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_LDLAppData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_ApplyForLocalDrivingLicense;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip CMS_ManageLDLAppShortcuts;
        private System.Windows.Forms.ToolStripMenuItem showApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueDrivingLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonLicenseHistoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem writtenTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem streetTestToolStripMenuItem;
    }
}
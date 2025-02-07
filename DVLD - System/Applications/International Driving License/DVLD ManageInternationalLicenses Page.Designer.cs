namespace DVLD___System.Driving_License.International
{
    partial class ManageInterLicenses_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageInterLicenses_Form));
            this.BT_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ShowLicensesHistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ShowLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_ManageInternationalLicensesShortcuts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.DT_Date = new System.Windows.Forms.DateTimePicker();
            this.CB_Activity = new System.Windows.Forms.ComboBox();
            this.TB_TextFilter = new System.Windows.Forms.TextBox();
            this.CB_FindApplicationBy = new System.Windows.Forms.ComboBox();
            this.l_RecordsLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_InterLicensesData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.PB_ApplyForLocalDrivingLicense = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CMS_ManageInternationalLicensesShortcuts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InterLicensesData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ApplyForLocalDrivingLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Close.Image = ((System.Drawing.Image)(resources.GetObject("BT_Close.Image")));
            this.BT_Close.Location = new System.Drawing.Point(1145, 589);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(121, 46);
            this.BT_Close.TabIndex = 29;
            this.BT_Close.Text = "Close";
            this.BT_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(583, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // ShowLicensesHistToolStripMenuItem
            // 
            this.ShowLicensesHistToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowLicensesHistToolStripMenuItem.Image")));
            this.ShowLicensesHistToolStripMenuItem.Name = "ShowLicensesHistToolStripMenuItem";
            this.ShowLicensesHistToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.ShowLicensesHistToolStripMenuItem.Text = "Show Person License History";
            this.ShowLicensesHistToolStripMenuItem.Click += new System.EventHandler(this.ShowLicensesHistToolStripMenuItem_Click);
            // 
            // ShowLicenseToolStripMenuItem
            // 
            this.ShowLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ShowLicenseToolStripMenuItem.Image")));
            this.ShowLicenseToolStripMenuItem.Name = "ShowLicenseToolStripMenuItem";
            this.ShowLicenseToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.ShowLicenseToolStripMenuItem.Text = "Show License Details";
            this.ShowLicenseToolStripMenuItem.Click += new System.EventHandler(this.ShowLicenseToolStripMenuItem_Click);
            // 
            // showPersonToolStripMenuItem
            // 
            this.showPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonToolStripMenuItem.Image")));
            this.showPersonToolStripMenuItem.Name = "showPersonToolStripMenuItem";
            this.showPersonToolStripMenuItem.Size = new System.Drawing.Size(317, 32);
            this.showPersonToolStripMenuItem.Text = "Show Person Details";
            this.showPersonToolStripMenuItem.Click += new System.EventHandler(this.showPersonToolStripMenuItem_Click);
            // 
            // CMS_ManageInternationalLicensesShortcuts
            // 
            this.CMS_ManageInternationalLicensesShortcuts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMS_ManageInternationalLicensesShortcuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonToolStripMenuItem,
            this.ShowLicenseToolStripMenuItem,
            this.ShowLicensesHistToolStripMenuItem});
            this.CMS_ManageInternationalLicensesShortcuts.Name = "CMS_ManagePeopleShortcuts";
            this.CMS_ManageInternationalLicensesShortcuts.Size = new System.Drawing.Size(318, 133);
            this.CMS_ManageInternationalLicensesShortcuts.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_ManageInternationalLicensesShortcuts_Opening);
            // 
            // DT_Date
            // 
            this.DT_Date.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DT_Date.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.DT_Date.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DT_Date.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DT_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Date.Location = new System.Drawing.Point(436, 196);
            this.DT_Date.Name = "DT_Date";
            this.DT_Date.Size = new System.Drawing.Size(179, 35);
            this.DT_Date.TabIndex = 33;
            this.DT_Date.Visible = false;
            this.DT_Date.CloseUp += new System.EventHandler(this.DT_Date_CloseUp);
            // 
            // CB_Activity
            // 
            this.CB_Activity.BackColor = System.Drawing.Color.DimGray;
            this.CB_Activity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Activity.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CB_Activity.FormattingEnabled = true;
            this.CB_Activity.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.CB_Activity.Location = new System.Drawing.Point(436, 196);
            this.CB_Activity.Name = "CB_Activity";
            this.CB_Activity.Size = new System.Drawing.Size(140, 36);
            this.CB_Activity.TabIndex = 32;
            this.CB_Activity.Visible = false;
            this.CB_Activity.SelectedIndexChanged += new System.EventHandler(this.CB_Activity_SelectedIndexChanged);
            // 
            // TB_TextFilter
            // 
            this.TB_TextFilter.BackColor = System.Drawing.Color.DimGray;
            this.TB_TextFilter.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TB_TextFilter.Location = new System.Drawing.Point(436, 197);
            this.TB_TextFilter.Name = "TB_TextFilter";
            this.TB_TextFilter.Size = new System.Drawing.Size(216, 35);
            this.TB_TextFilter.TabIndex = 31;
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
            "International License ID",
            "Local License ID",
            "Application ID",
            "Driver ID",
            "Issue Date",
            "Expiration Date",
            "is Active"});
            this.CB_FindApplicationBy.Location = new System.Drawing.Point(164, 197);
            this.CB_FindApplicationBy.Name = "CB_FindApplicationBy";
            this.CB_FindApplicationBy.Size = new System.Drawing.Size(252, 36);
            this.CB_FindApplicationBy.TabIndex = 30;
            this.CB_FindApplicationBy.SelectedIndexChanged += new System.EventHandler(this.CB_FindLicenseBy_SelectedIndexChanged);
            // 
            // l_RecordsLength
            // 
            this.l_RecordsLength.AutoSize = true;
            this.l_RecordsLength.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.l_RecordsLength.Location = new System.Drawing.Point(182, 599);
            this.l_RecordsLength.Name = "l_RecordsLength";
            this.l_RecordsLength.Size = new System.Drawing.Size(28, 32);
            this.l_RecordsLength.TabIndex = 28;
            this.l_RecordsLength.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Find By: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "# Records: ";
            // 
            // DGV_InterLicensesData
            // 
            this.DGV_InterLicensesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_InterLicensesData.ContextMenuStrip = this.CMS_ManageInternationalLicensesShortcuts;
            this.DGV_InterLicensesData.Location = new System.Drawing.Point(41, 261);
            this.DGV_InterLicensesData.Name = "DGV_InterLicensesData";
            this.DGV_InterLicensesData.RowHeadersWidth = 62;
            this.DGV_InterLicensesData.RowTemplate.Height = 28;
            this.DGV_InterLicensesData.Size = new System.Drawing.Size(1227, 322);
            this.DGV_InterLicensesData.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(409, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(519, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Manage International Driving License";
            // 
            // PB_ApplyForLocalDrivingLicense
            // 
            this.PB_ApplyForLocalDrivingLicense.Image = ((System.Drawing.Image)(resources.GetObject("PB_ApplyForLocalDrivingLicense.Image")));
            this.PB_ApplyForLocalDrivingLicense.Location = new System.Drawing.Point(1193, 170);
            this.PB_ApplyForLocalDrivingLicense.Name = "PB_ApplyForLocalDrivingLicense";
            this.PB_ApplyForLocalDrivingLicense.Size = new System.Drawing.Size(75, 85);
            this.PB_ApplyForLocalDrivingLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ApplyForLocalDrivingLicense.TabIndex = 22;
            this.PB_ApplyForLocalDrivingLicense.TabStop = false;
            this.PB_ApplyForLocalDrivingLicense.Click += new System.EventHandler(this.PB_ApplyForLocalDrivingLicense_Click);
            // 
            // ManageInterLicenses_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1302, 653);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DT_Date);
            this.Controls.Add(this.CB_Activity);
            this.Controls.Add(this.TB_TextFilter);
            this.Controls.Add(this.CB_FindApplicationBy);
            this.Controls.Add(this.l_RecordsLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_InterLicensesData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_ApplyForLocalDrivingLicense);
            this.Name = "ManageInterLicenses_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage International Licenses";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CMS_ManageInternationalLicensesShortcuts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_InterLicensesData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ApplyForLocalDrivingLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem ShowLicensesHistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ShowLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMS_ManageInternationalLicensesShortcuts;
        private System.Windows.Forms.DateTimePicker DT_Date;
        private System.Windows.Forms.ComboBox CB_Activity;
        private System.Windows.Forms.TextBox TB_TextFilter;
        private System.Windows.Forms.ComboBox CB_FindApplicationBy;
        private System.Windows.Forms.Label l_RecordsLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_InterLicensesData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_ApplyForLocalDrivingLicense;
    }
}
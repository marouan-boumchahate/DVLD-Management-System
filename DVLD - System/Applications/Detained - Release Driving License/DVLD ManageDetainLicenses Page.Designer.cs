namespace DVLD___System.Driving_License.Detained___Release
{
    partial class MngDetainLicenses_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MngDetainLicenses_Form));
            this.BT_Close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.showLicensesHistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPersonDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CMS_ManageLDLAppShortcuts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.releaseLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DT_Date = new System.Windows.Forms.DateTimePicker();
            this.CB_Status = new System.Windows.Forms.ComboBox();
            this.TB_TextFilter = new System.Windows.Forms.TextBox();
            this.CB_FindDetainLicenseBy = new System.Windows.Forms.ComboBox();
            this.l_RecordsLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_DetainedLicenseData = new System.Windows.Forms.DataGridView();
            this.PB_DetainLicense = new System.Windows.Forms.PictureBox();
            this.PB_ReleaseLicense = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CMS_ManageLDLAppShortcuts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DetainedLicenseData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_DetainLicense)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ReleaseLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Close.Image = ((System.Drawing.Image)(resources.GetObject("BT_Close.Image")));
            this.BT_Close.Location = new System.Drawing.Point(1120, 574);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(121, 46);
            this.BT_Close.TabIndex = 29;
            this.BT_Close.Text = "Close";
            this.BT_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(474, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 36);
            this.label1.TabIndex = 24;
            this.label1.Text = "Manage Detain Licenses";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(558, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // showLicensesHistToolStripMenuItem
            // 
            this.showLicensesHistToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicensesHistToolStripMenuItem.Image")));
            this.showLicensesHistToolStripMenuItem.Name = "showLicensesHistToolStripMenuItem";
            this.showLicensesHistToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.showLicensesHistToolStripMenuItem.Text = "Show Licenses History";
            this.showLicensesHistToolStripMenuItem.Click += new System.EventHandler(this.showLicensesHistToolStripMenuItem_Click);
            // 
            // showLicenseDetailsToolStripMenuItem
            // 
            this.showLicenseDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseDetailsToolStripMenuItem.Image")));
            this.showLicenseDetailsToolStripMenuItem.Name = "showLicenseDetailsToolStripMenuItem";
            this.showLicenseDetailsToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.showLicenseDetailsToolStripMenuItem.Text = "Show License Details";
            this.showLicenseDetailsToolStripMenuItem.Click += new System.EventHandler(this.showLicenseDetailsToolStripMenuItem_Click);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            this.showPersonDetailsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showPersonDetailsToolStripMenuItem.Image")));
            this.showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            this.showPersonDetailsToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            this.showPersonDetailsToolStripMenuItem.Click += new System.EventHandler(this.showPersonDetailsToolStripMenuItem_Click);
            // 
            // CMS_ManageLDLAppShortcuts
            // 
            this.CMS_ManageLDLAppShortcuts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMS_ManageLDLAppShortcuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showPersonDetailsToolStripMenuItem,
            this.showLicenseDetailsToolStripMenuItem,
            this.showLicensesHistToolStripMenuItem,
            this.releaseLicenseToolStripMenuItem});
            this.CMS_ManageLDLAppShortcuts.Name = "CMS_ManagePeopleShortcuts";
            this.CMS_ManageLDLAppShortcuts.Size = new System.Drawing.Size(268, 165);
            this.CMS_ManageLDLAppShortcuts.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_ManageDetainedLicenseShortcuts_Opening);
            // 
            // releaseLicenseToolStripMenuItem
            // 
            this.releaseLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("releaseLicenseToolStripMenuItem.Image")));
            this.releaseLicenseToolStripMenuItem.Name = "releaseLicenseToolStripMenuItem";
            this.releaseLicenseToolStripMenuItem.Size = new System.Drawing.Size(267, 32);
            this.releaseLicenseToolStripMenuItem.Text = "Release License";
            this.releaseLicenseToolStripMenuItem.Click += new System.EventHandler(this.releaseLicenseToolStripMenuItem_Click);
            // 
            // DT_Date
            // 
            this.DT_Date.CalendarFont = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DT_Date.CalendarMonthBackground = System.Drawing.Color.DimGray;
            this.DT_Date.CalendarTitleBackColor = System.Drawing.SystemColors.AppWorkspace;
            this.DT_Date.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DT_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Date.Location = new System.Drawing.Point(411, 181);
            this.DT_Date.Name = "DT_Date";
            this.DT_Date.Size = new System.Drawing.Size(179, 35);
            this.DT_Date.TabIndex = 33;
            this.DT_Date.Visible = false;
            this.DT_Date.CloseUp += new System.EventHandler(this.DT_ApplicationDate_CloseUp);
            // 
            // CB_Status
            // 
            this.CB_Status.BackColor = System.Drawing.Color.DimGray;
            this.CB_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Status.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CB_Status.FormattingEnabled = true;
            this.CB_Status.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.CB_Status.Location = new System.Drawing.Point(411, 181);
            this.CB_Status.Name = "CB_Status";
            this.CB_Status.Size = new System.Drawing.Size(140, 36);
            this.CB_Status.TabIndex = 32;
            this.CB_Status.Visible = false;
            this.CB_Status.SelectedIndexChanged += new System.EventHandler(this.CB_Status_SelectedIndexChanged);
            // 
            // TB_TextFilter
            // 
            this.TB_TextFilter.BackColor = System.Drawing.Color.DimGray;
            this.TB_TextFilter.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TB_TextFilter.Location = new System.Drawing.Point(411, 182);
            this.TB_TextFilter.Name = "TB_TextFilter";
            this.TB_TextFilter.Size = new System.Drawing.Size(216, 35);
            this.TB_TextFilter.TabIndex = 31;
            this.TB_TextFilter.Visible = false;
            this.TB_TextFilter.TextChanged += new System.EventHandler(this.TB_TextFilter_TextChanged);
            this.TB_TextFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_TextFilter_KeyPress);
            // 
            // CB_FindDetainLicenseBy
            // 
            this.CB_FindDetainLicenseBy.BackColor = System.Drawing.Color.DimGray;
            this.CB_FindDetainLicenseBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FindDetainLicenseBy.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_FindDetainLicenseBy.FormattingEnabled = true;
            this.CB_FindDetainLicenseBy.Items.AddRange(new object[] {
            "None",
            "Detain ID",
            "License ID",
            "Application ID",
            "Full Name",
            "National No",
            "Fine Fees",
            "Detain Date",
            "Release Date",
            "is Released"});
            this.CB_FindDetainLicenseBy.Location = new System.Drawing.Point(139, 182);
            this.CB_FindDetainLicenseBy.Name = "CB_FindDetainLicenseBy";
            this.CB_FindDetainLicenseBy.Size = new System.Drawing.Size(252, 36);
            this.CB_FindDetainLicenseBy.TabIndex = 30;
            this.CB_FindDetainLicenseBy.SelectedIndexChanged += new System.EventHandler(this.CB_FindDetainLicenseBy_SelectedIndexChanged);
            // 
            // l_RecordsLength
            // 
            this.l_RecordsLength.AutoSize = true;
            this.l_RecordsLength.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.l_RecordsLength.Location = new System.Drawing.Point(159, 584);
            this.l_RecordsLength.Name = "l_RecordsLength";
            this.l_RecordsLength.Size = new System.Drawing.Size(28, 32);
            this.l_RecordsLength.TabIndex = 28;
            this.l_RecordsLength.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 186);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 26;
            this.label3.Text = "Find By: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 584);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 27;
            this.label2.Text = "# Records: ";
            // 
            // DGV_DetainedLicenseData
            // 
            this.DGV_DetainedLicenseData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DetainedLicenseData.ContextMenuStrip = this.CMS_ManageLDLAppShortcuts;
            this.DGV_DetainedLicenseData.Location = new System.Drawing.Point(16, 246);
            this.DGV_DetainedLicenseData.Name = "DGV_DetainedLicenseData";
            this.DGV_DetainedLicenseData.RowHeadersWidth = 62;
            this.DGV_DetainedLicenseData.RowTemplate.Height = 28;
            this.DGV_DetainedLicenseData.Size = new System.Drawing.Size(1227, 322);
            this.DGV_DetainedLicenseData.TabIndex = 25;
            // 
            // PB_DetainLicense
            // 
            this.PB_DetainLicense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_DetainLicense.Image = ((System.Drawing.Image)(resources.GetObject("PB_DetainLicense.Image")));
            this.PB_DetainLicense.Location = new System.Drawing.Point(1173, 169);
            this.PB_DetainLicense.Name = "PB_DetainLicense";
            this.PB_DetainLicense.Size = new System.Drawing.Size(68, 71);
            this.PB_DetainLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_DetainLicense.TabIndex = 22;
            this.PB_DetainLicense.TabStop = false;
            this.toolTip1.SetToolTip(this.PB_DetainLicense, "Click here to detain a license");
            this.PB_DetainLicense.Click += new System.EventHandler(this.PB_DetainLicense_Click);
            // 
            // PB_ReleaseLicense
            // 
            this.PB_ReleaseLicense.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PB_ReleaseLicense.Image = ((System.Drawing.Image)(resources.GetObject("PB_ReleaseLicense.Image")));
            this.PB_ReleaseLicense.Location = new System.Drawing.Point(1086, 169);
            this.PB_ReleaseLicense.Name = "PB_ReleaseLicense";
            this.PB_ReleaseLicense.Size = new System.Drawing.Size(68, 71);
            this.PB_ReleaseLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_ReleaseLicense.TabIndex = 22;
            this.PB_ReleaseLicense.TabStop = false;
            this.toolTip1.SetToolTip(this.PB_ReleaseLicense, "Click here to Release license");
            this.PB_ReleaseLicense.Click += new System.EventHandler(this.PB_ReleaseLicense_Click);
            // 
            // MngDetainLicenses_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1258, 630);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.DT_Date);
            this.Controls.Add(this.CB_Status);
            this.Controls.Add(this.TB_TextFilter);
            this.Controls.Add(this.CB_FindDetainLicenseBy);
            this.Controls.Add(this.l_RecordsLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_DetainedLicenseData);
            this.Controls.Add(this.PB_ReleaseLicense);
            this.Controls.Add(this.PB_DetainLicense);
            this.Name = "MngDetainLicenses_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Detained Licenses";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CMS_ManageLDLAppShortcuts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DetainedLicenseData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_DetainLicense)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_ReleaseLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem showLicensesHistToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip CMS_ManageLDLAppShortcuts;
        private System.Windows.Forms.DateTimePicker DT_Date;
        private System.Windows.Forms.ComboBox CB_Status;
        private System.Windows.Forms.TextBox TB_TextFilter;
        private System.Windows.Forms.ComboBox CB_FindDetainLicenseBy;
        private System.Windows.Forms.Label l_RecordsLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_DetainedLicenseData;
        private System.Windows.Forms.PictureBox PB_DetainLicense;
        private System.Windows.Forms.PictureBox PB_ReleaseLicense;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolStripMenuItem releaseLicenseToolStripMenuItem;
    }
}
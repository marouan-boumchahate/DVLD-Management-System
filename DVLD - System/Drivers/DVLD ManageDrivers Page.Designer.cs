namespace DVLD___System.Drivers
{
    partial class ManageDrivers_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageDrivers_Form));
            this.DT_Date = new System.Windows.Forms.DateTimePicker();
            this.TB_TextFilter = new System.Windows.Forms.TextBox();
            this.CB_FindDriverBy = new System.Windows.Forms.ComboBox();
            this.BT_Close = new System.Windows.Forms.Button();
            this.l_RecordsLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_DriversData = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CMS_DriverShortCuts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showLicenseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showLicenseHistoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DriversData)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.CMS_DriverShortCuts.SuspendLayout();
            this.SuspendLayout();
            // 
            // DT_Date
            // 
            this.DT_Date.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DT_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_Date.Location = new System.Drawing.Point(436, 222);
            this.DT_Date.Name = "DT_Date";
            this.DT_Date.Size = new System.Drawing.Size(176, 35);
            this.DT_Date.TabIndex = 21;
            this.DT_Date.Visible = false;
            this.DT_Date.CloseUp += new System.EventHandler(this.DT_Date_CloseUp);
            // 
            // TB_TextFilter
            // 
            this.TB_TextFilter.BackColor = System.Drawing.Color.DimGray;
            this.TB_TextFilter.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TB_TextFilter.Location = new System.Drawing.Point(436, 222);
            this.TB_TextFilter.Name = "TB_TextFilter";
            this.TB_TextFilter.Size = new System.Drawing.Size(216, 35);
            this.TB_TextFilter.TabIndex = 19;
            this.TB_TextFilter.Visible = false;
            this.TB_TextFilter.TextChanged += new System.EventHandler(this.TB_TextFilter_TextChanged);
            this.TB_TextFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_TextFilter_KeyPress);
            // 
            // CB_FindDriverBy
            // 
            this.CB_FindDriverBy.BackColor = System.Drawing.Color.DimGray;
            this.CB_FindDriverBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FindDriverBy.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_FindDriverBy.FormattingEnabled = true;
            this.CB_FindDriverBy.Items.AddRange(new object[] {
            "None",
            "Driver ID",
            "Person ID",
            "National No",
            "Full Name",
            "Date",
            "Active Licenses"});
            this.CB_FindDriverBy.Location = new System.Drawing.Point(164, 222);
            this.CB_FindDriverBy.Name = "CB_FindDriverBy";
            this.CB_FindDriverBy.Size = new System.Drawing.Size(252, 36);
            this.CB_FindDriverBy.TabIndex = 18;
            this.CB_FindDriverBy.SelectedIndexChanged += new System.EventHandler(this.CB_FindDriverBy_SelectedIndexChanged);
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Close.Image = ((System.Drawing.Image)(resources.GetObject("BT_Close.Image")));
            this.BT_Close.Location = new System.Drawing.Point(1145, 614);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(121, 46);
            this.BT_Close.TabIndex = 17;
            this.BT_Close.Text = "Close";
            this.BT_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // l_RecordsLength
            // 
            this.l_RecordsLength.AutoSize = true;
            this.l_RecordsLength.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.l_RecordsLength.Location = new System.Drawing.Point(182, 624);
            this.l_RecordsLength.Name = "l_RecordsLength";
            this.l_RecordsLength.Size = new System.Drawing.Size(28, 32);
            this.l_RecordsLength.TabIndex = 16;
            this.l_RecordsLength.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Find By: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 624);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "# Records: ";
            // 
            // DGV_DriversData
            // 
            this.DGV_DriversData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_DriversData.ContextMenuStrip = this.CMS_DriverShortCuts;
            this.DGV_DriversData.Location = new System.Drawing.Point(41, 286);
            this.DGV_DriversData.Name = "DGV_DriversData";
            this.DGV_DriversData.RowHeadersWidth = 62;
            this.DGV_DriversData.RowTemplate.Height = 28;
            this.DGV_DriversData.Size = new System.Drawing.Size(1227, 322);
            this.DGV_DriversData.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(502, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Drivers Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(564, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // CMS_DriverShortCuts
            // 
            this.CMS_DriverShortCuts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMS_DriverShortCuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showLicenseToolStripMenuItem,
            this.showLicenseHistoryToolStripMenuItem});
            this.CMS_DriverShortCuts.Name = "CMS_DriverShortCuts";
            this.CMS_DriverShortCuts.Size = new System.Drawing.Size(260, 101);
            this.CMS_DriverShortCuts.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_DriverShortCuts_Opening);
            // 
            // showLicenseToolStripMenuItem
            // 
            this.showLicenseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseToolStripMenuItem.Image")));
            this.showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            this.showLicenseToolStripMenuItem.Size = new System.Drawing.Size(259, 32);
            this.showLicenseToolStripMenuItem.Text = "Show License";
            this.showLicenseToolStripMenuItem.Click += new System.EventHandler(this.showLicenseToolStripMenuItem_Click);
            // 
            // showLicenseHistoryToolStripMenuItem
            // 
            this.showLicenseHistoryToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showLicenseHistoryToolStripMenuItem.Image")));
            this.showLicenseHistoryToolStripMenuItem.Name = "showLicenseHistoryToolStripMenuItem";
            this.showLicenseHistoryToolStripMenuItem.Size = new System.Drawing.Size(259, 32);
            this.showLicenseHistoryToolStripMenuItem.Text = "Show License History";
            this.showLicenseHistoryToolStripMenuItem.Click += new System.EventHandler(this.showLicenseHistoryToolStripMenuItem_Click);
            // 
            // ManageDrivers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1303, 702);
            this.Controls.Add(this.DT_Date);
            this.Controls.Add(this.TB_TextFilter);
            this.Controls.Add(this.CB_FindDriverBy);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.l_RecordsLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_DriversData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageDrivers_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Manage Drivers";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_DriversData)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.CMS_DriverShortCuts.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DT_Date;
        private System.Windows.Forms.TextBox TB_TextFilter;
        private System.Windows.Forms.ComboBox CB_FindDriverBy;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Label l_RecordsLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_DriversData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip CMS_DriverShortCuts;
        private System.Windows.Forms.ToolStripMenuItem showLicenseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showLicenseHistoryToolStripMenuItem;
    }
}
namespace DVLD___System.Driving_License
{
    partial class LocalDrivingLicenseCardWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocalDrivingLicenseCardWithFilter));
            this.TB_TextFilter = new System.Windows.Forms.TextBox();
            this.PB_Search = new System.Windows.Forms.PictureBox();
            this.GB_Filter = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LDLC_LicenseInfo = new DVLD___System.Driving_License.LocalDrivingLicenseCard();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Search)).BeginInit();
            this.GB_Filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // TB_TextFilter
            // 
            this.TB_TextFilter.BackColor = System.Drawing.Color.DarkGray;
            this.TB_TextFilter.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TB_TextFilter.Location = new System.Drawing.Point(233, 38);
            this.TB_TextFilter.Name = "TB_TextFilter";
            this.TB_TextFilter.Size = new System.Drawing.Size(129, 35);
            this.TB_TextFilter.TabIndex = 11;
            this.TB_TextFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_TextFilter_KeyDown);
            this.TB_TextFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_TextFilter_KeyPress);
            // 
            // PB_Search
            // 
            this.PB_Search.BackColor = System.Drawing.Color.DimGray;
            this.PB_Search.Image = ((System.Drawing.Image)(resources.GetObject("PB_Search.Image")));
            this.PB_Search.Location = new System.Drawing.Point(386, 37);
            this.PB_Search.Name = "PB_Search";
            this.PB_Search.Size = new System.Drawing.Size(41, 36);
            this.PB_Search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Search.TabIndex = 8;
            this.PB_Search.TabStop = false;
            this.PB_Search.Click += new System.EventHandler(this.PB_Search_Click);
            // 
            // GB_Filter
            // 
            this.GB_Filter.Controls.Add(this.label1);
            this.GB_Filter.Controls.Add(this.PB_Search);
            this.GB_Filter.Controls.Add(this.TB_TextFilter);
            this.GB_Filter.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.GB_Filter.Location = new System.Drawing.Point(0, 3);
            this.GB_Filter.Name = "GB_Filter";
            this.GB_Filter.Size = new System.Drawing.Size(474, 99);
            this.GB_Filter.TabIndex = 12;
            this.GB_Filter.TabStop = false;
            this.GB_Filter.Text = "Filter";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 28);
            this.label1.TabIndex = 13;
            this.label1.Text = "License ID:";
            // 
            // LDLC_LicenseInfo
            // 
            this.LDLC_LicenseInfo.BackColor = System.Drawing.Color.DimGray;
            this.LDLC_LicenseInfo.Location = new System.Drawing.Point(0, 124);
            this.LDLC_LicenseInfo.Name = "LDLC_LicenseInfo";
            this.LDLC_LicenseInfo.Size = new System.Drawing.Size(1100, 521);
            this.LDLC_LicenseInfo.TabIndex = 0;
            // 
            // LocalDrivingLicenseCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.GB_Filter);
            this.Controls.Add(this.LDLC_LicenseInfo);
            this.Name = "LocalDrivingLicenseCardWithFilter";
            this.Size = new System.Drawing.Size(1099, 646);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Search)).EndInit();
            this.GB_Filter.ResumeLayout(false);
            this.GB_Filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private LocalDrivingLicenseCard LDLC_LicenseInfo;
        private System.Windows.Forms.TextBox TB_TextFilter;
        private System.Windows.Forms.PictureBox PB_Search;
        private System.Windows.Forms.GroupBox GB_Filter;
        private System.Windows.Forms.Label label1;
    }
}

namespace DVLD___System.Applications.Local_Driving_License
{
    partial class ShowLocalDrivingApplication_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowLocalDrivingApplication_Page));
            this.ctr_LocalApplicationInfo = new DVLD___System.Applications.Local_Driving_License.Control.ctrApplicationInfo();
            this.L_PageTitle = new System.Windows.Forms.Label();
            this.BT_Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctr_LocalApplicationInfo
            // 
            this.ctr_LocalApplicationInfo.Location = new System.Drawing.Point(38, 105);
            this.ctr_LocalApplicationInfo.Name = "ctr_LocalApplicationInfo";
            this.ctr_LocalApplicationInfo.Size = new System.Drawing.Size(976, 557);
            this.ctr_LocalApplicationInfo.TabIndex = 0;
            // 
            // L_PageTitle
            // 
            this.L_PageTitle.AutoSize = true;
            this.L_PageTitle.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_PageTitle.ForeColor = System.Drawing.Color.MediumBlue;
            this.L_PageTitle.Location = new System.Drawing.Point(180, 19);
            this.L_PageTitle.Name = "L_PageTitle";
            this.L_PageTitle.Size = new System.Drawing.Size(644, 51);
            this.L_PageTitle.TabIndex = 7;
            this.L_PageTitle.Text = "Local Driving License Application";
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Close.Image = ((System.Drawing.Image)(resources.GetObject("BT_Close.Image")));
            this.BT_Close.Location = new System.Drawing.Point(881, 659);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(124, 37);
            this.BT_Close.TabIndex = 22;
            this.BT_Close.Text = "Close";
            this.BT_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // ShowLocalDrivingApplication_Page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1036, 719);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.L_PageTitle);
            this.Controls.Add(this.ctr_LocalApplicationInfo);
            this.Name = "ShowLocalDrivingApplication_Page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShowLocalDrivingApplication_Page";
            this.Load += new System.EventHandler(this.ShowLocalDrivingApplication_Page_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.ctrApplicationInfo ctr_LocalApplicationInfo;
        private System.Windows.Forms.Label L_PageTitle;
        private System.Windows.Forms.Button BT_Close;
    }
}
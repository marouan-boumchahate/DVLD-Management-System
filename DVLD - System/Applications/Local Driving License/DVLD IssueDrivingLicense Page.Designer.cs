namespace DVLD___System.Driving_License.Local
{
    partial class IssueDrivingLicense_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IssueDrivingLicense_Form));
            this.DLAC_DrivingLicenseApplication = new DVLD___System.Driving_License.Tests.DrivingLicenseApplicationCard();
            this.L_Title = new System.Windows.Forms.Label();
            this.PB_Title = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.RTB_Notes = new System.Windows.Forms.RichTextBox();
            this.BT_Issue = new System.Windows.Forms.Button();
            this.BT_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Title)).BeginInit();
            this.SuspendLayout();
            // 
            // DLAC_DrivingLicenseApplication
            // 
            this.DLAC_DrivingLicenseApplication.BackColor = System.Drawing.Color.Silver;
            this.DLAC_DrivingLicenseApplication.Location = new System.Drawing.Point(12, 206);
            this.DLAC_DrivingLicenseApplication.Name = "DLAC_DrivingLicenseApplication";
            this.DLAC_DrivingLicenseApplication.Size = new System.Drawing.Size(1003, 531);
            this.DLAC_DrivingLicenseApplication.TabIndex = 1;
            // 
            // L_Title
            // 
            this.L_Title.AutoSize = true;
            this.L_Title.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Title.ForeColor = System.Drawing.Color.MediumBlue;
            this.L_Title.Location = new System.Drawing.Point(348, 138);
            this.L_Title.Name = "L_Title";
            this.L_Title.Size = new System.Drawing.Size(299, 36);
            this.L_Title.TabIndex = 27;
            this.L_Title.Text = "Issue Driving License";
            // 
            // PB_Title
            // 
            this.PB_Title.Image = ((System.Drawing.Image)(resources.GetObject("PB_Title.Image")));
            this.PB_Title.Location = new System.Drawing.Point(434, 21);
            this.PB_Title.Name = "PB_Title";
            this.PB_Title.Size = new System.Drawing.Size(150, 114);
            this.PB_Title.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_Title.TabIndex = 26;
            this.PB_Title.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 754);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 32);
            this.label3.TabIndex = 28;
            this.label3.Text = "Note: ";
            // 
            // RTB_Notes
            // 
            this.RTB_Notes.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.RTB_Notes.Location = new System.Drawing.Point(102, 754);
            this.RTB_Notes.Name = "RTB_Notes";
            this.RTB_Notes.Size = new System.Drawing.Size(913, 125);
            this.RTB_Notes.TabIndex = 29;
            this.RTB_Notes.Text = "";
            // 
            // BT_Issue
            // 
            this.BT_Issue.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Issue.Image = ((System.Drawing.Image)(resources.GetObject("BT_Issue.Image")));
            this.BT_Issue.Location = new System.Drawing.Point(894, 887);
            this.BT_Issue.Name = "BT_Issue";
            this.BT_Issue.Size = new System.Drawing.Size(121, 46);
            this.BT_Issue.TabIndex = 30;
            this.BT_Issue.Text = "Issue";
            this.BT_Issue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Issue.UseVisualStyleBackColor = true;
            this.BT_Issue.Click += new System.EventHandler(this.BT_Issue_Click);
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Close.Image = ((System.Drawing.Image)(resources.GetObject("BT_Close.Image")));
            this.BT_Close.Location = new System.Drawing.Point(767, 887);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(121, 46);
            this.BT_Close.TabIndex = 30;
            this.BT_Close.Text = "Close";
            this.BT_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // IssueDrivingLicense_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1034, 974);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.BT_Issue);
            this.Controls.Add(this.RTB_Notes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.L_Title);
            this.Controls.Add(this.PB_Title);
            this.Controls.Add(this.DLAC_DrivingLicenseApplication);
            this.Name = "IssueDrivingLicense_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Issue Driving License";
            ((System.ComponentModel.ISupportInitialize)(this.PB_Title)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Tests.DrivingLicenseApplicationCard DLAC_DrivingLicenseApplication;
        private System.Windows.Forms.Label L_Title;
        private System.Windows.Forms.PictureBox PB_Title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox RTB_Notes;
        private System.Windows.Forms.Button BT_Issue;
        private System.Windows.Forms.Button BT_Close;
    }
}
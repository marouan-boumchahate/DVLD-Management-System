namespace DVLD___System
{
    partial class UserCard
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.CKB_isActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.L_Username = new System.Windows.Forms.Label();
            this.L_UserID = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PI_CardDetails = new DVLD___System.PersonInfo();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.CKB_isActive);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.L_Username);
            this.panel1.Controls.Add(this.L_UserID);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 518);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1012, 86);
            this.panel1.TabIndex = 1;
            // 
            // CKB_isActive
            // 
            this.CKB_isActive.AutoSize = true;
            this.CKB_isActive.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CKB_isActive.Location = new System.Drawing.Point(844, 33);
            this.CKB_isActive.Name = "CKB_isActive";
            this.CKB_isActive.Size = new System.Drawing.Size(117, 32);
            this.CKB_isActive.TabIndex = 1;
            this.CKB_isActive.Text = "isActive";
            this.CKB_isActive.UseVisualStyleBackColor = true;
            this.CKB_isActive.CheckedChanged += new System.EventHandler(this.CKB_isActive_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(405, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username:";
            // 
            // L_Username
            // 
            this.L_Username.AutoSize = true;
            this.L_Username.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Username.Location = new System.Drawing.Point(531, 37);
            this.L_Username.Name = "L_Username";
            this.L_Username.Size = new System.Drawing.Size(52, 28);
            this.L_Username.TabIndex = 0;
            this.L_Username.Text = "N/A";
            // 
            // L_UserID
            // 
            this.L_UserID.AutoSize = true;
            this.L_UserID.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_UserID.Location = new System.Drawing.Point(147, 37);
            this.L_UserID.Name = "L_UserID";
            this.L_UserID.Size = new System.Drawing.Size(52, 28);
            this.L_UserID.TabIndex = 0;
            this.L_UserID.Text = "N/A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "User ID:";
            // 
            // PI_CardDetails
            // 
            this.PI_CardDetails.BackColor = System.Drawing.Color.DarkGray;
            this.PI_CardDetails.Location = new System.Drawing.Point(0, 3);
            this.PI_CardDetails.Name = "PI_CardDetails";
            this.PI_CardDetails.Size = new System.Drawing.Size(1012, 509);
            this.PI_CardDetails.TabIndex = 2;
            // 
            // UserCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PI_CardDetails);
            this.Controls.Add(this.panel1);
            this.Name = "UserCard";
            this.Size = new System.Drawing.Size(1016, 609);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox CKB_isActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label L_Username;
        private System.Windows.Forms.Label L_UserID;
        private System.Windows.Forms.Label label1;
        private PersonInfo PI_CardDetails;
    }
}

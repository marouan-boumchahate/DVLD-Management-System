namespace DVLD___System
{
    partial class ChangePassword_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangePassword_Form));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.TB_ReNewPass = new System.Windows.Forms.TextBox();
            this.TB_NewPass = new System.Windows.Forms.TextBox();
            this.TB_CurrentPass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.EP_PasswordsError = new System.Windows.Forms.ErrorProvider(this.components);
            this.UC_UserCardInfo = new DVLD___System.UserCard();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_PasswordsError)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BT_Save);
            this.groupBox1.Controls.Add(this.TB_ReNewPass);
            this.groupBox1.Controls.Add(this.TB_NewPass);
            this.groupBox1.Controls.Add(this.TB_CurrentPass);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(129, 779);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 259);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Password";
            // 
            // BT_Save
            // 
            this.BT_Save.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Save.ForeColor = System.Drawing.Color.Black;
            this.BT_Save.Image = ((System.Drawing.Image)(resources.GetObject("BT_Save.Image")));
            this.BT_Save.Location = new System.Drawing.Point(478, 207);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(121, 46);
            this.BT_Save.TabIndex = 16;
            this.BT_Save.Text = "Save";
            this.BT_Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // TB_ReNewPass
            // 
            this.TB_ReNewPass.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ReNewPass.Location = new System.Drawing.Point(287, 152);
            this.TB_ReNewPass.Name = "TB_ReNewPass";
            this.TB_ReNewPass.Size = new System.Drawing.Size(312, 35);
            this.TB_ReNewPass.TabIndex = 1;
            this.TB_ReNewPass.Validating += new System.ComponentModel.CancelEventHandler(this.TB_ReNewPass_Validating);
            // 
            // TB_NewPass
            // 
            this.TB_NewPass.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_NewPass.Location = new System.Drawing.Point(287, 103);
            this.TB_NewPass.Name = "TB_NewPass";
            this.TB_NewPass.Size = new System.Drawing.Size(312, 35);
            this.TB_NewPass.TabIndex = 1;
            this.TB_NewPass.Validating += new System.ComponentModel.CancelEventHandler(this.TB_NewPass_Validating);
            // 
            // TB_CurrentPass
            // 
            this.TB_CurrentPass.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_CurrentPass.Location = new System.Drawing.Point(287, 47);
            this.TB_CurrentPass.Name = "TB_CurrentPass";
            this.TB_CurrentPass.Size = new System.Drawing.Size(312, 35);
            this.TB_CurrentPass.TabIndex = 1;
            this.TB_CurrentPass.Validating += new System.ComponentModel.CancelEventHandler(this.TB_CurrentPass_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(33, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 28);
            this.label3.TabIndex = 0;
            this.label3.Text = "Re-New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(33, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(164, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(33, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Current Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(474, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(407, 46);
            this.label4.TabIndex = 4;
            this.label4.Text = "Change User Password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 102);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // EP_PasswordsError
            // 
            this.EP_PasswordsError.ContainerControl = this;
            // 
            // UC_UserCardInfo
            // 
            this.UC_UserCardInfo.Location = new System.Drawing.Point(129, 140);
            this.UC_UserCardInfo.Name = "UC_UserCardInfo";
            this.UC_UserCardInfo.Size = new System.Drawing.Size(1041, 633);
            this.UC_UserCardInfo.TabIndex = 0;
            // 
            // ChangePassword_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1274, 1050);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.UC_UserCardInfo);
            this.Name = "ChangePassword_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password";
            this.Load += new System.EventHandler(this.ChangePassword_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_PasswordsError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserCard UC_UserCardInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TB_ReNewPass;
        private System.Windows.Forms.TextBox TB_NewPass;
        private System.Windows.Forms.TextBox TB_CurrentPass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.ErrorProvider EP_PasswordsError;
    }
}
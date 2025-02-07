namespace DVLD___System.Global
{
    partial class VerifyCode_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VerifyCode_Form));
            this.Digit_1 = new System.Windows.Forms.TextBox();
            this.Digit_2 = new System.Windows.Forms.TextBox();
            this.Digit_3 = new System.Windows.Forms.TextBox();
            this.Digit_4 = new System.Windows.Forms.TextBox();
            this.Digit_5 = new System.Windows.Forms.TextBox();
            this.Digit_6 = new System.Windows.Forms.TextBox();
            this.TB_Title = new System.Windows.Forms.Label();
            this.BT_Verify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Digit_1
            // 
            this.Digit_1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Digit_1.Location = new System.Drawing.Point(59, 118);
            this.Digit_1.MaxLength = 1;
            this.Digit_1.Name = "Digit_1";
            this.Digit_1.Size = new System.Drawing.Size(37, 35);
            this.Digit_1.TabIndex = 1;
            this.Digit_1.Click += new System.EventHandler(this.Digit_Click);
            this.Digit_1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Digit_keyDown);
            // 
            // Digit_2
            // 
            this.Digit_2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Digit_2.Location = new System.Drawing.Point(129, 118);
            this.Digit_2.MaxLength = 1;
            this.Digit_2.Name = "Digit_2";
            this.Digit_2.Size = new System.Drawing.Size(37, 35);
            this.Digit_2.TabIndex = 2;
            this.Digit_2.Click += new System.EventHandler(this.Digit_Click);
            this.Digit_2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Digit_keyDown);
            // 
            // Digit_3
            // 
            this.Digit_3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Digit_3.Location = new System.Drawing.Point(199, 118);
            this.Digit_3.MaxLength = 1;
            this.Digit_3.Name = "Digit_3";
            this.Digit_3.Size = new System.Drawing.Size(37, 35);
            this.Digit_3.TabIndex = 3;
            this.Digit_3.Click += new System.EventHandler(this.Digit_Click);
            this.Digit_3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Digit_keyDown);
            // 
            // Digit_4
            // 
            this.Digit_4.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Digit_4.Location = new System.Drawing.Point(269, 118);
            this.Digit_4.MaxLength = 1;
            this.Digit_4.Name = "Digit_4";
            this.Digit_4.Size = new System.Drawing.Size(37, 35);
            this.Digit_4.TabIndex = 4;
            this.Digit_4.Click += new System.EventHandler(this.Digit_Click);
            this.Digit_4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Digit_keyDown);
            // 
            // Digit_5
            // 
            this.Digit_5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Digit_5.Location = new System.Drawing.Point(339, 118);
            this.Digit_5.MaxLength = 1;
            this.Digit_5.Name = "Digit_5";
            this.Digit_5.Size = new System.Drawing.Size(37, 35);
            this.Digit_5.TabIndex = 5;
            this.Digit_5.Click += new System.EventHandler(this.Digit_Click);
            this.Digit_5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Digit_keyDown);
            // 
            // Digit_6
            // 
            this.Digit_6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.Digit_6.Location = new System.Drawing.Point(409, 118);
            this.Digit_6.MaxLength = 1;
            this.Digit_6.Name = "Digit_6";
            this.Digit_6.Size = new System.Drawing.Size(37, 35);
            this.Digit_6.TabIndex = 6;
            this.Digit_6.Click += new System.EventHandler(this.Digit_Click);
            this.Digit_6.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Digit_keyDown);
            // 
            // TB_Title
            // 
            this.TB_Title.AutoSize = true;
            this.TB_Title.Font = new System.Drawing.Font("Times New Roman", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Title.ForeColor = System.Drawing.Color.Gold;
            this.TB_Title.Location = new System.Drawing.Point(105, 27);
            this.TB_Title.Name = "TB_Title";
            this.TB_Title.Size = new System.Drawing.Size(103, 51);
            this.TB_Title.TabIndex = 7;
            this.TB_Title.Text = "Title";
            // 
            // BT_Verify
            // 
            this.BT_Verify.BackColor = System.Drawing.Color.DarkGray;
            this.BT_Verify.Enabled = false;
            this.BT_Verify.Font = new System.Drawing.Font("Times New Roman", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Verify.Image = ((System.Drawing.Image)(resources.GetObject("BT_Verify.Image")));
            this.BT_Verify.Location = new System.Drawing.Point(321, 194);
            this.BT_Verify.Name = "BT_Verify";
            this.BT_Verify.Size = new System.Drawing.Size(125, 41);
            this.BT_Verify.TabIndex = 24;
            this.BT_Verify.Text = "Verify";
            this.BT_Verify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Verify.UseVisualStyleBackColor = false;
            this.BT_Verify.Click += new System.EventHandler(this.BT_Verify_Click);
            // 
            // VerifyCode_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(511, 271);
            this.Controls.Add(this.BT_Verify);
            this.Controls.Add(this.TB_Title);
            this.Controls.Add(this.Digit_6);
            this.Controls.Add(this.Digit_5);
            this.Controls.Add(this.Digit_4);
            this.Controls.Add(this.Digit_3);
            this.Controls.Add(this.Digit_2);
            this.Controls.Add(this.Digit_1);
            this.Name = "VerifyCode_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verification Code";
            this.Load += new System.EventHandler(this.VerifyCode_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Digit_1;
        private System.Windows.Forms.TextBox Digit_2;
        private System.Windows.Forms.TextBox Digit_3;
        private System.Windows.Forms.TextBox Digit_4;
        private System.Windows.Forms.TextBox Digit_5;
        private System.Windows.Forms.TextBox Digit_6;
        private System.Windows.Forms.Label TB_Title;
        private System.Windows.Forms.Button BT_Verify;
    }
}
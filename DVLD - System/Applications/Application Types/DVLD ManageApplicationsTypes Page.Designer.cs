namespace DVLD___System.Applications
{
    partial class ManageApplicationsTypes_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageApplicationsTypes_Form));
            this.l_RecordsLength = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_ApplicationTypesData = new System.Windows.Forms.DataGridView();
            this.CMS_ManageAppTypesShortcuts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Close = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ApplicationTypesData)).BeginInit();
            this.CMS_ManageAppTypesShortcuts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // l_RecordsLength
            // 
            this.l_RecordsLength.AutoSize = true;
            this.l_RecordsLength.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.l_RecordsLength.Location = new System.Drawing.Point(167, 583);
            this.l_RecordsLength.Name = "l_RecordsLength";
            this.l_RecordsLength.Size = new System.Drawing.Size(28, 32);
            this.l_RecordsLength.TabIndex = 10;
            this.l_RecordsLength.Text = "3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 583);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 9;
            this.label2.Text = "# Records: ";
            // 
            // DGV_ApplicationTypesData
            // 
            this.DGV_ApplicationTypesData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_ApplicationTypesData.ContextMenuStrip = this.CMS_ManageAppTypesShortcuts;
            this.DGV_ApplicationTypesData.Location = new System.Drawing.Point(24, 224);
            this.DGV_ApplicationTypesData.Name = "DGV_ApplicationTypesData";
            this.DGV_ApplicationTypesData.RowHeadersWidth = 62;
            this.DGV_ApplicationTypesData.RowTemplate.Height = 28;
            this.DGV_ApplicationTypesData.Size = new System.Drawing.Size(920, 344);
            this.DGV_ApplicationTypesData.TabIndex = 8;
            // 
            // CMS_ManageAppTypesShortcuts
            // 
            this.CMS_ManageAppTypesShortcuts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMS_ManageAppTypesShortcuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem});
            this.CMS_ManageAppTypesShortcuts.Name = "CMS_ManagePeopleShortcuts";
            this.CMS_ManageAppTypesShortcuts.Size = new System.Drawing.Size(293, 69);
            this.CMS_ManageAppTypesShortcuts.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_ManageAppTypesShortcuts_Opening);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(292, 32);
            this.editToolStripMenuItem.Text = "Edit The Application Type";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(276, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(376, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manage Applications Types";
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Close.Image = ((System.Drawing.Image)(resources.GetObject("BT_Close.Image")));
            this.BT_Close.Location = new System.Drawing.Point(823, 574);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(121, 46);
            this.BT_Close.TabIndex = 11;
            this.BT_Close.Text = "Close";
            this.BT_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(389, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // ManageApplicationsTypes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1047, 659);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.l_RecordsLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_ApplicationTypesData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageApplicationsTypes_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Applications Types";
            this.Load += new System.EventHandler(this.ManageApplicationsTypes_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_ApplicationTypesData)).EndInit();
            this.CMS_ManageAppTypesShortcuts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Label l_RecordsLength;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_ApplicationTypesData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip CMS_ManageAppTypesShortcuts;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}
namespace DVLD___System.Users
{
    partial class ManageUsers_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageUsers_Form));
            this.CB_ActivityType = new System.Windows.Forms.ComboBox();
            this.TB_TextFilter = new System.Windows.Forms.TextBox();
            this.CB_FindPersonBy = new System.Windows.Forms.ComboBox();
            this.BT_Close = new System.Windows.Forms.Button();
            this.l_RecordsLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DGV_UsersData = new System.Windows.Forms.DataGridView();
            this.CMS_ManageUsersShortcuts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.PB_AddNewPerson = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UsersData)).BeginInit();
            this.CMS_ManageUsersShortcuts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_AddNewPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CB_ActivityType
            // 
            this.CB_ActivityType.BackColor = System.Drawing.Color.DimGray;
            this.CB_ActivityType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_ActivityType.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CB_ActivityType.FormattingEnabled = true;
            this.CB_ActivityType.Items.AddRange(new object[] {
            "All",
            "Yes",
            "No"});
            this.CB_ActivityType.Location = new System.Drawing.Point(431, 199);
            this.CB_ActivityType.Name = "CB_ActivityType";
            this.CB_ActivityType.Size = new System.Drawing.Size(140, 36);
            this.CB_ActivityType.TabIndex = 20;
            this.CB_ActivityType.Visible = false;
            this.CB_ActivityType.SelectedIndexChanged += new System.EventHandler(this.CB_ActivityType_SelectedIndexChanged);
            // 
            // TB_TextFilter
            // 
            this.TB_TextFilter.BackColor = System.Drawing.Color.DimGray;
            this.TB_TextFilter.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TB_TextFilter.Location = new System.Drawing.Point(431, 200);
            this.TB_TextFilter.Name = "TB_TextFilter";
            this.TB_TextFilter.Size = new System.Drawing.Size(216, 35);
            this.TB_TextFilter.TabIndex = 19;
            this.TB_TextFilter.Visible = false;
            this.TB_TextFilter.TextChanged += new System.EventHandler(this.TB_TextFilter_TextChanged);
            this.TB_TextFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_TextFilter_KeyPress);
            // 
            // CB_FindPersonBy
            // 
            this.CB_FindPersonBy.BackColor = System.Drawing.Color.DimGray;
            this.CB_FindPersonBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FindPersonBy.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_FindPersonBy.FormattingEnabled = true;
            this.CB_FindPersonBy.Items.AddRange(new object[] {
            "None",
            "PersonID",
            "UserID",
            "UserName",
            "isActive"});
            this.CB_FindPersonBy.Location = new System.Drawing.Point(159, 200);
            this.CB_FindPersonBy.Name = "CB_FindPersonBy";
            this.CB_FindPersonBy.Size = new System.Drawing.Size(252, 36);
            this.CB_FindPersonBy.TabIndex = 18;
            this.CB_FindPersonBy.SelectedIndexChanged += new System.EventHandler(this.CB_FindPersonBy_SelectedIndexChanged);
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Close.Image = ((System.Drawing.Image)(resources.GetObject("BT_Close.Image")));
            this.BT_Close.Location = new System.Drawing.Point(1140, 592);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(121, 46);
            this.BT_Close.TabIndex = 17;
            this.BT_Close.Text = "Close";
            this.BT_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.TextChanged += new System.EventHandler(this.BT_Close_Click);
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // l_RecordsLength
            // 
            this.l_RecordsLength.AutoSize = true;
            this.l_RecordsLength.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.l_RecordsLength.Location = new System.Drawing.Point(177, 602);
            this.l_RecordsLength.Name = "l_RecordsLength";
            this.l_RecordsLength.Size = new System.Drawing.Size(28, 32);
            this.l_RecordsLength.TabIndex = 16;
            this.l_RecordsLength.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 14;
            this.label3.Text = "Find By: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 602);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 15;
            this.label2.Text = "# Records: ";
            // 
            // DGV_UsersData
            // 
            this.DGV_UsersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_UsersData.ContextMenuStrip = this.CMS_ManageUsersShortcuts;
            this.DGV_UsersData.Location = new System.Drawing.Point(36, 264);
            this.DGV_UsersData.Name = "DGV_UsersData";
            this.DGV_UsersData.RowHeadersWidth = 62;
            this.DGV_UsersData.RowTemplate.Height = 28;
            this.DGV_UsersData.Size = new System.Drawing.Size(1227, 322);
            this.DGV_UsersData.TabIndex = 13;
            // 
            // CMS_ManageUsersShortcuts
            // 
            this.CMS_ManageUsersShortcuts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMS_ManageUsersShortcuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.CMS_ManageUsersShortcuts.Name = "CMS_ManagePeopleShortcuts";
            this.CMS_ManageUsersShortcuts.Size = new System.Drawing.Size(249, 261);
            this.CMS_ManageUsersShortcuts.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_ManageUsersShortcuts_Opening);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showToolStripMenuItem.Image")));
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.showToolStripMenuItem.Text = "Show Details";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click_1);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewPersonToolStripMenuItem.Image")));
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.addNewPersonToolStripMenuItem.Text = "Add New User";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click_1);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click_1);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("changePasswordToolStripMenuItem.Image")));
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.changePasswordToolStripMenuItem.Text = "Change Password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click_1);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneCallToolStripMenuItem.Image")));
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(248, 32);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(527, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 36);
            this.label1.TabIndex = 12;
            this.label1.Text = "Manage Users";
            // 
            // PB_AddNewPerson
            // 
            this.PB_AddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("PB_AddNewPerson.Image")));
            this.PB_AddNewPerson.Location = new System.Drawing.Point(1188, 173);
            this.PB_AddNewPerson.Name = "PB_AddNewPerson";
            this.PB_AddNewPerson.Size = new System.Drawing.Size(75, 85);
            this.PB_AddNewPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_AddNewPerson.TabIndex = 10;
            this.PB_AddNewPerson.TabStop = false;
            this.PB_AddNewPerson.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(556, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ManageUsers_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1292, 658);
            this.Controls.Add(this.CB_ActivityType);
            this.Controls.Add(this.TB_TextFilter);
            this.Controls.Add(this.CB_FindPersonBy);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.l_RecordsLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_UsersData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_AddNewPerson);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManageUsers_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_UsersData)).EndInit();
            this.CMS_ManageUsersShortcuts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_AddNewPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CB_ActivityType;
        private System.Windows.Forms.TextBox TB_TextFilter;
        private System.Windows.Forms.ComboBox CB_FindPersonBy;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Label l_RecordsLength;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DGV_UsersData;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PB_AddNewPerson;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip CMS_ManageUsersShortcuts;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
    }
}
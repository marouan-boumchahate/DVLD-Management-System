namespace DVLD___System
{
    partial class ManagePeople_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagePeople_Form));
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_PeopleData = new System.Windows.Forms.DataGridView();
            this.CMS_ManagePeopleShortcuts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPersonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.phoneCallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.l_RecordsLength = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.CB_FindPersonBy = new System.Windows.Forms.ComboBox();
            this.TB_TextFilter = new System.Windows.Forms.TextBox();
            this.BT_Close = new System.Windows.Forms.Button();
            this.PB_AddNewPerson = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.CB_GenderType = new System.Windows.Forms.ComboBox();
            this.DT_DateOfBirth = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PeopleData)).BeginInit();
            this.CMS_ManagePeopleShortcuts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_AddNewPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(521, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Manage People";
            // 
            // DGV_PeopleData
            // 
            this.DGV_PeopleData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PeopleData.ContextMenuStrip = this.CMS_ManagePeopleShortcuts;
            this.DGV_PeopleData.Location = new System.Drawing.Point(30, 266);
            this.DGV_PeopleData.Name = "DGV_PeopleData";
            this.DGV_PeopleData.RowHeadersWidth = 62;
            this.DGV_PeopleData.RowTemplate.Height = 28;
            this.DGV_PeopleData.Size = new System.Drawing.Size(1227, 322);
            this.DGV_PeopleData.TabIndex = 2;
            this.DGV_PeopleData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_PeopleData_CellContentClick);
            // 
            // CMS_ManagePeopleShortcuts
            // 
            this.CMS_ManagePeopleShortcuts.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.CMS_ManagePeopleShortcuts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.addNewPersonToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem,
            this.sendEmailToolStripMenuItem,
            this.phoneCallToolStripMenuItem});
            this.CMS_ManagePeopleShortcuts.Name = "CMS_ManagePeopleShortcuts";
            this.CMS_ManagePeopleShortcuts.Size = new System.Drawing.Size(225, 196);
            this.CMS_ManagePeopleShortcuts.Opening += new System.ComponentModel.CancelEventHandler(this.CMS_ManagePeopleShortcuts_Opening);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showToolStripMenuItem.Image")));
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.showToolStripMenuItem.Text = "Show Details";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // addNewPersonToolStripMenuItem
            // 
            this.addNewPersonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("addNewPersonToolStripMenuItem.Image")));
            this.addNewPersonToolStripMenuItem.Name = "addNewPersonToolStripMenuItem";
            this.addNewPersonToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.addNewPersonToolStripMenuItem.Text = "Add New Person";
            this.addNewPersonToolStripMenuItem.Click += new System.EventHandler(this.addNewPersonToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("editToolStripMenuItem.Image")));
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("deleteToolStripMenuItem.Image")));
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // sendEmailToolStripMenuItem
            // 
            this.sendEmailToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendEmailToolStripMenuItem.Image")));
            this.sendEmailToolStripMenuItem.Name = "sendEmailToolStripMenuItem";
            this.sendEmailToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.sendEmailToolStripMenuItem.Text = "Send Email";
            this.sendEmailToolStripMenuItem.Click += new System.EventHandler(this.sendEmailToolStripMenuItem_Click);
            // 
            // phoneCallToolStripMenuItem
            // 
            this.phoneCallToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("phoneCallToolStripMenuItem.Image")));
            this.phoneCallToolStripMenuItem.Name = "phoneCallToolStripMenuItem";
            this.phoneCallToolStripMenuItem.Size = new System.Drawing.Size(224, 32);
            this.phoneCallToolStripMenuItem.Text = "Phone Call";
            this.phoneCallToolStripMenuItem.Click += new System.EventHandler(this.phoneCallToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 604);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "# Records: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // l_RecordsLength
            // 
            this.l_RecordsLength.AutoSize = true;
            this.l_RecordsLength.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.l_RecordsLength.Location = new System.Drawing.Point(171, 604);
            this.l_RecordsLength.Name = "l_RecordsLength";
            this.l_RecordsLength.Size = new System.Drawing.Size(28, 32);
            this.l_RecordsLength.TabIndex = 4;
            this.l_RecordsLength.Text = "3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 3;
            this.label3.Text = "Find By: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
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
            "FirstName",
            "SecondName",
            "ThirdName",
            "LastName",
            "NationalNo",
            "Gendor",
            "Nationality",
            "DateOfBirth",
            "Email",
            "Phone"});
            this.CB_FindPersonBy.Location = new System.Drawing.Point(153, 202);
            this.CB_FindPersonBy.Name = "CB_FindPersonBy";
            this.CB_FindPersonBy.Size = new System.Drawing.Size(252, 36);
            this.CB_FindPersonBy.TabIndex = 6;
            this.CB_FindPersonBy.SelectedIndexChanged += new System.EventHandler(this.CB_FindPersonBy_SelectedIndexChanged);
            // 
            // TB_TextFilter
            // 
            this.TB_TextFilter.BackColor = System.Drawing.Color.DimGray;
            this.TB_TextFilter.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TB_TextFilter.Location = new System.Drawing.Point(425, 202);
            this.TB_TextFilter.Name = "TB_TextFilter";
            this.TB_TextFilter.Size = new System.Drawing.Size(216, 35);
            this.TB_TextFilter.TabIndex = 7;
            this.TB_TextFilter.Visible = false;
            this.TB_TextFilter.TextChanged += new System.EventHandler(this.TB_TextFilter_TextChanged);
            this.TB_TextFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_TextFilter_KeyPress);
            // 
            // BT_Close
            // 
            this.BT_Close.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Close.Image = ((System.Drawing.Image)(resources.GetObject("BT_Close.Image")));
            this.BT_Close.Location = new System.Drawing.Point(1134, 594);
            this.BT_Close.Name = "BT_Close";
            this.BT_Close.Size = new System.Drawing.Size(121, 46);
            this.BT_Close.TabIndex = 5;
            this.BT_Close.Text = "Close";
            this.BT_Close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BT_Close.UseVisualStyleBackColor = true;
            this.BT_Close.Click += new System.EventHandler(this.BT_Close_Click);
            // 
            // PB_AddNewPerson
            // 
            this.PB_AddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("PB_AddNewPerson.Image")));
            this.PB_AddNewPerson.Location = new System.Drawing.Point(1182, 175);
            this.PB_AddNewPerson.Name = "PB_AddNewPerson";
            this.PB_AddNewPerson.Size = new System.Drawing.Size(75, 85);
            this.PB_AddNewPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_AddNewPerson.TabIndex = 0;
            this.PB_AddNewPerson.TabStop = false;
            this.PB_AddNewPerson.Click += new System.EventHandler(this.PB_AddNewPerson_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(550, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(164, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // CB_GenderType
            // 
            this.CB_GenderType.BackColor = System.Drawing.Color.DimGray;
            this.CB_GenderType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_GenderType.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.CB_GenderType.FormattingEnabled = true;
            this.CB_GenderType.Items.AddRange(new object[] {
            "All",
            "Female",
            "Male"});
            this.CB_GenderType.Location = new System.Drawing.Point(425, 201);
            this.CB_GenderType.Name = "CB_GenderType";
            this.CB_GenderType.Size = new System.Drawing.Size(140, 36);
            this.CB_GenderType.TabIndex = 8;
            this.CB_GenderType.Visible = false;
            this.CB_GenderType.SelectedIndexChanged += new System.EventHandler(this.CB_GenderType_SelectedIndexChanged);
            // 
            // DT_DateOfBirth
            // 
            this.DT_DateOfBirth.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.DT_DateOfBirth.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DT_DateOfBirth.Location = new System.Drawing.Point(425, 201);
            this.DT_DateOfBirth.Name = "DT_DateOfBirth";
            this.DT_DateOfBirth.Size = new System.Drawing.Size(176, 35);
            this.DT_DateOfBirth.TabIndex = 9;
            this.DT_DateOfBirth.CloseUp += new System.EventHandler(this.DT_DateOfBirth_CloseUp);
            this.DT_DateOfBirth.ValueChanged += new System.EventHandler(this.DT_DateOfBirth_ValueChanged);
            // 
            // ManagePeople_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1296, 666);
            this.Controls.Add(this.DT_DateOfBirth);
            this.Controls.Add(this.CB_GenderType);
            this.Controls.Add(this.TB_TextFilter);
            this.Controls.Add(this.CB_FindPersonBy);
            this.Controls.Add(this.BT_Close);
            this.Controls.Add(this.l_RecordsLength);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DGV_PeopleData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PB_AddNewPerson);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ManagePeople_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage People";
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PeopleData)).EndInit();
            this.CMS_ManagePeopleShortcuts.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_AddNewPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_PeopleData;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label l_RecordsLength;
        private System.Windows.Forms.Button BT_Close;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CB_FindPersonBy;
        private System.Windows.Forms.PictureBox PB_AddNewPerson;
        private System.Windows.Forms.TextBox TB_TextFilter;
        private System.Windows.Forms.ContextMenuStrip CMS_ManagePeopleShortcuts;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPersonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendEmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem phoneCallToolStripMenuItem;
        private System.Windows.Forms.ComboBox CB_GenderType;
        private System.Windows.Forms.DateTimePicker DT_DateOfBirth;
    }
}
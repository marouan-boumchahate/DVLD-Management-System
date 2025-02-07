namespace DVLD___System.People
{
    partial class PersonCardWithFilter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonCardWithFilter));
            this.label2 = new System.Windows.Forms.Label();
            this.P_Filter = new System.Windows.Forms.Panel();
            this.TB_TextFilter = new System.Windows.Forms.TextBox();
            this.CB_FindPersonBy = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PB_SearchForEmployee = new System.Windows.Forms.PictureBox();
            this.PB_AddNewPerson = new System.Windows.Forms.PictureBox();
            this.EP_AddUserErrors = new System.Windows.Forms.ErrorProvider(this.components);
            this.PI_PersonData = new DVLD___System.PersonInfo();
            this.P_Filter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SearchForEmployee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_AddNewPerson)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_AddUserErrors)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(3, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 7;
            this.label2.Text = "Filter";
            // 
            // P_Filter
            // 
            this.P_Filter.BackColor = System.Drawing.Color.DarkGray;
            this.P_Filter.Controls.Add(this.TB_TextFilter);
            this.P_Filter.Controls.Add(this.CB_FindPersonBy);
            this.P_Filter.Controls.Add(this.label3);
            this.P_Filter.Controls.Add(this.PB_SearchForEmployee);
            this.P_Filter.Controls.Add(this.PB_AddNewPerson);
            this.P_Filter.Location = new System.Drawing.Point(8, 40);
            this.P_Filter.Name = "P_Filter";
            this.P_Filter.Size = new System.Drawing.Size(992, 100);
            this.P_Filter.TabIndex = 6;
            // 
            // TB_TextFilter
            // 
            this.TB_TextFilter.BackColor = System.Drawing.Color.DarkGray;
            this.TB_TextFilter.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.TB_TextFilter.Location = new System.Drawing.Point(426, 31);
            this.TB_TextFilter.Name = "TB_TextFilter";
            this.TB_TextFilter.Size = new System.Drawing.Size(230, 35);
            this.TB_TextFilter.TabIndex = 11;
            this.TB_TextFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_TextFilter_KeyDown);
            this.TB_TextFilter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_TextFilter_KeyPress);
            // 
            // CB_FindPersonBy
            // 
            this.CB_FindPersonBy.BackColor = System.Drawing.Color.DarkGray;
            this.CB_FindPersonBy.DisplayMember = "PersonID";
            this.CB_FindPersonBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_FindPersonBy.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_FindPersonBy.FormattingEnabled = true;
            this.CB_FindPersonBy.Items.AddRange(new object[] {
            "PersonID",
            "NationalNo"});
            this.CB_FindPersonBy.Location = new System.Drawing.Point(150, 31);
            this.CB_FindPersonBy.Name = "CB_FindPersonBy";
            this.CB_FindPersonBy.Size = new System.Drawing.Size(252, 36);
            this.CB_FindPersonBy.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 32);
            this.label3.TabIndex = 9;
            this.label3.Text = "Find By: ";
            // 
            // PB_SearchForEmployee
            // 
            this.PB_SearchForEmployee.Image = ((System.Drawing.Image)(resources.GetObject("PB_SearchForEmployee.Image")));
            this.PB_SearchForEmployee.Location = new System.Drawing.Point(693, 31);
            this.PB_SearchForEmployee.Name = "PB_SearchForEmployee";
            this.PB_SearchForEmployee.Size = new System.Drawing.Size(41, 36);
            this.PB_SearchForEmployee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_SearchForEmployee.TabIndex = 8;
            this.PB_SearchForEmployee.TabStop = false;
            this.PB_SearchForEmployee.Click += new System.EventHandler(this.PB_SearchForEmployee_Click);
            // 
            // PB_AddNewPerson
            // 
            this.PB_AddNewPerson.Image = ((System.Drawing.Image)(resources.GetObject("PB_AddNewPerson.Image")));
            this.PB_AddNewPerson.Location = new System.Drawing.Point(752, 31);
            this.PB_AddNewPerson.Name = "PB_AddNewPerson";
            this.PB_AddNewPerson.Size = new System.Drawing.Size(41, 36);
            this.PB_AddNewPerson.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PB_AddNewPerson.TabIndex = 8;
            this.PB_AddNewPerson.TabStop = false;
            this.PB_AddNewPerson.Click += new System.EventHandler(this.PB_AddNewPerson_Click);
            // 
            // EP_AddUserErrors
            // 
            this.EP_AddUserErrors.ContainerControl = this;
            // 
            // PI_PersonData
            // 
            this.PI_PersonData.BackColor = System.Drawing.Color.DarkGray;
            this.PI_PersonData.Font = new System.Drawing.Font("Times New Roman", 8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PI_PersonData.Location = new System.Drawing.Point(8, 148);
            this.PI_PersonData.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PI_PersonData.Name = "PI_PersonData";
            this.PI_PersonData.Size = new System.Drawing.Size(992, 549);
            this.PI_PersonData.TabIndex = 5;
            // 
            // PersonCardWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.P_Filter);
            this.Controls.Add(this.PI_PersonData);
            this.Name = "PersonCardWithFilter";
            this.Size = new System.Drawing.Size(1010, 722);
            this.P_Filter.ResumeLayout(false);
            this.P_Filter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_SearchForEmployee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_AddNewPerson)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EP_AddUserErrors)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel P_Filter;
        private System.Windows.Forms.TextBox TB_TextFilter;
        private System.Windows.Forms.ComboBox CB_FindPersonBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox PB_SearchForEmployee;
        private System.Windows.Forms.PictureBox PB_AddNewPerson;
        private PersonInfo PI_PersonData;
        private System.Windows.Forms.ErrorProvider EP_AddUserErrors;
    }
}

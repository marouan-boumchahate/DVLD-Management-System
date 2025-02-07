using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Applications
{
    public partial class UpdateApplicationType_Form : Form
    {
        int ID {  get; set; }
        public UpdateApplicationType_Form(int iD)
        {
            InitializeComponent();
            ID = iD;
        }

        private void TB_AppFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) return;
            if (e.KeyChar == '.' && TB_AppFee.Text.IndexOf('.') == -1) return;

            e.Handled = true;
        }

        Business_Layer.ApplicationType applicationType = new Business_Layer.ApplicationType();
        private void UpdateApplicationType_Form_Load(object sender, EventArgs e)
        {
            applicationType = Business_Layer.ApplicationType.FindApplicationByID(ID);

            L_AppID.Text = applicationType.ApplicationID.ToString();
            TB_AppTitle.Text = applicationType.ApplicationTitle.ToString();
            TB_AppFee.Text = applicationType.ApplicationFees.ToString();
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            double fee = Convert.ToDouble(TB_AppFee.Text);

            if (TB_AppTitle.Text != "" && TB_AppFee.Text != "" && fee>= 0)
            {
                applicationType.ApplicationFees = fee;
                applicationType.ApplicationTitle = TB_AppTitle.Text;

                if (applicationType.EditApplicationType()) MessageBox.Show("The Application Type updated successfuly.", "Successfuly Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Something Went Wrong during the update!!!!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Check The information that you changed (no negative fees!, Title must be filled!).", "Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

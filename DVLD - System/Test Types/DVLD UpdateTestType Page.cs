using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Test_Types
{
    public partial class UpdateTestType_Form : Form
    {
        int ID { get; set; }
        public UpdateTestType_Form(int iD)
        {
            InitializeComponent();
            ID = iD;
        }

        private void TB_TestFee_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)) return;
            if (e.KeyChar == '.' && TB_TestFee.Text.IndexOf('.') == -1) return;

            e.Handled = true;
        }

        Business_Layer.TestType testType = new Business_Layer.TestType();
        private void UpdateTestType_Form_Load(object sender, EventArgs e)
        {
            testType = Business_Layer.TestType.FindTestByID(ID);

            L_TestID.Text = testType.TestID.ToString();
            TB_TestTitle.Text = testType.TestTitle.ToString();
            RTB_TestDescription.Text = testType.TestDescription.ToString();
            TB_TestFee.Text = testType.TestFees.ToString();
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            double fee = Convert.ToDouble(TB_TestFee.Text);

            if (TB_TestTitle.Text != "" && RTB_TestDescription.Text != "" && TB_TestFee.Text != "" && fee >= 0)
            {
                testType.TestFees = fee;
                testType.TestTitle = TB_TestTitle.Text;
                testType.TestDescription = RTB_TestDescription.Text;

                if (testType.EditTestType()) MessageBox.Show("The Test Type updated successfuly.", "Successfuly Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("Something Went Wrong during the update!!!!", "Update Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Check The information that you changed (no negative fees!, Title and Description must be filled!).", "Incorrect Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

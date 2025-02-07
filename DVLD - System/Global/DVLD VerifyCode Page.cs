using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Global
{
    public partial class VerifyCode_Form : Form
    {
        List<TextBox> digits = new List<TextBox>();
        
        int DigitPos = 0;
        string realCode = string.Empty;

        public bool Verified = false;

        public VerifyCode_Form(string verificationFor, string Code)
        {
            InitializeComponent();
            TB_Title.Text = $"verify your {verificationFor}";
            realCode = Code;
        }

        private void VerifyCode_Form_Load(object sender, EventArgs e)
        {
            digits.Add(Digit_1);
            digits.Add(Digit_2);
            digits.Add(Digit_3);
            digits.Add(Digit_4);
            digits.Add(Digit_5);
            digits.Add(Digit_6);
        }
        

        private void Reach_End()
        {
            if (DigitPos == 5) BT_Verify.Enabled = true; // Open the verification button
            else digits[++DigitPos].Focus(); // Go to the next cell
        }
        private void remove_text()
        {
            BT_Verify.Enabled = false; // This because whenever we delete a cell that means they are not completed so we can prevent them from verifying the code


            if (DigitPos != 0 && string.IsNullOrEmpty(digits[DigitPos].Text)) DigitPos--; // go to the previous cell if the cell was empty during the delete key

            if(!string.IsNullOrEmpty(digits[DigitPos].Text)) digits[DigitPos].Text = string.Empty; // empty the cell if it was full

            digits[DigitPos].Focus();
        }
        
        private void Digit_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back) { remove_text(); return; } // Capture the delete key
            if (!char.IsDigit((char)e.KeyCode)) { e.Handled = true; return; } // allow only digits

            Reach_End(); // step to the next cell or detect the end of cells
        }



        private string get_written_code()
        {
            // This method will concatenate all the cells and come up with a code
            string code = string.Empty;

            foreach (TextBox txt in digits) code += txt.Text;

            return code;
        }
        private void reset_cells()
        {
            // Refresh the page by empty all cells and reset the position
            foreach (TextBox txt in digits) txt.Text = string.Empty;

            DigitPos = 0;
            digits[DigitPos].Focus();
        }

        private void BT_Verify_Click(object sender, EventArgs e)
        {
            string writtenCode = get_written_code();

            if (writtenCode == realCode)
            {
                MessageBox.Show("The verification has been done successfully", "Code Verified", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Verified = true;
                Close();
            }
            else
            {
                MessageBox.Show("The code you entered is NOT correct\n\nTry Again.", "Code Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reset_cells();
            }
        }


        private void Digit_Click(object sender, EventArgs e)
        {
            // This method will force the user to not use the mouse during writing the code
            digits[DigitPos].Focus();
        }
    }
}

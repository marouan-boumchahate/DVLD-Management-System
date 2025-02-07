using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System
{
    public partial class ChangePassword_Form : Form
    {
        private int UserID {  get; set; }
        private User user {  get; set; }

        public ChangePassword_Form()
        {
            InitializeComponent();
            UserID = Settings.Current_User.UserID;
        }
        public ChangePassword_Form(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }

        private void BT_Save_Click(object sender, EventArgs e)
        {
            if(!ValidateChildren())
            {
                MessageBox.Show("You must fill all requirements in the correct way.", "Requirements Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            user.Password = TB_ReNewPass.Text;
            if (user.save())
            {
                MessageBox.Show("Your new password has been saved successfuly.", "Password Changed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TB_CurrentPass.Text = ""; TB_NewPass.Text = ""; TB_ReNewPass.Text = "";
            }
            else MessageBox.Show("Something Went wrong during the password saving!!!!", "Password Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void ChangePassword_Form_Load(object sender, EventArgs e)
        {
            TB_CurrentPass.Focus();

            UC_UserCardInfo.LoadUserInfo(UserID);
            user = UC_UserCardInfo.GetUser_Object();
        }

        private void TB_CurrentPass_Validating(object sender, CancelEventArgs e)
        {
            if (TB_CurrentPass.Text != user.Password)
            {
                EP_PasswordsError.SetError(TB_CurrentPass, "Wrong Passwords");
                e.Cancel = true;
            }
            else
                EP_PasswordsError.SetError(TB_CurrentPass, null);
        }
        private void TB_NewPass_Validating(object sender, CancelEventArgs e)
        {
            if (TB_NewPass.Text == "")
            {
                EP_PasswordsError.SetError(TB_NewPass, "Must be field");
                e.Cancel = true;
            }
            else
                EP_PasswordsError.SetError(TB_NewPass, null);
        }
        private void TB_ReNewPass_Validating(object sender, CancelEventArgs e)
        {
            if (TB_NewPass.Text != TB_ReNewPass.Text)
            {
                EP_PasswordsError.SetError(TB_ReNewPass, "The re-new password doesn't match the new password");
                e.Cancel = true;
            }
            else
                EP_PasswordsError.SetError(TB_ReNewPass, null);
        }
    }
}

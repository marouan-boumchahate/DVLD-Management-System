using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Users
{
    public partial class AddEditUser_Form : Form
    {
        User user = new User();
        public AddEditUser_Form()
        {
            InitializeComponent();
        }

        public void ConvertToEditPage(int UserID)
        {
            user = User.FindUserByID(UserID);

            Text = "Update User";
            PB_PageIcon.Image = Properties.Resources.Edit;
            L_PageTitle.Text = "Update User Info";

            PCWF_PersonFilter.DisableFilter();

            TB_Password.Enabled = false;
            TB_ConfirmPassword.Enabled = false;

            BT_Save.Text = "Save";
            BT_Save.Image = Properties.Resources.Save_3;

            PCWF_PersonFilter.LoadPersonInfo(user.PersonInfo.PersonID);

            TB_Username.Text = user.UserName;
            TB_Password.Text = user.Password;
            TB_ConfirmPassword.Text = TB_Password.Text;
            L_UserID.Text = user.UserID.ToString();
            CKB_isActive.Checked = user.isActive;
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadNewUser_Data()
        {
            user.UserName = TB_Username.Text;
            user.Password = TB_Password.Text;
            user.isActive = CKB_isActive.Checked;
            user.PersonInfo = Person.FindPersonByID(PCWF_PersonFilter.GetPersonID());
        }
        private void BT_Save_Click(object sender, EventArgs e)
        {
            string PosBody = string.Empty, PosTitle = string.Empty;
            string NegBody = string.Empty, NegTitle = string.Empty;

            if (PCWF_PersonFilter.FilterState())
            {
                PosBody = "The user has been successfully added.";
                PosTitle = "User Addition Successful";

                NegBody = "Failed to add the user. Please try again.";
                NegTitle = "User Addition Failed";

                if (!ValidateChildren())
                {
                    MessageBox.Show("Please Fill All requirements First.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                LoadNewUser_Data();
            }
            else
            {
                PosBody = "The user has been successfully updated.";
                PosTitle = "User Update Successful";

                NegBody = "Failed to update the user. Please try again.";
                NegTitle = "User Update Failed";

                if(!string.IsNullOrEmpty(EP_AddUserErrors.GetError(TB_Username)))
                {
                    MessageBox.Show("Please check the username field.", "Username is incorrect", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if(TB_Username.Text == user.UserName && CKB_isActive.Checked == user.isActive)
                {
                    MessageBox.Show("You changed nothing to save.", "Misunderstanding", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                user.UserName = user.UserName.Trim();
                user.isActive = CKB_isActive.Checked;
            }

            if(user.save())
                MessageBox.Show(PosBody, PosTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(NegBody, NegTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);


            if (PCWF_PersonFilter.FilterState()) ConvertToEditPage(user.UserID);
        }

        private void BT_Next_Click(object sender, EventArgs e)
        {
            TC_AddUserTabs.SelectedIndex = 1;
        }

        private void TB_Username_Validating(object sender, CancelEventArgs e)
        {
            if (TB_Username.Text == "")
            {
                EP_AddUserErrors.SetError(TB_Username, "Must Be filled");
                e.Cancel = true;
            }
            else if (user.UserName != TB_Username.Text && User.isUserExist(TB_Username.Text))
            {
                EP_AddUserErrors.SetError(TB_Username, "This Username already exist");
                e.Cancel = true;
            }
            else
                EP_AddUserErrors.SetError(TB_Username, null);
        }
        private void TB_Password_Validating(object sender, CancelEventArgs e)
        {
            if (TB_Password.Text == "")
            {
                EP_AddUserErrors.SetError(TB_Password, "Must Be filled");
                e.Cancel = true;
            }
            else
                EP_AddUserErrors.SetError(TB_Password, null);
        }
        private void TB_ConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (TB_Password.Text != TB_ConfirmPassword.Text)
            {
                EP_AddUserErrors.SetError(TB_ConfirmPassword, "Passwords do NOT match");
                e.Cancel = true;
            }
            else
                EP_AddUserErrors.SetError(TB_ConfirmPassword, null);
        }

        private void TC_AddUserTabs_TabIndexChanged(object sender, EventArgs e)
        {
            if (TC_AddUserTabs.SelectedIndex == 0 || !PCWF_PersonFilter.FilterState()) return;


            if (PCWF_PersonFilter.GetPersonID() == -1)
                { TC_AddUserTabs.SelectedIndex = 0; MessageBox.Show("You must select a person first", "Missing a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);}
            else if (User.FindUserByPerson(PCWF_PersonFilter.GetPersonID()) != null)
                { TC_AddUserTabs.SelectedIndex = 0; MessageBox.Show("The Person you choosed already a user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
    }
}

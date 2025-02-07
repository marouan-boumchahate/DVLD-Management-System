using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD___System
{
    public partial class Login_Form : Form
    {
        string FilePath = @"C:\DVLD - login\rememberme.txt";
        public Login_Form()
        {
            InitializeComponent();
        }

        private void Login_Form_Load(object sender, EventArgs e)
        {
            string Data = "";

            try
            { Data = File.ReadAllText(FilePath); }
            catch { }

            if (Data != "")
            {
                string[] Logins = Data.Split(new string[] { "|#|" }, StringSplitOptions.None);
                TB_Username.Text = Logins[0];
                TB_Password.Text = Logins[1];

                CKB_RememberMe.Checked = true;
            }
        }
        private void SaveLogin_RememberMe(string DataLogin)
        {
            try
            { File.WriteAllText(FilePath, DataLogin); }
            catch { MessageBox.Show("We couldn't Remember your login info", "Saving Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }
        private void BT_SignIn_Click(object sender, EventArgs e)
        {
            Business_Layer.User user = Business_Layer.User.FindUserByUsername(TB_Username.Text);

            if (user == null)
            { MessageBox.Show("The Username is not correct", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if(!user.isActive)
            { MessageBox.Show("This user is not active", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if(user.Password != TB_Password.Text)
            { MessageBox.Show("The password is not correct", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            if (CKB_RememberMe.Checked)
            {
                string DataLogin = TB_Username.Text + "|#|" + TB_Password.Text;
                SaveLogin_RememberMe (DataLogin);
            }
            else
            {
                SaveLogin_RememberMe("");
                TB_Username.Text = TB_Password.Text = "";
            }

            Settings.Current_User = user;

            DVLD_Form dVLD_Form = new DVLD_Form();
            dVLD_Form.ShowDialog();
        }

        private void TB_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox tb = (TextBox)sender;

            if (tb.Text == "")
            {
                EP_LoginErrors.SetError(tb, "Must Be field");
                e.Cancel = true;
            }
            else EP_LoginErrors.SetError(tb, null);
        }
    }
}

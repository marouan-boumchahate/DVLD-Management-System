using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Users
{
    public partial class ShowUser_Form : Form
    {
        int UserID {  get; set; }
        public ShowUser_Form(int UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
        }
        public ShowUser_Form()
        {
            InitializeComponent();
            this.UserID = Settings.Current_User.UserID;
        }

        private void ShowUser_Form_Load(object sender, EventArgs e)
        {
            UC_UserDetails.LoadUserInfo(UserID);
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

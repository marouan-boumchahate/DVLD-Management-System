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
    public partial class UserCard : UserControl
    {
        public UserCard()
        {
            InitializeComponent();
        }

        private void initialData(ref User user)
        {
            L_UserID.Text = user.UserID.ToString();
            L_Username.Text = user.UserName.ToString();
            CKB_isActive.Checked = user.isActive;
        }

        User user;

        public void LoadUserInfo(int UserID)
        {
            user = User.FindUserByID(UserID);

            PI_CardDetails.LoadPersonInfo(user.PersonInfo.PersonID);
            initialData(ref user);
        }
        public User GetUser_Object()
        {
            return user;
        }
        private void CKB_isActive_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox cb = (CheckBox)sender;
            
            if(cb.Checked != user.isActive) cb.Checked = user.isActive;
        }
    }
}

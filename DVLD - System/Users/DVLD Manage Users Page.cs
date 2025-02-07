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
    public partial class ManageUsers_Form : Form
    {
        DataTable UsersRecords = new DataTable();
        bool startCB = false;
        public ManageUsers_Form()
        {
            InitializeComponent();

            CB_ActivityType.SelectedIndex = 0;
            CB_FindPersonBy.SelectedIndex = 0; startCB = true;

            LoadUsersData();
        }

        private void LoadUsersData()
        {
            UsersRecords = Business_Layer.User.FindAllUsers();
            DGV_UsersData.DataSource = UsersRecords;

            l_RecordsLength.Text = UsersRecords.Rows.Count.ToString();

            DGV_UsersData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void DevelopementMessage()
        {
            MessageBox.Show("Our Developers still working on this feature!!", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void CB_FindPersonBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!startCB) return;

            TB_TextFilter.Text = "";
            CB_ActivityType.Text = "All";

            if (CB_FindPersonBy.SelectedItem.ToString() == "None")
            {
                TB_TextFilter.Visible = false; CB_ActivityType.Visible = false;
                return;
            }

            if (CB_FindPersonBy.SelectedItem.ToString() == "isActive")
            {
                TB_TextFilter.Visible = false; CB_ActivityType.Visible = true;
                return;
            }


            TB_TextFilter.Visible = true; CB_ActivityType.Visible = false;
        }
        private void TB_TextFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CB_FindPersonBy.SelectedItem.ToString() == "PersonID" || CB_FindPersonBy.SelectedItem.ToString() == "UserID")
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        private string CreateQuery(ComboBox cb, TextBox tb)
        {
            if (tb.Text == "") return "";

            if ((cb.SelectedItem.ToString() == "PersonID") || (cb.SelectedItem.ToString() == "isActive") || (cb.SelectedItem.ToString() == "UserID"))
                return $"{cb.SelectedItem.ToString()} = {tb.Text}";

            return $"{cb.SelectedItem.ToString()} LIKE '{tb.Text}%'";
        }
        private void TB_TextFilter_TextChanged(object sender, EventArgs e)
        {
            DataView originalView = UsersRecords.DefaultView.ToTable().DefaultView;

            DataView filteredView = UsersRecords.DefaultView;
            filteredView.RowFilter = CreateQuery(CB_FindPersonBy, TB_TextFilter);
        }
        private void CB_ActivityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!startCB) return;
            if (CB_ActivityType.SelectedItem.ToString() == "All") TB_TextFilter.Text = "";
            else TB_TextFilter.Text = "'" + CB_ActivityType.SelectedItem.ToString() + "'";
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PB_AddNewUser_Click(object sender, EventArgs e)
        {
            AddPerson_Form addPerson_Form = new AddPerson_Form();
            addPerson_Form.ShowDialog();

            LoadUsersData();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(DGV_UsersData.CurrentRow.Cells["UserID"].Value);

            ShowPersonDetails_Form showDetails_Form = new ShowPersonDetails_Form(PersonID);
            showDetails_Form.ShowDialog();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevelopementMessage();
        }
        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DevelopementMessage();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(DGV_UsersData.CurrentRow.Cells["UserID"].Value);

            if (MessageBox.Show("This Person will be deleted forever!!!\nAre you sure??", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Business_Layer.Person.DeletePerson(PersonID))
                    MessageBox.Show("The Person has been deleted successfuly!!", "Deletion Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("The Person can't be deleted due to some background relation!!", "Deletion Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            UsersRecords = Business_Layer.Person.FindAllPeople();
            DGV_UsersData.DataSource = UsersRecords;
        }

        private void addNewPersonToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddEditUser_Form addEditUser_Form = new AddEditUser_Form();
            addEditUser_Form.ShowDialog();

            LoadUsersData();
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AddEditUser_Form addEditUser_Form = new AddEditUser_Form();

            int UserID = Convert.ToInt32(DGV_UsersData.CurrentRow.Cells["UserID"].Value);
            addEditUser_Form.ConvertToEditPage(UserID);

            addEditUser_Form.ShowDialog();

            LoadUsersData();
        }

        private void showToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(DGV_UsersData.CurrentRow.Cells["UserID"].Value);
            
            ShowUser_Form showUser_Form = new ShowUser_Form(UserID);
            showUser_Form.ShowDialog();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(DGV_UsersData.CurrentRow.Cells["UserID"].Value);

            ChangePassword_Form changePassword_Form = new ChangePassword_Form(userID);
            changePassword_Form.ShowDialog();
        }

        private void deleteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int UserID = Convert.ToInt32(DGV_UsersData.CurrentRow.Cells["UserID"].Value);

            if (MessageBox.Show("Are you sure you wanna delete this user??", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            if (Business_Layer.User.DeleteUser(UserID)) MessageBox.Show("The User has been deleted.", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else MessageBox.Show("Something Went Wrong!!", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error);
        
            LoadUsersData();
        }

        private void CMS_ManageUsersShortcuts_Opening(object sender, CancelEventArgs e)
        {
            if(DGV_UsersData.CurrentRow == null || DGV_UsersData.CurrentRow.IsNewRow)
                e.Cancel = true;
        }
    }
}

using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD___System
{
    public partial class ManagePeople_Form : Form
    {
        DataTable PeopleRecords = new DataTable();


        private void LoadPeopleData()
        {
            PeopleRecords = Business_Layer.Person.FindAllPeople();
            DGV_PeopleData.DataSource = PeopleRecords;

            l_RecordsLength.Text = PeopleRecords.Rows.Count.ToString();

            DGV_PeopleData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public ManagePeople_Form()
        {
            InitializeComponent();

            CB_FindPersonBy.SelectedIndex = 0;
            CB_GenderType.SelectedIndex = 0;

            LoadPeopleData();
        }

        private void DevelopementMessage()
        {
            MessageBox.Show("Our Developers still working on this feature!!", "Coming Soon", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void CB_FindPersonBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_TextFilter.Text = "";
            CB_GenderType.Text = "All";
            DT_DateOfBirth.Value = DT_DateOfBirth.MaxDate = DateTime.Today.AddYears(-18);

            if (CB_FindPersonBy.SelectedItem.ToString() == "None")
            {
                TB_TextFilter.Visible = false; CB_GenderType.Visible = false; DT_DateOfBirth.Visible = false;
                return;
            }

            if (CB_FindPersonBy.SelectedItem.ToString() == "Gendor")
            {
                TB_TextFilter.Visible = false; CB_GenderType.Visible = true; DT_DateOfBirth.Visible = false;
                return;
            }

            if (CB_FindPersonBy.SelectedItem.ToString() == "DateOfBirth")
            {
                TB_TextFilter.Visible = false; CB_GenderType.Visible = false; DT_DateOfBirth.Visible = true;
                return;
            }

            TB_TextFilter.Visible = true; CB_GenderType.Visible = false; DT_DateOfBirth.Visible = false;
        }
        private void TB_TextFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CB_FindPersonBy.SelectedItem.ToString() == "PersonID")
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

            if (CB_FindPersonBy.SelectedItem.ToString() == "Gendor")
                if (TB_TextFilter.Text.Length > 1 || !(e.KeyChar == '0' || e.KeyChar == '1' || char.IsControl(e.KeyChar))) e.Handled = true;
        }
        private string CreateQuery(ComboBox cb, TextBox tb)
        {
            if (tb.Text == "") return "";


            if ((cb.SelectedItem.ToString() == "PersonID") || (cb.SelectedItem.ToString() == "Gendor") || cb.SelectedItem.ToString() == "DateOfBirth")
                return $"{cb.SelectedItem.ToString()} = {tb.Text}";

            return $"{cb.SelectedItem.ToString()} LIKE '{tb.Text}%'";
        }
        private void TB_TextFilter_TextChanged(object sender, EventArgs e)
        {
            DataView originalView = PeopleRecords.DefaultView.ToTable().DefaultView;

            DataView filteredView = PeopleRecords.DefaultView;
            filteredView.RowFilter = CreateQuery(CB_FindPersonBy, TB_TextFilter);
        }
        private void CB_GenderType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (CB_GenderType.SelectedItem.ToString())
            {
                case "All":
                    TB_TextFilter.Text = "";
                    break;
                case "Female":
                    TB_TextFilter.Text = "0";
                    break;
                default:
                    TB_TextFilter.Text = "1";
                    break;
            }
        }

        private void DT_DateOfBirth_CloseUp(object sender, EventArgs e)
        {
            TB_TextFilter.Text = "'" + DT_DateOfBirth.Value.ToString("MM-dd-yyyy") + "'";

        }
        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PB_AddNewPerson_Click(object sender, EventArgs e)
        {
            AddPerson_Form addPerson_Form = new AddPerson_Form();
            addPerson_Form.ShowDialog();

            LoadPeopleData();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(DGV_PeopleData.CurrentRow.Cells["PersonID"].Value);

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
            int PersonID = Convert.ToInt32(DGV_PeopleData.CurrentRow.Cells["PersonID"].Value);

            if (MessageBox.Show("This Person will be deleted forever!!!\nAre you sure??", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Business_Layer.Person.DeletePerson(PersonID))
                    MessageBox.Show("The Person has been deleted successfuly!!", "Deletion Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("The Person can't be deleted due to some background relation!!", "Deletion Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            PeopleRecords = Business_Layer.Person.FindAllPeople();
            DGV_PeopleData.DataSource = PeopleRecords;
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PB_AddNewPerson_Click(sender, e);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(DGV_PeopleData.CurrentRow.Cells["PersonID"].Value);
            UpdatePerson_Form updatePerson_Form = new UpdatePerson_Form(PersonID);
            updatePerson_Form.ShowDialog();

            LoadPeopleData();
        }

        private void CMS_ManagePeopleShortcuts_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(DGV_PeopleData.CurrentRow == null || DGV_PeopleData.CurrentRow.IsNewRow)
                e.Cancel = true;
        }

        private void DT_DateOfBirth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void DGV_PeopleData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

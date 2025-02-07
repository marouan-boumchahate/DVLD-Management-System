using DVLD___System.Driving_License.Local;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Driving_License.International
{
    public partial class ManageInterLicenses_Form : Form
    {
        public ManageInterLicenses_Form()
        {
            InitializeComponent();

            CB_FindApplicationBy.SelectedIndex = 0;
            CB_Activity.SelectedIndex = 0; startCB = true;

            LoadInternationalLicensesData();
        }

        DataTable LDLARecords = new DataTable();
        private bool startCB = false;

        private void LoadInternationalLicensesData()
        {
            LDLARecords = Business_Layer.InternationalLicense.AllInternationalLicenses();
            DGV_InterLicensesData.DataSource = LDLARecords;

            l_RecordsLength.Text = LDLARecords.Rows.Count.ToString();

            DGV_InterLicensesData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void CB_FindLicenseBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_TextFilter.Text = "";

            if (CB_FindApplicationBy.SelectedItem.ToString() == "None")
            {
                TB_TextFilter.Visible = false; CB_Activity.Visible = false; DT_Date.Visible = false;
                return;
            }

            if (CB_FindApplicationBy.SelectedItem.ToString() == "is Active")
            {
                TB_TextFilter.Visible = false; CB_Activity.Visible = true; DT_Date.Visible = false;
                return;
            }

            if (CB_FindApplicationBy.SelectedItem.ToString() == "Issue Date" || CB_FindApplicationBy.SelectedItem.ToString() == "Expiration Date")
            {
                TB_TextFilter.Visible = false; CB_Activity.Visible = false; DT_Date.Visible = true;
                return;
            }

            TB_TextFilter.Visible = true; CB_Activity.Visible = false; DT_Date.Visible = false;
        }
        private void TB_TextFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(CB_FindApplicationBy.SelectedItem.ToString() == "is Active"  || CB_FindApplicationBy.SelectedItem.ToString() == "Issue Date" || CB_FindApplicationBy.SelectedItem.ToString() == "Expiration Date"))
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        private string CreateQuery(ComboBox cb, TextBox tb)
        {
            if (tb.Text == "") return "";

            return $"[{cb.SelectedItem.ToString()}] = {tb.Text}";
        }
        private void TB_TextFilter_TextChanged(object sender, EventArgs e)
        {
            DataView originalView = LDLARecords.DefaultView.ToTable().DefaultView;

            DataView filteredView = LDLARecords.DefaultView;
            filteredView.RowFilter = CreateQuery(CB_FindApplicationBy, TB_TextFilter);
        }
        private void CB_Activity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!startCB) return;

            if (CB_Activity.SelectedItem.ToString() == "All") TB_TextFilter.Text = "";
            else TB_TextFilter.Text = "'" + CB_Activity.SelectedItem.ToString() + "'";
        }
        private void DT_Date_CloseUp(object sender, EventArgs e)
        {
            TB_TextFilter.Text = "'" + DT_Date.Value.ToString("MM/dd/yyyy") + "'";
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void PB_ApplyForLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            AddInterLicense_Form addInterLicense_Form = new AddInterLicense_Form();
            addInterLicense_Form.ShowDialog();

            LoadInternationalLicensesData();
        }
        private void CMS_ManageInternationalLicensesShortcuts_Opening(object sender, CancelEventArgs e)
        {
            if (DGV_InterLicensesData.CurrentRow == null || DGV_InterLicensesData.CurrentRow.IsNewRow)
                e.Cancel = true;
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Business_Layer.Driver.FindDriverByID(Convert.ToInt32(DGV_InterLicensesData.CurrentRow.Cells["Driver ID"].Value)).PersonInfo.PersonID;

            ShowPersonDetails_Form showPersonDetails_Form = new ShowPersonDetails_Form(PersonID);
            showPersonDetails_Form.ShowDialog();
        }

        private void ShowLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int InternationalLicenseID = Convert.ToInt32(DGV_InterLicensesData.CurrentRow.Cells["International License ID"].Value);

            ShowInterLicense_Form showInterLicense_Form = new ShowInterLicense_Form(InternationalLicenseID);
            showInterLicense_Form.ShowDialog();
        }

        private void ShowLicensesHistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Business_Layer.Driver.FindDriverByID(Convert.ToInt32(DGV_InterLicensesData.CurrentRow.Cells["Driver ID"].Value)).PersonInfo.PersonID;

            ShowLicenseHistory_Form showLicensesHist_Form = new ShowLicenseHistory_Form(PersonID);
            showLicensesHist_Form.ShowDialog();
        }
    }
}

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

namespace DVLD___System.Driving_License.Detained___Release
{
    public partial class MngDetainLicenses_Form : Form
    {
        DataTable DetainLicensesRecords = new DataTable();
        private bool startCB = false;

        private void LoadDetainLicenses()
        {
            DetainLicensesRecords = Business_Layer.DetainedLicense.FindAllDetainLicenses();
            DGV_DetainedLicenseData.DataSource = DetainLicensesRecords;

            l_RecordsLength.Text = DetainLicensesRecords.Rows.Count.ToString();

            DGV_DetainedLicenseData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public MngDetainLicenses_Form()
        {
            InitializeComponent();

            CB_FindDetainLicenseBy.SelectedIndex = 0;
            CB_Status.SelectedIndex = 0;
            startCB = true;

            LoadDetainLicenses();
        }
        private void CB_FindDetainLicenseBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_TextFilter.Text = "";

            if (CB_FindDetainLicenseBy.SelectedItem.ToString() == "None")
            {
                TB_TextFilter.Visible = false; CB_Status.Visible = false; DT_Date.Visible = false;
                return;
            }

            if (CB_FindDetainLicenseBy.SelectedItem.ToString() == "is Released")
            {
                TB_TextFilter.Visible = false; CB_Status.Visible = true; DT_Date.Visible = false;
                return;
            }

            if (CB_FindDetainLicenseBy.SelectedItem.ToString() == "Detain Date" || CB_FindDetainLicenseBy.SelectedItem.ToString() == "Release Date")
            {
                TB_TextFilter.Visible = false; CB_Status.Visible = false; DT_Date.Visible = true;
                return;
            }

            TB_TextFilter.Visible = true; CB_Status.Visible = false; DT_Date.Visible = false;
        }
        private void TB_TextFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CB_FindDetainLicenseBy.SelectedItem.ToString() == "Fine Fees" || CB_FindDetainLicenseBy.SelectedItem.ToString() == "Detain ID" || CB_FindDetainLicenseBy.SelectedItem.ToString() == "License ID" || CB_FindDetainLicenseBy.SelectedItem.ToString() == "Application ID")
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

            if (CB_FindDetainLicenseBy.SelectedItem.ToString() == "Fine Fees")
                if (e.KeyChar == '.' && TB_TextFilter.Text != "" && TB_TextFilter.Text.IndexOf('.') == -1) e.Handled = false;
        }
        private string CreateQuery(ComboBox cb, TextBox tb)
        {
            if (tb.Text == "") return "";

            if(CB_FindDetainLicenseBy.SelectedItem.ToString() == "Full Name" || CB_FindDetainLicenseBy.SelectedItem.ToString() == "National No")
                return $"[{cb.SelectedItem.ToString()}] LIKE '{tb.Text}%'";

            return $"[{cb.SelectedItem.ToString()}] = '{tb.Text}'";
        }
        private void TB_TextFilter_TextChanged(object sender, EventArgs e)
        {
            DataView originalView = DetainLicensesRecords.DefaultView.ToTable().DefaultView;

            DataView filteredView = DetainLicensesRecords.DefaultView;
            filteredView.RowFilter = CreateQuery(CB_FindDetainLicenseBy, TB_TextFilter);
        }
        private void CB_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!startCB) return;

            if (CB_Status.SelectedItem.ToString() == "All") TB_TextFilter.Text = "";
            else TB_TextFilter.Text = CB_Status.SelectedItem.ToString();
        }
        private void DT_ApplicationDate_CloseUp(object sender, EventArgs e)
        {
            TB_TextFilter.Text = DT_Date.Value.ToString("MM/dd/yyyy");
        }
        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        int PersonID = -1;
        Business_Layer.License license = null;
        private void CMS_ManageDetainedLicenseShortcuts_Opening(object sender, CancelEventArgs e)
        {
            if(DGV_DetainedLicenseData.CurrentRow == null || DGV_DetainedLicenseData.CurrentRow.IsNewRow)
                e.Cancel = true;

            PersonID = Business_Layer.Person.FindPersonByNationalNo(DGV_DetainedLicenseData.CurrentRow.Cells["National No"].Value.ToString()).PersonID;

            int licenseID = Convert.ToInt32(DGV_DetainedLicenseData.CurrentRow.Cells["License ID"].Value);
            license = Business_Layer.License.FindLicenseByID(licenseID);

            string status = DGV_DetainedLicenseData.CurrentRow.Cells["is Released"].Value.ToString();
            releaseLicenseToolStripMenuItem.Enabled = status == "Yes" ? false : true;
        }

        private void PB_DetainLicense_Click(object sender, EventArgs e)
        {
            DetainLicense_Form detainLicense_Form = new DetainLicense_Form();
            detainLicense_Form.ShowDialog();
        }

        private void PB_ReleaseLicense_Click(object sender, EventArgs e)
        {
            ReleaseLicense_Form releaseLicense_Form = new ReleaseLicense_Form();
            releaseLicense_Form.ShowDialog();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPersonDetails_Form showPersonDetails_Form = new ShowPersonDetails_Form(PersonID);
            showPersonDetails_Form.ShowDialog();
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicense_Form showLicense_Form = new ShowLicense_Form(license);
            showLicense_Form.ShowDialog();
        }

        private void showLicensesHistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicenseHistory_Form showLicenseHistory_Form = new ShowLicenseHistory_Form(PersonID);
            showLicenseHistory_Form.ShowDialog();
        }

        private void releaseLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseLicense_Form releaseLicense_Form = new ReleaseLicense_Form(license.LicenseID);
            releaseLicense_Form.ShowDialog();

            LoadDetainLicenses();
        }
    }
}

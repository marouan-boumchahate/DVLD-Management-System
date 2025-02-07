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

namespace DVLD___System.Drivers
{
    public partial class ManageDrivers_Form : Form
    {
        DataTable DriversRecords = new DataTable();

        public ManageDrivers_Form()
        {
            InitializeComponent();
            LoadDriversData();

            CB_FindDriverBy.SelectedIndex = 0;
        }

        private void LoadDriversData()
        {
            DriversRecords = Business_Layer.Driver.FindAllDrivers();
            DGV_DriversData.DataSource = DriversRecords;

            l_RecordsLength.Text = DriversRecords.Rows.Count.ToString();

            DGV_DriversData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CB_FindDriverBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_TextFilter.Text = "";

            if (CB_FindDriverBy.SelectedItem.ToString() == "None")
            {
                TB_TextFilter.Visible = false; DT_Date.Visible = false;
                return;
            }
            if (CB_FindDriverBy.SelectedItem.ToString() == "Date")
            {
                TB_TextFilter.Visible = false; DT_Date.Visible = true;
                return;
            }

            TB_TextFilter.Visible = true; DT_Date.Visible = false;
        }
        private void TB_TextFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CB_FindDriverBy.SelectedItem.ToString() == "Person ID" || CB_FindDriverBy.SelectedItem.ToString() == "Driver ID" || CB_FindDriverBy.SelectedItem.ToString() == "Active Licenses")
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;
        }
        private string CreateQuery(ComboBox cb, TextBox tb)
        {
            if (tb.Text == "") return "";


            if ((cb.SelectedItem.ToString() == "Person ID") || (cb.SelectedItem.ToString() == "Driver ID") || cb.SelectedItem.ToString() == "Date" || cb.SelectedItem.ToString() == "Active Licenses")
                return $"[{cb.SelectedItem.ToString()}] = {tb.Text}";

            return $"[{cb.SelectedItem.ToString()}] LIKE '{tb.Text}%'";
        }
        private void TB_TextFilter_TextChanged(object sender, EventArgs e)
        {
            DataView originalView = DriversRecords.DefaultView.ToTable().DefaultView;

            DataView filteredView = DriversRecords.DefaultView;
            filteredView.RowFilter = CreateQuery(CB_FindDriverBy, TB_TextFilter);
        }
        private void DT_Date_CloseUp(object sender, EventArgs e)
        {
            TB_TextFilter.Text = "'" + DT_Date.Value.ToString("MM-dd-yyyy") + "'";
        }

        int DriverID = -1;
        Business_Layer.License license = null;
        private void CMS_DriverShortCuts_Opening(object sender, CancelEventArgs e)
        {
            if(DGV_DriversData.CurrentRow == null || DGV_DriversData.CurrentRow.IsNewRow)
                { e.Cancel = true; return; }

            DriverID = Convert.ToInt32(DGV_DriversData.CurrentRow.Cells["Driver ID"].Value);
            license = Business_Layer.License.FindLicenseByDriverID(DriverID);
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicense_Form license_form = new ShowLicense_Form(license);

            license_form.ShowDialog();
        }

        private void showLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicenseHistory_Form hst_form = new ShowLicenseHistory_Form(license.Driver.PersonInfo.PersonID);

            hst_form.ShowDialog();
        }
    }
}

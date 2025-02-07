using DVLD___System.Applications.Local_Driving_License;
using DVLD___System.Driving_License.Tests;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DVLD___System.Driving_License.Local
{
    public partial class ManageLocalDrivingLicense_Form : Form
    {
        DataTable LDLARecords = new DataTable();
        private bool startCB = false;

        private void LoadLDLAppData()
        {
            LDLARecords = Business_Layer.LocalDrivingLicenseApplication.FindAllLDLApplications();
            DGV_LDLAppData.DataSource = LDLARecords;

            l_RecordsLength.Text = LDLARecords.Rows.Count.ToString();

            DGV_LDLAppData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        public ManageLocalDrivingLicense_Form()
        {
            InitializeComponent();

            CB_FindApplicationBy.SelectedIndex = 0;
            CB_Status.SelectedIndex = 0; startCB = true;

            LoadLDLAppData();
        }
        private void CB_FindApplicationBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TB_TextFilter.Text = "";

            if (CB_FindApplicationBy.SelectedItem.ToString() == "None")
            {
                TB_TextFilter.Visible = false; CB_Status.Visible = false; DT_ApplicationDate.Visible = false;
                return;
            }

            if (CB_FindApplicationBy.SelectedItem.ToString() == "Status")
            {
                TB_TextFilter.Visible = false; CB_Status.Visible = true; DT_ApplicationDate.Visible = false;
                return;
            }

            if (CB_FindApplicationBy.SelectedItem.ToString() == "Application Date")
            {
                TB_TextFilter.Visible = false; CB_Status.Visible = false; DT_ApplicationDate.Visible = true;
                return;
            }

            TB_TextFilter.Visible = true; CB_Status.Visible = false; DT_ApplicationDate.Visible = false;
        }
        private void TB_TextFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CB_FindApplicationBy.SelectedItem.ToString() == "L.D.L.App ID" || CB_FindApplicationBy.SelectedItem.ToString() == "Passed Tests")
                if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)) e.Handled = true;

            if (CB_FindApplicationBy.SelectedItem.ToString() == "Status")
                if (TB_TextFilter.Text.Length > 1 || !(e.KeyChar == '0' || e.KeyChar == '1' || char.IsControl(e.KeyChar))) e.Handled = true;
        }
        private string CreateQuery(ComboBox cb, TextBox tb)
        {
            if (tb.Text == "") return "";

            if ((cb.SelectedItem.ToString() == "L.D.L.App ID") || (cb.SelectedItem.ToString() == "Passed Tests") || (cb.SelectedItem.ToString() == "Status") || (cb.SelectedItem.ToString() == "Application Date"))
                return $"[{cb.SelectedItem.ToString()}] = {tb.Text}";

            return $"[{cb.SelectedItem.ToString()}] LIKE '{tb.Text}%'";
        }
        private void TB_TextFilter_TextChanged(object sender, EventArgs e)
        {
            DataView originalView = LDLARecords.DefaultView.ToTable().DefaultView;

            DataView filteredView = LDLARecords.DefaultView;
            filteredView.RowFilter = CreateQuery(CB_FindApplicationBy, TB_TextFilter);
        }
        private void CB_Status_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!startCB) return;

            if (CB_Status.SelectedItem.ToString() == "All") TB_TextFilter.Text = "";
            else TB_TextFilter.Text = "'" + CB_Status.SelectedItem.ToString() + "'";
        }
        private void DT_ApplicationDate_CloseUp(object sender, EventArgs e)
        {
            TB_TextFilter.Text = "'" + DT_ApplicationDate.Value.ToString("MM/dd/yyyy") + "'";
        }
        private void BT_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void PB_ApplyForLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            AddNewLocalDrivingLicense_Form addNewLocalDrivingLicense_Form = new AddNewLocalDrivingLicense_Form();
            addNewLocalDrivingLicense_Form.ShowDialog();

            LoadLDLAppData();
        }
        private void TestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem TSMI = (ToolStripMenuItem)sender;
            int TestTypeID = Convert.ToInt32(TSMI.Tag);
            string TestTypeName = TSMI.Text.Split(' ')[1];

            TestAppointment_Form visionTest_Form = new TestAppointment_Form(LocalDrivingLicenseApplicationID, TestTypeID, TestTypeName);
            visionTest_Form.ShowDialog();

            LoadLDLAppData();
        }
        private void ControlEnableOfToolStripMenuItem(bool showApp, bool editApp, bool deleteApp, bool cancelApp, bool scheduleTest, bool vision, bool written, bool street, bool issue, bool showLicense, bool licenseHistory)
        {
            showApplicationToolStripMenuItem.Enabled = showApp;
            editApplicationToolStripMenuItem.Enabled = editApp;
            deleteApplicationToolStripMenuItem.Enabled = deleteApp;
            cancelApplicationToolStripMenuItem.Enabled = cancelApp;
            scheduleTestToolStripMenuItem.Enabled = scheduleTest;

                visionTestToolStripMenuItem.Enabled = vision;
                writtenTestToolStripMenuItem.Enabled = written;
                streetTestToolStripMenuItem.Enabled = street;

            issueDrivingLicenseToolStripMenuItem.Enabled = issue;
            showLicenseToolStripMenuItem.Enabled = showLicense;
            showPersonLicenseHistoryToolStripMenuItem.Enabled = licenseHistory;
        }
        private void CMS_ManageLDLAppShortcuts_opened(object sender, EventArgs e)
        {
            int PassedTests = Business_Layer.Test.PassedTestsForApplication(LocalDrivingLicenseApplicationID);

            Business_Layer.LocalDrivingLicenseApplication ldlapplication = Business_Layer.LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);

            if (Convert.ToString(DGV_LDLAppData.CurrentRow.Cells["Status"].Value) == "Completed")
            {
                ControlEnableOfToolStripMenuItem(true, false, false, false, false, false, false, false, false, true, true);
                return;
            }
            if (Convert.ToString(DGV_LDLAppData.CurrentRow.Cells["Status"].Value) == "Cancelled")
            {
                ControlEnableOfToolStripMenuItem(true, false, false, false, false, false, false, false, false, false, false);
                return;
            }

            switch (PassedTests)
            {
                case 0:
                    ControlEnableOfToolStripMenuItem(true, true, true, true, true, true, false, false, false, false, true); break;
                case 1:
                    ControlEnableOfToolStripMenuItem(true, true, true, true, true, false, true, false, false, false, true); break;
                case 2:
                    ControlEnableOfToolStripMenuItem(true, true, true, true, true, false, false, true, false, false, true); break;
                default:
                    ControlEnableOfToolStripMenuItem(true, true, true, true, false, false, false, false, true, false, true); break;
            }
        }
        private void issueDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IssueDrivingLicense_Form issueDrivingLicense_Form = new IssueDrivingLicense_Form(LocalDrivingLicenseApplicationID);
            issueDrivingLicense_Form.ShowDialog();

            LoadLDLAppData();
        }
        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLicense_Form showLicense_Form = new ShowLicense_Form(LocalDrivingLicenseApplicationID);
            showLicense_Form.ShowDialog();
        }
        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you wanna delete this application??", "Application Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Business_Layer.LocalDrivingLicenseApplication ldlapp = Business_Layer.LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID);

                if (Business_Layer.LocalDrivingLicenseApplication.deleteLocalApplication(ldlapp.ID) && Business_Layer.Application.deleteApplication(ldlapp.Application.ApplicationID))
                    { MessageBox.Show("The application has been successfully deleted.", "Deletion Successed", MessageBoxButtons.OK, MessageBoxIcon.Information); LoadLDLAppData(); }
                else
                    MessageBox.Show("This application cannot be deleted. But it can be cancelled!!", "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you certain you want to cancel this application?\r\n\r\nPlease note: The client will not be eligible for a refund, and the application cannot be reactivated once canceled.", "Application Cancellation Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Business_Layer.Application App =  Business_Layer.LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID).Application;

                App.Status = 2;
                App.LastStatusDate = DateTime.Now;

                if (App.Save())
                { MessageBox.Show("The application has been successfully cancelled.", "Cancellation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information); LoadLDLAppData(); }
                else
                    MessageBox.Show("The system was unable to cancel this application!!", "Cancellation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = Business_Layer.Person.FindPersonByNationalNo(Convert.ToString(DGV_LDLAppData.CurrentRow.Cells["National No"].Value)).PersonID;

            ShowLicenseHistory_Form showLicenseHistory_Form = new ShowLicenseHistory_Form(PersonID);
            showLicenseHistory_Form.ShowDialog();
        }

        int LocalDrivingLicenseApplicationID = -1;
        private void CMS_ManageLDLAppShortcuts_Opening(object sender, CancelEventArgs e)
        {
            if (DGV_LDLAppData.CurrentRow == null || DGV_LDLAppData.CurrentRow.IsNewRow)
            { e.Cancel = true; return; }

            LocalDrivingLicenseApplicationID = Convert.ToInt32(DGV_LDLAppData.CurrentRow.Cells["L.D.L.App ID"].Value);
        }

        private void showApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLocalDrivingApplication_Page showLocalDrivingApplication_Page = new ShowLocalDrivingApplication_Page(LocalDrivingLicenseApplicationID);
            showLocalDrivingApplication_Page.ShowDialog();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewLocalDrivingLicense_Form addNewLocalDrivingLicense_form = new AddNewLocalDrivingLicense_Form(LocalDrivingLicenseApplicationID);
            addNewLocalDrivingLicense_form.ShowDialog();

            LoadLDLAppData();
        }
    }
}

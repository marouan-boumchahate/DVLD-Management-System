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

namespace DVLD___System.Driving_License.Lost___Damaged
{
    public partial class LostDamagedLicense_Form : Form
    {
        Business_Layer.License MainLicense {  get; set; }
        public LostDamagedLicense_Form()
        {
            InitializeComponent();
            LoadApplicationInfo();
        }

        private void LoadApplicationInfo()
        {
            L_ApplicationDate.Text = DateTime.Today.ToString("dd MMMM yyyy");
            RB_Damaged.Checked = true;
            L_CreatedBy.Text = Settings.Current_User.PersonInfo.FirstName;
        }

        private Business_Layer.Application CreateApplicationObject()
        {
            Business_Layer.Application newApplication = new Business_Layer.Application();

            newApplication.ApplicationDate = Convert.ToDateTime(L_ApplicationDate.Text);
            newApplication.PersonInfo = LDLC_LicenseInfo.license.Driver.PersonInfo;
            newApplication.ApplicationTypeInfo = Business_Layer.ApplicationType.FindApplicationByID(TypeID);
            newApplication.Status = 3;
            newApplication.LastStatusDate = newApplication.ApplicationDate;
            newApplication.PaidFees = Convert.ToDouble(L_ApplicationFees.Text);
            newApplication.CreatedBy = Settings.Current_User;

            return newApplication;
        }
        private Business_Layer.License CreateLicenseObject(int ApplicationID)
        {
            Business_Layer.License license = new Business_Layer.License();

            license.Application = Business_Layer.Application.FindApplication(ApplicationID);
            license.Driver = LDLC_LicenseInfo.license.Driver;
            license.LicenseClass = LDLC_LicenseInfo.license.LicenseClass;
            license.IssueDate = LDLC_LicenseInfo.license.IssueDate;
            license.ExpirationDate = LDLC_LicenseInfo.license.ExpirationDate;
            license.PaidFees = 0;
            license.Notes = "Replace for " + (RB_Damaged.Checked ? RB_Damaged.Text : RB_Lost.Text);
            license.IssueReason = TypeID;
            license.isActive = true;
            license.CreatedByUser = Settings.Current_User;

            return license;
        }
        private void BT_Replace_Click(object sender, EventArgs e)
        {
            if (!LDLC_LicenseInfo.license.DeactivateLicense())
            {
                MessageBox.Show($"An error occurred while attempting to deactivate the license!!\n\nTry Again Later.", "Old License couldn't be deactivated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Business_Layer.Application app = CreateApplicationObject();

            if (!app.Save())
            {
                MessageBox.Show("The Application couldn't be applied for this driver!!\n\nTry Again Later.", "Application Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Business_Layer.License license = CreateLicenseObject(app.ApplicationID);

            if (license.AddNewLicense())
            {
                MessageBox.Show("The Driving License Has been replaced successfully.", "Issuing Successed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                L_LicenseApplicationID.Text = app.ApplicationID.ToString();
                L_NewLicenseID.Text = license.LicenseID.ToString();

                LL_ShowLicense.Enabled = true;
                LL_ShowLicensesHist.Enabled = true;

                LDLC_LicenseInfo.deactivate();

                MainLicense = license;
            }
            else
                MessageBox.Show("Something went wrong during the replace of the license!!\n\nTry Again Later.", "Issuing Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LDLC_LicenseInfo_LocalLicenseFound(int obj)
        {
            BT_Replace.Enabled = false;
            LL_ShowLicense.Enabled = false;
            LL_ShowLicensesHist.Enabled = false;

            if (!LDLC_LicenseInfo.license.isActive)
            {
                MessageBox.Show($"This License cannot be replaced because it is NOT active", "The license is NOT Active anymore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (LDLC_LicenseInfo.license.ExpirationDate.Date < DateTime.Today.Date)
            {
                MessageBox.Show($"This License cannot be replaced because it expired on {LDLC_LicenseInfo.license.ExpirationDate.ToString("dd MMMM yyyy")}", "The license is NOT valid anymore", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            L_OldLicenseID.Text = obj.ToString();
            BT_Replace.Enabled = true;
        }

        private void LL_ShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicense_Form showLicense_Form = new ShowLicense_Form(MainLicense);
            showLicense_Form.ShowDialog();
        }

        private void LL_ShowLicensesHist_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseHistory_Form showLicenseHistory_Form = new ShowLicenseHistory_Form(LDLC_LicenseInfo.GetPersonID());
            showLicenseHistory_Form.ShowDialog();
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        int TypeID = 4;
        private void RB_Damaged_CheckedChanged(object sender, EventArgs e)
        {
            TypeID = RB_Damaged.Checked ? 4 : 3;
            L_ApplicationFees.Text = Business_Layer.ApplicationType.FindApplicationByID(TypeID).ApplicationFees.ToString();
        }
    }
}

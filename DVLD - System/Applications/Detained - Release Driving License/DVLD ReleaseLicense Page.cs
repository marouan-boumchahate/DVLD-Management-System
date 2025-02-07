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
    public partial class ReleaseLicense_Form : Form
    {
        Business_Layer.DetainedLicense MainDetain { get; set; }
        public ReleaseLicense_Form()
        {
            InitializeComponent();
            LoadApplicationInfo();
        }
        public ReleaseLicense_Form(int LicenseID)
        {
            InitializeComponent();
            LoadApplicationInfo();

            LDLC_LicenseInfo.LoadLicense(LicenseID);
        }

        private void LoadApplicationInfo()
        {
            L_ApplicationFees.Text = Business_Layer.ApplicationType.FindApplicationByID(5).ApplicationFees.ToString();
            L_ReleaseBy.Text = Settings.Current_User.PersonInfo.FirstName;
        }

        private Business_Layer.Application CreateApplicationObject()
        {
            Business_Layer.Application newApplication = new Business_Layer.Application();

            newApplication.PersonInfo = LDLC_LicenseInfo.license.Driver.PersonInfo;
            newApplication.ApplicationTypeInfo = Business_Layer.ApplicationType.FindApplicationByID(5);
            newApplication.ApplicationDate = DateTime.Now;
            newApplication.Status = 3;
            newApplication.LastStatusDate = newApplication.ApplicationDate;
            newApplication.PaidFees = Convert.ToDouble(L_ApplicationFees.Text);
            newApplication.CreatedBy = Settings.Current_User;

            return newApplication;
        }
        private void CreateLicenseObject(int ApplicationID)
        {
            MainDetain.isReleased = true;
            MainDetain.ReleaseDate = DateTime.Now;
            MainDetain.ReleaseApplication = Business_Layer.Application.FindApplication(ApplicationID);
            MainDetain.ReleasedByUser = Settings.Current_User;
        }
        private void BT_Release_Click(object sender, EventArgs e)
        {
            if (!LDLC_LicenseInfo.license.ActivateLicense())
            {
                MessageBox.Show($"An error occurred while attempting to Activate the license!!\n\nTry Again Later.", "The License couldn't be Activated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Business_Layer.Application app = CreateApplicationObject();

            if (!app.Save())
            {
                MessageBox.Show("The Application couldn't be applied for this driver!!\n\nTry Again Later.", "Application Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateLicenseObject(app.ApplicationID);

            if (MainDetain.ReleaseLicense())
            {
                MessageBox.Show("The detained license has been successfully released.", "License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LL_ShowLicense.Enabled = true;
                LL_ShowLicensesHist.Enabled = true;

                LDLC_LicenseInfo.release();
                LDLC_LicenseInfo.activate();

                BT_Release.Enabled = false;
            }
            else
                MessageBox.Show("The attempt to release the detained license has failed!!\n\nTry Again Later.", "Release Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void LDLC_LicenseInfo_LocalLicenseFound(int obj)
        {
            BT_Release.Enabled = false;
            LL_ShowLicense.Enabled = false;
            LL_ShowLicensesHist.Enabled = false;

            MainDetain = Business_Layer.DetainedLicense.FindDetainLicenseByLicenseID(LDLC_LicenseInfo.license.LicenseID);
            if (MainDetain == null || MainDetain.isReleased)
            {
                MessageBox.Show($"This license has not been detained!!!", "No Detainment", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            L_LicenseID.Text = obj.ToString();
            L_DetainID.Text = MainDetain.DetainID.ToString();
            L_FineFees.Text = MainDetain.FineFees.ToString();
            L_DetainedBy.Text = Settings.Current_User.PersonInfo.FirstName;
            L_DetainDate.Text = MainDetain.DetainDate.ToString("dd MMMM yyyy");

            L_TotalFees.Text = (Convert.ToDouble(L_ApplicationFees.Text) + MainDetain.FineFees).ToString();

            BT_Release.Enabled = true;
        }

        private void LL_ShowLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicense_Form showLicense_Form = new ShowLicense_Form(LDLC_LicenseInfo.license);
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
    }
}

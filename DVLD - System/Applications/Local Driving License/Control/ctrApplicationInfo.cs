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

namespace DVLD___System.Applications.Local_Driving_License.Control
{
    public partial class ctrApplicationInfo : UserControl
    {
        private Business_Layer.LocalDrivingLicenseApplication LDLApp = null;
        public ctrApplicationInfo()
        {
            InitializeComponent();
        }

        private void PlaceLocalDrivingInformation(int ID, Business_Layer.LicenseClass LC)
        {
            L_LDLicenseID.Text = ID.ToString();
            L_LicenseClass.Text = LC.LicenseName;

            byte passedTests = Convert.ToByte(Business_Layer.Test.PassedTestsForApplication(ID));
            L_PassedTests.Text = $"{passedTests}/3";

            // If the driver still getting exams that means he/she does NOT have a license yet
            if (passedTests < 3) LL_ViewLicense.Enabled = false;
        }
        private void PlaceBaseApplicationInfo(Business_Layer.Application app)
        {
            L_ApplicationID.Text = app.ApplicationID.ToString();
            L_Status.Text = app.statusASword();
            L_Fees.Text = app.PaidFees.ToString();
            L_Type.Text = app.ApplicationTypeInfo.ApplicationTitle;
            L_Applicant.Text = app.PersonInfo.GetFullName();
            L_Date.Text = app.ApplicationDate.ToString("dd/MM/yyyy");
            L_StatusDate.Text = app.LastStatusDate.ToString("dd/MM/yyyy");
            L_CreatedBy.Text = app.CreatedBy.PersonInfo.FirstName;
        }

        public void LoadLocalDrivingApplication(int LDLicenseAppID)
        {
            LDLApp = Business_Layer.LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LDLicenseAppID);

            if (LDLApp == null) {MessageBox.Show("We are not able to find this local license application", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Error); return; }

            PlaceLocalDrivingInformation(LDLicenseAppID, LDLApp.LicenseClass);
            PlaceBaseApplicationInfo(LDLApp.Application);
        }

        private void LL_ViewPerson_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonDetails_Form showPersonDetails_Form = new ShowPersonDetails_Form(LDLApp.Application.PersonInfo.PersonID);
            showPersonDetails_Form.ShowDialog();
        }
        private void LL_ViewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Business_Layer.License License = Business_Layer.License.FindLicenseByApplicationID(LDLApp.Application.ApplicationID, LDLApp.LicenseClass.LicenseID);

            ShowLicense_Form showLicense_Form = new ShowLicense_Form(License);
            showLicense_Form.ShowDialog();
        }
    }
}

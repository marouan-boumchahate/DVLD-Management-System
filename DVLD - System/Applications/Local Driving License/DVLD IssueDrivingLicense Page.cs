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

namespace DVLD___System.Driving_License.Local
{
    public partial class IssueDrivingLicense_Form : Form
    {
        private int LDLApplicationID {  get; set; }
        public IssueDrivingLicense_Form(int lDLApplicationID)
        {
            InitializeComponent();
            LDLApplicationID = lDLApplicationID;

            DLAC_DrivingLicenseApplication.LoadDrivingLicense(LDLApplicationID);
            DLAC_DrivingLicenseApplication.UpdatePaidFees(LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LDLApplicationID).LicenseClass.Fees);
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void CreateDriverObject(ref Driver dr)
        {
            Driver driver = Driver.FindDriverByPersonID(DLAC_DrivingLicenseApplication.GetPersonID());

            if(driver != null) { dr = driver; return; }

            dr.CreatedDate = DateTime.Now;
            dr.CreatedBy = Settings.Current_User;
            dr.PersonInfo = Person.FindPersonByID(DLAC_DrivingLicenseApplication.GetPersonID());
        }
        private void CreateLicenseObject(ref Business_Layer.License license, int DriverID)
        {
            LocalDrivingLicenseApplication licenseApplication = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LDLApplicationID);
            LicenseClass licenseClass = licenseApplication.LicenseClass;

            license.Driver = Driver.FindDriverByID(DriverID);
            license.Application = licenseApplication.Application;
            license.PaidFees = licenseClass.Fees;
            license.Notes = RTB_Notes.Text;
            license.LicenseClass = licenseApplication.LicenseClass;
            license.isActive = true;
            license.IssueDate = DateTime.Now;
            license.ExpirationDate = DateTime.Now.AddYears(licenseClass.DefaultValidityLength);
            license.IssueReason = 1;
            license.CreatedByUser = Settings.Current_User;
        }
        private void BT_Issue_Click(object sender, EventArgs e)
        {
            Driver driver = new Driver();
            Business_Layer.License license = new Business_Layer.License();

            CreateDriverObject(ref driver);
            if (!(driver.PersonInfo.PersonID != -1 && driver.AddNewDriver())) { 
                MessageBox.Show("The System couldn't create a license for this client!!!\n\nTry Again Later.", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            CreateLicenseObject(ref license, driver.DriverID);
            
            Business_Layer.Application application = license.Application;
            application.Status = 3;
            application.LastStatusDate = DateTime.Now;

            if (application.Save() && license.AddNewLicense())
                { MessageBox.Show($"The License has been successfully issued. with the ID = {license.LicenseID}", "Successfuly Issued", MessageBoxButtons.OK, MessageBoxIcon.Information); Close(); }
            else
                MessageBox.Show("The System couldn't create a license for this client!!!\n\nTry Again Later.", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

using Business_Layer;
using System;
using System.Windows.Forms;

namespace DVLD___System.Driving_License.Tests
{
    public partial class DrivingLicenseApplicationCard : UserControl
    {
        private int PersonID {  get; set; }
        private int LDLA_ID {  get; set; }
        public DrivingLicenseApplicationCard()
        {
            InitializeComponent();
        }

        private void SetDrivingLicenseApplication(ref LocalDrivingLicenseApplication LDLApplication)
        {
            L_LDLA_ID.Text = LDLApplication.ID.ToString();
            L_LicenseClass.Text = LDLApplication.LicenseClass.LicenseName;
            L_PassedTests.Text = $"{Test.PassedTestsForApplication(LDLA_ID)}/3";
        }
        private void SetApplication(ref Business_Layer.Application app)
        {
            PersonID = app.PersonInfo.PersonID;
            L_ApplicationID.Text = app.ApplicationID.ToString();

            switch(app.Status)
            {
                case 1:
                    L_Status.Text = "New";
                    break;
                case 2:
                    L_Status.Text = "Cancelled";
                    break;
                default:
                    L_Status.Text = "Completed";
                    break;
            }
            L_Fees.Text = app.PaidFees.ToString();
            L_Type.Text = app.ApplicationTypeInfo.ApplicationTitle;
            
            //Person per = app.PersonInfo;
            L_Applicant.Text = app.PersonInfo.GetFullName();

            L_ApplicationDate.Text = app.ApplicationDate.ToString("dd MMMM yyyy");
            L_StatusDate.Text = app.LastStatusDate.ToString("dd MMMM yyyy");
            L_CreatedByFirstName.Text = app.CreatedBy.PersonInfo.FirstName;
        }
        public void LoadDrivingLicense(int LDLA_ID)
        {
            this.LDLA_ID = LDLA_ID;

            LocalDrivingLicenseApplication LDLApplication = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LDLA_ID);
            SetDrivingLicenseApplication(ref LDLApplication);

            Business_Layer.Application application = LDLApplication.Application;
            SetApplication(ref application);
        }

        private void LL_ViewPersonalInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowPersonDetails_Form showPersonDetails_Form = new ShowPersonDetails_Form(PersonID);
            showPersonDetails_Form.ShowDialog();
        }

        public int GetPersonID()
        {
            return PersonID;
        }
        public void UpdatePaidFees(double Fees)
        {
            L_Fees.Text = Fees.ToString();
        }
    }
}

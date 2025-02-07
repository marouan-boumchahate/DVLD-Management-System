using Business_Layer;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DVLD___System.Driving_License.Tests
{
    public partial class TakeTestSchedule_Form : Form
    {
        private int LDLApplicationID {  get; set; }
        private int Trials {  get; set; }
        private bool isEdit {  get; set; }
        private int TestTypeID { get; set; }

        private TestAppointment testAppointment = new TestAppointment();

        public TakeTestSchedule_Form(int LDLApplication, int Trials, bool isEdit, int testTypeID, Image TestPicture)
        {
            InitializeComponent();
            PB_Title.Image = TestPicture;

            LDLApplicationID = LDLApplication;
            this.Trials = Trials;
            this.isEdit = isEdit;
            TestTypeID = testTypeID;

            if (isEdit) L_Title.Text = $"Re{L_Title.Text}";
            LoadAppointment();
        }

        private void LoadReTakeTest()
        {
            GB_RetakeTestInfo.Enabled = true;

            L_RetakeApplicationFees.Text = ApplicationType.ReTakeTestApplicationFees().ToString();
            L_TotalFees.Text = (Convert.ToDouble(L_RetakeApplicationFees.Text) + Convert.ToDouble(L_Fees.Text)).ToString();

            if(isEdit) L_ReTakeTestApplicationID.Text = TestAppointment.LastAppointmentForLocalDL(LDLApplicationID, TestTypeID).TestAppointmentID.ToString();
        }
        private void LoadAppointment()
        {
            DT_AppointmentDate.Value = DT_AppointmentDate.MinDate = DateTime.Today;

            LocalDrivingLicenseApplication LDL_App = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LDLApplicationID);

            L_LDLA_ID.Text = LDL_App.ID.ToString();
            L_LicenseClass.Text = LDL_App.LicenseClass.LicenseName;
            
            Business_Layer.Application App = LDL_App.Application;

            L_Applicant.Text = App.PersonInfo.GetFullName();
            L_Trials.Text = Trials.ToString();
            L_Fees.Text = TestType.FindTestByID(TestTypeID).TestFees.ToString();
            if (isEdit) DT_AppointmentDate.Value = TestAppointment.LastAppointmentForLocalDL(LDLApplicationID, TestTypeID).AppointmentDate;

            if (TestAppointment.numberOfLockedAppointments(LDL_App.ID, TestTypeID) >= 1) LoadReTakeTest();
        }

        private void SetAppointmentObject()
        {
            testAppointment.TestType = TestType.FindTestByID(TestTypeID);
            testAppointment.LocalDrivingLicenseApplication = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LDLApplicationID);
            testAppointment.AppointmentDate = DT_AppointmentDate.Value;
            testAppointment.PaidFees = Convert.ToDouble(GB_RetakeTestInfo.Enabled ? L_TotalFees.Text : L_Fees.Text);
            testAppointment.CreatedByUser = Settings.Current_User;
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Add()
        {
            SetAppointmentObject();

            if (testAppointment.TakeTestAppointment())
            {
                MessageBox.Show("The Appointment has been taken successfuly.", "Successfuly Taken", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (GB_RetakeTestInfo.Enabled) L_ReTakeTestApplicationID.Text = testAppointment.TestAppointmentID.ToString();
            }
            else
                MessageBox.Show("The System couldn't take this appointment right now!!\nTry Again Later.", "Operation Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Edit()
        {
            TestAppointment testAppointment = TestAppointment.LastAppointmentForLocalDL(LDLApplicationID, TestTypeID);

            if(TestAppointment.EditAppointmentDate(testAppointment.TestAppointmentID, DT_AppointmentDate.Value))
                MessageBox.Show("The Appointment has been Updated successfuly.", "Successfuly Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("The Appointment couldn't be updated.", "Update Failed to operate", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void BT_Save_Click(object sender, EventArgs e)
        {
            if(isEdit) Edit();
            else Add();

            Close();
        }
    }
}

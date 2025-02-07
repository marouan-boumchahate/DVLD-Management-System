using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___System.Driving_License.Tests
{
    public partial class TestResult_Form : Form
    {
        private int LDLA_ID {  get; set; }
        private int Trials {  get; set; }
        private int TestTypeID {  get; set; }
        public TestResult_Form(int LDLApplication_ID, int trials, int testTypeID)
        {
            InitializeComponent();
            LDLA_ID = LDLApplication_ID;
            Trials = trials;
            TestTypeID = testTypeID;

            LoadAppointmentInformation();
        }

        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void LoadAppointmentInformation()
        {
            Business_Layer.LocalDrivingLicenseApplication LDLApp = Business_Layer.LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(LDLA_ID);
            Business_Layer.Application App = LDLApp.Application;
            Business_Layer.TestAppointment testApp = Business_Layer.TestAppointment.LastAppointmentForLocalDL(LDLA_ID, TestTypeID);

            L_LDLA_ID.Text = LDLA_ID.ToString();
            L_LicenseClass.Text = LDLApp.LicenseClass.LicenseName;
            L_Applicant.Text = App.PersonInfo.GetFullName();
            L_Trials.Text = Trials.ToString();
            L_AppointmentDate.Text = testApp.AppointmentDate.ToString("dd MMMM yyyy");
            L_Fees.Text = testApp.PaidFees.ToString();
        }

        Business_Layer.Test test = new Business_Layer.Test();
        private void SetTestData()
        {
            test.Appointment = Business_Layer.TestAppointment.LastAppointmentForLocalDL(LDLA_ID, TestTypeID);
            test.TestResult = RB_Pass.Checked ? true : false;
            test.Notes = RTB_Note.Text;
            test.CreatedByUser = Settings.Current_User;
        }
        private void BT_Save_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("No way to edit the result later.\nAre you sure you wanna save??", "Saving Question", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            
            SetTestData();
            Business_Layer.TestAppointment.LockAnAppointment(Business_Layer.TestAppointment.LastAppointmentForLocalDL(LDLA_ID, TestTypeID).TestAppointmentID);

            if (test.SaveTest()) { MessageBox.Show("The Test Result has been saved successfuly.", "Saving Successed to operate", MessageBoxButtons.OK, MessageBoxIcon.Information); Close(); }
            else MessageBox.Show("The Test Result couldn't be saved!!!\nTry Again Later.", "Saving Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

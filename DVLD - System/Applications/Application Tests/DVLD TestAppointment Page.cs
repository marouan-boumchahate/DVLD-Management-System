using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD___System.Driving_License.Tests
{
    public partial class TestAppointment_Form : Form
    {
        DataTable TestAppointments = new DataTable();
        private int LDLApplicationID {  get; set; }
        private int TestTypeID { get; set; }
        private void LoadLDLAppData()
        {
            TestAppointments = Business_Layer.TestAppointment.FindAllApointmentsForLocalDrivingLicenseID(LDLApplicationID, TestTypeID);
            DGV_AppointmentsData.DataSource = TestAppointments;

            L_RecordsLength.Text = TestAppointments.Rows.Count.ToString();

            DGV_AppointmentsData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void ApplyTestTypePage(string TestType)
        {
            Text = TestType + ' ' + Text;
            L_Title.Text = TestType + ' ' + L_Title.Text;

            switch(TestType.ToLower())
            {
                case "vision":
                    PB_Title.Image = Properties.Resources.VisionTestLDLApplication;
                    break;
                case "written":
                    PB_Title.Image = Properties.Resources.WrittenTestLDLApplication;
                    break;
                default:
                    PB_Title.Image = Properties.Resources.DrivingTestLDLApplication;
                    break;
            }
        }
        public TestAppointment_Form(int LDLA_ID, int testTypeID, string TestType)
        {
            InitializeComponent();
            ApplyTestTypePage(TestType);

            LDLApplicationID = LDLA_ID;
            TestTypeID = testTypeID;

            LoadLDLAppData();
            DLAC_DrivingLicenseApplication.LoadDrivingLicense(LDLA_ID);
        }
        private void PB_ApplyForLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            if(Business_Layer.Test.PassedTestsForApplication(LDLApplicationID) >= TestTypeID)
            {
                MessageBox.Show("The client is ineligible to apply for another test, as they have already successfully completed it.", "Operation Failed To Continue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Business_Layer.TestAppointment testAppointment = Business_Layer.TestAppointment.LastAppointmentForLocalDL(LDLApplicationID, TestTypeID);
            if (testAppointment != null && !testAppointment.isLocked)
            {
                MessageBox.Show("The client currently has an active appointment scheduled for this test.", "Operation Failed To Continue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int TrialsNumber = Convert.ToInt32(L_RecordsLength.Text);
            TakeTestSchedule_Form takeTestSchedule_Form = new TakeTestSchedule_Form(LDLApplicationID, TrialsNumber, false, TestTypeID, PB_Title.Image);
            takeTestSchedule_Form.ShowDialog();

            LoadLDLAppData();
        }
        private void BT_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ReSchedule_ShortCut_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(DGV_AppointmentsData.CurrentRow.Cells["is Locked"].Value))
            {
                MessageBox.Show("You are not able to Reschedule this appointment anymore, since it has already taken By the client!!", "Appointment Closed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int TrialsNumber = Convert.ToInt32(L_RecordsLength.Text);
            TakeTestSchedule_Form takeTestSchedule_Form = new TakeTestSchedule_Form(LDLApplicationID, TrialsNumber, true, TestTypeID, PB_Title.Image);
            takeTestSchedule_Form.Text = "ReSchedule Test Date";
            takeTestSchedule_Form.ShowDialog();

            LoadLDLAppData();
        }
        private void TakeTest_ShortCut_Click(object sender, EventArgs e)
        {
            if (Convert.ToBoolean(DGV_AppointmentsData.CurrentRow.Cells["is Locked"].Value))
            {
                MessageBox.Show("This Test Appointment has already taken By the client!!", "Appointment Closed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TestResult_Form testResult_Form = new TestResult_Form(LDLApplicationID, Convert.ToInt32(L_RecordsLength.Text), TestTypeID);
            testResult_Form.ShowDialog();

            LoadLDLAppData();
        }

        private void CMS_AppointmentsShorcut_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(DGV_AppointmentsData.CurrentRow == null || DGV_AppointmentsData.CurrentRow.IsNewRow)
                e.Cancel = true;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class TestAppointment
    {
        public int TestAppointmentID { get; set; }
        public TestType TestType { get; set; }
        public LocalDrivingLicenseApplication LocalDrivingLicenseApplication { get; set; }
        public DateTime AppointmentDate { get; set; }
        public double PaidFees { get; set; }
        public User CreatedByUser { get; set; }
        public bool isLocked { get; set; }

        public TestAppointment()
        {
            TestAppointmentID = -1;
            TestType = null;
            LocalDrivingLicenseApplication = null;
            AppointmentDate = DateTime.MinValue;
            PaidFees = 0;
            CreatedByUser = null;
            isLocked = false;
        }
        private TestAppointment(int testAppointmentID, int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate, double paidFees, int createdByUserID, bool isLocked)
        {
            TestAppointmentID = testAppointmentID;
            TestType = TestType.FindTestByID(testTypeID);
            LocalDrivingLicenseApplication = LocalDrivingLicenseApplication.FindLocalDrivingLicenseApplication(localDrivingLicenseApplicationID);
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUser = User.FindUserByID(createdByUserID);
            this.isLocked = isLocked;
        }

        public bool TakeTestAppointment()
        {
            TestAppointmentID = Data_Access_Layer.TestAppointment.AddTestAppointment(TestType.TestID, LocalDrivingLicenseApplication.ID, AppointmentDate, PaidFees, CreatedByUser.UserID, isLocked);

            return TestAppointmentID != -1;
        }
        static public DataTable FindAllTestAppointments()
        {
            return Data_Access_Layer.TestAppointment.GetAllTestAppointments();
        }
        static public DataTable FindAllApointmentsForLocalDrivingLicenseID(int LDLAppID, int TestTypeID)
        {
            return Data_Access_Layer.TestAppointment.GetAllTestAppointmentsForLDL(LDLAppID, TestTypeID);   
        }
        static public int numberOfLockedAppointments(int LDLA_ID,  int TestTypeID)
        {
            return Data_Access_Layer.TestAppointment.GetAllTestAppointmentsForLDL(LDLA_ID, TestTypeID, true).Rows.Count;
        }
        static public TestAppointment FindTestAppointment(int id)
        {
            int TestAppointmentID = id, TestTypeID = -1, LDLAppID = -1, CreatedByUserID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            double PaidFees = 0;
            bool isLocked = false;

            if(Data_Access_Layer.TestAppointment.GetTestAppointment(ref  TestAppointmentID, ref TestTypeID, ref  LDLAppID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref isLocked))
                return new TestAppointment(TestAppointmentID, TestTypeID, LDLAppID, AppointmentDate, PaidFees, CreatedByUserID, isLocked);

            return null;
        }
        static public TestAppointment LastAppointmentForLocalDL(int lDLAppID, int testTypeID)
        {
            int TestAppointmentID = -1, TestTypeID = testTypeID, LDLAppID = lDLAppID, CreatedByUserID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            double PaidFees = 0;
            bool isLocked = false;

            if (Data_Access_Layer.TestAppointment.GetLatestAppointment(ref TestAppointmentID, ref LDLAppID, ref TestTypeID, ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref isLocked))
                return new TestAppointment(TestAppointmentID, TestTypeID, LDLAppID, AppointmentDate, PaidFees, CreatedByUserID, isLocked);

            return null;
        }
        static public bool LockAnAppointment(int AppointmentID)
        {
            return Data_Access_Layer.TestAppointment.UpdateAppointment(AppointmentID, DateTime.MinValue, true) != 0;
        }
        static public bool EditAppointmentDate(int AppointmentID, DateTime AppointmentDate)
        {
            return Data_Access_Layer.TestAppointment.UpdateAppointment(AppointmentID, AppointmentDate, false) != 0;
        }
    }
}

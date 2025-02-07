using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Layer
{
    public class Test
    {
        public int TestID { get; set; }
        public TestAppointment Appointment { get; set; }
        public bool TestResult { get; set; }
        public string Notes { get; set; }
        public User CreatedByUser { get; set; }

        public Test()
        {
            TestID = -1;
            Appointment = new TestAppointment();
            TestResult = false;
            Notes = string.Empty;
            CreatedByUser = new User();
        }
        private Test(int testID, int appointmentID, bool testResult, string notes, int createdByUserID)
        {
            TestID = testID;
            Appointment = TestAppointment.FindTestAppointment(appointmentID);
            TestResult = testResult;
            Notes = notes;
            CreatedByUser = User.FindUserByID(createdByUserID);
        }
    
        static public int PassedTestsForApplication(int LDLApplicationID)
        {
            return Data_Access_Layer.Test.PassedTestsForAppliation(LDLApplicationID);
        }
        static public Test FindTest(int testID)
        {
            int TestID = testID, AppointmentID = -1, CreatedByUserID = -1;
            bool TestResult = false;
            string Notes = string.Empty;

            if (Data_Access_Layer.Test.GetTest(ref TestID, ref AppointmentID, ref TestResult, ref Notes, ref CreatedByUserID))
                return new Test(TestID, AppointmentID, TestResult, Notes, CreatedByUserID);

            return null;
        }
        public bool SaveTest()
        {
            TestID = Data_Access_Layer.Test.AddTestData(Appointment.TestAppointmentID, TestResult, Notes, CreatedByUser.UserID);

            return TestID != -1;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Test
    {
        static public int AddTestData(int AppointmentID, bool TestResult, string Notes, int CreatedByUserID)
        {
            int CurrentID = -1;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"INSERT INTO Tests
                             VALUES
                             (@AppointmentID, @TestResult, @Notes, @CreatedByUserID)

                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@AppointmentID", AppointmentID);
            cmd.Parameters.AddWithValue("@TestResult", TestResult);
            if(Notes == string.Empty) cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
            else cmd.Parameters.AddWithValue("@Notes", Notes);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);

            try
            {
                connection.Open();
                object res = cmd.ExecuteScalar();

                if (res != null && int.TryParse(res.ToString(), out int id)) CurrentID = id;
            }
            catch { }
            finally { connection.Close(); }

            return CurrentID;
        }
        static public int PassedTestsForAppliation(int LDLApplicationID)
        {
            int TestsNumber = 0;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT count(*)
                             FROM   TestAppointments
                             JOIN   Tests ON Tests.TestAppointmentID = TestAppointments.TestAppointmentID
                             WHERE  TestAppointments.LocalDrivingLicenseApplicationID = @LDLApplicationID
                             AND    Tests.TestResult = 1";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);

            try
            {
                connection.Open();
                object res = cmd.ExecuteScalar();

                if(res != null && int.TryParse(res.ToString(), out int nums)) TestsNumber = nums;
            }
            catch { }
            finally { connection.Close(); }

            return TestsNumber;
        }
        static public bool GetTest(ref int TestID, ref int AppointmentID, ref bool TestResult, ref string Notes, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT *
                             FROM   Tests
                             WHERE  Tests.TestID = @TestID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    TestID = reader.GetInt32(0);
                    AppointmentID = reader.GetInt32(1);
                    TestResult = reader.GetBoolean(2);
                    Notes = reader.GetString(3);
                    CreatedByUserID = reader.GetInt32(4);
                }
            }
            catch { }
            finally { connection.Close(); }

            return isFound;
        }
    }
}

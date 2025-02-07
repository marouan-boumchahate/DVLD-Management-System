using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class TestAppointment
    {
        static public int AddTestAppointment(int testTypeID, int localDrivingLicenseApplicationID, DateTime appointmentDate, double paidFees, int createdByUserID, bool isLocked)
        {
            int CurrentID = -1;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"INSERT INTO TestAppointments
                             VALUES
                             (@testTypeID, @localDrivingLicenseApplicationID, @appointmentDate, @paidFees, @createdByUserID, @isLocked)

                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@isLocked", isLocked);
            cmd.Parameters.AddWithValue("@localDrivingLicenseApplicationID", localDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@testTypeID", testTypeID);
            cmd.Parameters.AddWithValue("@appointmentDate", appointmentDate);
            cmd.Parameters.AddWithValue("@paidFees", paidFees);
            cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);

            try
            {
                con.Open();
                object res = cmd.ExecuteScalar();

                if (int.TryParse(res.ToString(), out int id)) CurrentID = id;
            }
            catch { }
            finally { con.Close(); }

            return CurrentID;
        }
        static public DataTable GetAllTestAppointments()
        {
            DataTable Appointments = new DataTable();

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM TestAppointments";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) Appointments.Load(reader);
            }
            catch { }
            finally { connection.Close(); }

            return Appointments;
        }
        static public DataTable GetAllTestAppointmentsForLDL(int LocalDrivingLicenseAppID, int TestTypeID, bool onlyLocked = false)
        {
            DataTable Appointments = new DataTable();

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT TestAppointmentID as ""Appointment ID"", AppointmentDate as ""Appointment Date"",
                                    PaidFees as ""Paid Fees"", IsLocked as ""is Locked""
                             FROM TestAppointments
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseAppID AND TestTypeID = @TestTypeID";

            if (onlyLocked) query += @" AND IsLocked = 1";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseAppID", LocalDrivingLicenseAppID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) Appointments.Load(reader);
            }
            catch { }
            finally { connection.Close(); }

            return Appointments;
        }
        static public bool GetLatestAppointment(ref int TestAppointment, ref int LocalDrivingLicenseAppID, ref int TestTypeID, ref DateTime AppointmentDate, ref double PaidFees, ref int CreatedByUserID, ref bool isLocked)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT *
                             FROM TestAppointments
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseAppID AND TestTypeID = @TestTypeID AND IsLocked = 0";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseAppID", LocalDrivingLicenseAppID);
            cmd.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    TestAppointment = reader.GetInt32(0);
                    TestTypeID = reader.GetInt32(1);
                    LocalDrivingLicenseAppID = reader.GetInt32(2);
                    AppointmentDate = reader.GetDateTime(3);
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    CreatedByUserID = reader.GetInt32(5);
                    isLocked = reader.GetBoolean(6);

                    isFound = true;
                }
            }
            catch { }
            finally { connection.Close(); }

            return isFound;
        }
        static public bool GetTestAppointment(ref int testAppointmentID, ref int localDrivingLicenseApplicationID, ref int testTypeID,ref DateTime appointmentDate, ref double paidFees, ref int createdByUserID, ref bool isLocked)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM TestAppointments
                             WHERE TestAppointmentID = @testAppointmentID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);
            
            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    testAppointmentID = Convert.ToInt32(reader["TestAppointmentID"]);
                    testTypeID = Convert.ToInt32(reader["TestTypeID"]);
                    localDrivingLicenseApplicationID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                    createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    appointmentDate = Convert.ToDateTime(reader["AppointmentDate"]);
                    paidFees = Convert.ToDouble(reader["PaidFees"]);
                    isLocked = Convert.ToBoolean(reader["IsLocked"]);
                }
            }
            catch { }
            finally { connection.Close(); }

            return isFound;
        }
    
        static public int UpdateAppointment(int testAppointmentID, DateTime AppointmentDate, bool isLocked)
        {
            int affectedRows = 0;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"UPDATE TestAppointments
                             SET IsLocked = @isLocked";

            if (AppointmentDate != DateTime.MinValue) query += @", AppointmentDate = @AppointmentDate";
            
            query += @"
                       WHERE TestAppointmentID = @testAppointmentID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@testAppointmentID", testAppointmentID);
            if(AppointmentDate != DateTime.MinValue) cmd.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            cmd.Parameters.AddWithValue("@isLocked", isLocked);

            try
            {
                connection.Open();
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }

            return affectedRows;
        }
    }
}

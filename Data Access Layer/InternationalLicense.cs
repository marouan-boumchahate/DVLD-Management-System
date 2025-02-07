using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Data_Access_Layer
{
    public class InternationalLicense
    {
        static public bool GetInternationalLicense(ref int internationalLicenseID, ref int applicationID, ref int driverID, ref int issuedUsingLocalLicenseID, ref DateTime issueDate, ref DateTime expirationDate, ref bool isActive, ref int createdByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM InternationalLicenses WHERE InternationalLicenseID = @internationalLicenseID or ApplicationID = @applicationID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@internationalLicenseID", internationalLicenseID);
            command.Parameters.AddWithValue("@applicationID", applicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    internationalLicenseID = Convert.ToInt32(reader["InternationalLicenseID"]);
                    applicationID = Convert.ToInt32(reader["ApplicationID"]);
                    driverID = Convert.ToInt32(reader["DriverID"]);
                    issuedUsingLocalLicenseID = Convert.ToInt32(reader["IssuedUsingLocalLicenseID"]);
                    issueDate = Convert.ToDateTime(reader["IssueDate"]);
                    expirationDate = Convert.ToDateTime(reader["ExpirationDate"]);
                    isActive = Convert.ToBoolean(reader["isActive"]);
                    createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                }
            }
            catch { }
            finally {connection.Close();}   

            return isFound;
        }

        static public DataTable GetInternationalLicenses()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT internationalLicenseID as ""International License ID"", ApplicationID as ""Application ID"", DriverID as ""Driver ID"", IssuedUsingLocalLicenseID as ""Local License ID"",
                             CAST(IssueDate AS DATE) as ""Issue Date"", CAST(ExpirationDate AS DATE) as ""Expiration Date"",
                             CASE
                                 WHEN IsActive = 1 THEN 'Yes'
                                 ELSE 'No'
                             END as ""is Active""
                             FROM InternationalLicenses";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.HasRows) dataTable.Load(reader);
            }
            catch { }
            finally { connection.Close(); }

            return dataTable;
        }

        static public DataTable GetInternationalLicensesForPerson(int PersonID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT internationalLicenseID as ""International License ID"", ApplicationID as ""Application ID"", IssuedUsingLocalLicenseID as ""Local License ID"",
                             CAST(IssueDate AS DATE) as ""Issue Date"", CAST(ExpirationDate AS DATE) as ""Expiration Date"", IsActive as ""is Active""
                             FROM InternationalLicenses
                             JOIN Drivers ON Drivers.DriverID = InternationalLicenses.DriverID
                             WHERE Drivers.PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) dataTable.Load(reader);
            }
            catch { }
            finally { connection.Close(); }

            return dataTable;
        }
        static public bool isInternationalLicenseForDriverExist(int DriverID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM InternationalLicenses WHERE DriverID = @DriverID and IsActive = 1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read()) isFound = true;
            }
            catch { }
            finally { connection.Close(); }

            return isFound;
        }

        static public int AddNewInternationalDrivingLicense(int applicationID, int driverID, int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            int CurrentID = -1;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"INSERT INTO InternationalLicenses
                             VALUES
                             (@applicationID, @driverID, @issuedUsingLocalLicenseID, @issueDate, @expirationDate, @isActive, @createdByUserID)
                             
                             SELECT SCOPE_IDENTITY()";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@applicationID", applicationID);
            command.Parameters.AddWithValue("@driverID", driverID);
            command.Parameters.AddWithValue("@issuedUsingLocalLicenseID", issuedUsingLocalLicenseID);
            command.Parameters.AddWithValue("@issueDate", issueDate);
            command.Parameters.AddWithValue("@expirationDate", expirationDate);
            command.Parameters.AddWithValue("@isActive", isActive);
            command.Parameters.AddWithValue("@createdByUserID", createdByUserID);

            try
            {
                connection.Open();
                object res = command.ExecuteScalar();

                if(res != null && int.TryParse(res.ToString(), out int id)) CurrentID = id;
            }
            catch { }
            finally { connection.Close(); }

            return CurrentID;
        }

        static public int UpdateInternationLicense(int internationalLicenseID, bool isActive)
        {
            int affectedRows = 0;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"UPDATE InternationalLicenses
                             SET IsActive = @isActive

                             WHERE InternationalLicenseID = @internationalLicenseID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@internationalLicenseID", internationalLicenseID);
            command.Parameters.AddWithValue("@isActive", isActive);

            try
            {
                connection.Open();
                affectedRows = command.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }

            return affectedRows;
        }
    }
}

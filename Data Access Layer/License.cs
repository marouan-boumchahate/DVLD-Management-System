using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class License
    {
        public enum enLicenseActivity { Active, inActive, noMatter};
        static public bool GetLicenseData(ref int LicenseID, ref int ApplicationID, ref int DriverID, ref int LicenseClassID,
                                          ref DateTime IssueDate, ref DateTime ExpirationDate, ref string Notes, ref double PaidFees,
                                          ref int IssueReason, ref int CreatedByUserID, ref bool isActive)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM Licenses
                             WHERE LicenseID = @LicenseID or (ApplicationID = @ApplicationID AND LicenseClass = @LicenseClassID) or (DriverID = @DriverID AND isActive = 1)";


            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    LicenseID = reader.GetInt32(0);
                    ApplicationID = reader.GetInt32(1);
                    DriverID = reader.GetInt32(2);
                    LicenseClassID = reader.GetInt32(3);
                    IssueDate = reader.GetDateTime(4);
                    ExpirationDate = reader.GetDateTime(5);
                    Notes = reader["Notes"] == DBNull.Value ? "" : reader.GetString(6);
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    isActive = reader.GetBoolean(8);
                    IssueReason = reader.GetByte(9);
                    CreatedByUserID = reader.GetInt32(10);

                    isFound = true;
                }
            }
            catch { }
            finally { connection.Close(); }

            return isFound;
        }

        static public DataTable GetLicensesForPerson(int PersonID)
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT LicenseID as ""License ID"", ApplicationID as ""Application ID"", LicenseClasses.ClassName as ""Class Name"", CAST(IssueDate AS DATE) as ""Issue Date"", CAST(ExpirationDate AS DATE) as ""Expiration Date"", IsActive as ""is Active""
                             FROM Licenses
                             JOIN Drivers ON Drivers.DriverID = Licenses.DriverID
                             JOIN LicenseClasses ON LicenseClasses.LicenseClassID = Licenses.LicenseClass
                             WHERE Drivers.PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@PersonID", PersonID);

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

        static public bool isLicenseExistForApplication(int ApplicationID, int LicenseClass)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM Licenses
                             WHERE ApplicationID = @ApplicationID AND LicenseClass = @LicenseClass AND isActive = 1";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LicenseClass", LicenseClass);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

        static public int AddNewLicense(int applicationID, int driverID, int licenseClassID,
                                        DateTime issueDate, DateTime expirationDate, string notes, double paidFees,
                                        int issueReason, int createdByUserID, bool isActive)
        {
            int CurrentID = -1;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"INSERT INTO Licenses
                             VALUES
                             (@applicationID, @driverID, @licenseClassID, @issueDate, @expirationDate, @notes, @paidFees, @isActive, @issueReason, @createdByUserID)
                             
                             SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@applicationID", applicationID);
            cmd.Parameters.AddWithValue("@driverID", driverID);
            cmd.Parameters.AddWithValue("@licenseClassID", licenseClassID);
            cmd.Parameters.AddWithValue("@issueDate", issueDate);
            cmd.Parameters.AddWithValue("@expirationDate", expirationDate);

            if(notes != "") cmd.Parameters.AddWithValue("@notes", notes);
            else cmd.Parameters.AddWithValue("@notes", DBNull.Value);

            cmd.Parameters.AddWithValue("@paidFees", paidFees);
            cmd.Parameters.AddWithValue("@issueReason", issueReason);
            cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);
            cmd.Parameters.AddWithValue("@isActive", isActive);

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


        static public int EditLicense(int LicenseID, bool isActive)
        {
            int affectedRows = 0;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"UPDATE Licenses
                             SET IsActive = @isActive

                             WHERE LicenseID = @LicenseID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@LicenseID", LicenseID);
            cmd.Parameters.AddWithValue("@isActive", isActive);

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

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class DetainedLicense
    {
        static public bool GetDetainLicense(ref int detainID, ref int licenseID, ref DateTime detainDate, ref double fineFees, ref int createdByUserID, ref bool isReleased, ref DateTime releaseDate, ref int releasedByUserID, ref int releaseApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM DetainedLicenses
                             WHERE (DetainID = @detainID or LicenseID = @licenseID or ReleaseApplicationID = @releaseApplicationID) AND IsReleased = 0";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@detainID", detainID);
            cmd.Parameters.AddWithValue("@licenseID", licenseID);
            cmd.Parameters.AddWithValue("@releaseApplicationID", releaseApplicationID);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    detainID = Convert.ToInt32(reader["DetainID"]);
                    licenseID = Convert.ToInt32(reader["LicenseID"]);
                    detainDate = Convert.ToDateTime(reader["DetainDate"]);
                    fineFees = Convert.ToDouble(reader["FineFees"]);
                    createdByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    isReleased = Convert.ToBoolean(reader["IsReleased"]);
                    releaseDate = Convert.ToDateTime(reader["ReleaseDate"]);
                    releasedByUserID = Convert.ToInt32(reader["ReleasedByUserID"]);
                    releaseApplicationID = Convert.ToInt32(reader["ReleaseApplicationID"]);
                }
            }
            catch { }
            finally {connection.Close();}

            return isFound;
        }
    
        static public int AddNewDetainLicenseRecord(int licenseID, DateTime detainDate, double fineFees, int createdByUserID, bool isReleased)
        {
            int CurrentID = -1;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"INSERT INTO DetainedLicenses
                             VALUES
                             (@licenseID, @detainDate, @fineFees, @createdByUserID, @isReleased, NULL, NULL, NULL)

                             SELECT SCOPE_IDENTITY()";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@licenseID", licenseID);
            cmd.Parameters.AddWithValue("@detainDate", detainDate);
            cmd.Parameters.AddWithValue("@fineFees", fineFees);
            cmd.Parameters.AddWithValue("@createdByUserID", createdByUserID);
            cmd.Parameters.AddWithValue("@isReleased", isReleased);

            try
            {
                connection.Open();
                object res = cmd.ExecuteScalar();

                if(res != null && int.TryParse(res.ToString(), out int id)) CurrentID = id;
            }
            catch { }
            finally { connection.Close(); }

            return CurrentID;
        }

        static public int UpdateDetainLicense(int detainID, bool isReleased, DateTime releaseDate, int releasedByUserID, int releaseApplicationID)
        {
            int affectedRows = 0;

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"UPDATE DetainedLicenses
                             SET IsReleased = @isReleased, ReleaseDate = @releaseDate, ReleasedByUserID = @releasedByUserID, ReleaseApplicationID = @releaseApplicationID

                             WHERE DetainID = @detainID";

            SqlCommand cmd = new SqlCommand(query, connection);
            cmd.Parameters.AddWithValue("@detainID", detainID);
            cmd.Parameters.AddWithValue("@isReleased", isReleased);
            cmd.Parameters.AddWithValue("@releaseDate", releaseDate);
            cmd.Parameters.AddWithValue("@releasedByUserID", releasedByUserID);
            cmd.Parameters.AddWithValue("@releaseApplicationID", releaseApplicationID);

            try
            {
                connection.Open();
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { connection.Close(); }

            return affectedRows;
        }

        static public DataTable GetAllDetainLicenses()
        {
            DataTable dataTable = new DataTable();

            SqlConnection connection = new SqlConnection(Settings.connection);

            string query = @"SELECT DetainedLicenses.DetainID as ""Detain ID"", DetainedLicenses.LicenseID as ""License ID"", CAST(DetainedLicenses.DetainDate AS DATE) as ""Detain Date"",
                             	   CASE
                                       WHEN DetainedLicenses.IsReleased = 1 THEN 'Yes'
                                       ELSE 'No'
                                   END as ""is Released"", DetainedLicenses.FineFees as ""Fine Fees"", CAST(DetainedLicenses.ReleaseDate AS DATE) as ""Release Date"", People.NationalNo as ""National No"",
                             	   People.FirstName + People.SecondName +
                             	   CASE 
                             			WHEN People.ThirdName is null THEN ''
                             			ELSE People.ThirdName
                             	   END + People.LastName as ""Full Name"", DetainedLicenses.ReleaseApplicationID as ""Application ID""
                             FROM   Applications
                             RIGHT JOIN DetainedLicenses ON Applications.ApplicationID = DetainedLicenses.ReleaseApplicationID 
                             Left JOIN Licenses ON Licenses.LicenseID = DetainedLicenses.LicenseID
                             Left JOIN Drivers ON Drivers.DriverID = Licenses.DriverID
                             Left JOIN People ON Drivers.PersonID = People.PersonID";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) dataTable.Load(reader); 
            }
            catch { }
            finally { connection.Close(); }

            return dataTable;
        }
    }
}

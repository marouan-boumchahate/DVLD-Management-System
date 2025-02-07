using System;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class LocalDrivingLicenseApplication
    {
        static public bool GetLDLApplication(int ID, ref int ApplicationID, ref int LicenseClassID)
        {
            bool isFound = false;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications
                             WHERE LocalDrivingLicenseApplicationID = @ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    ID = Convert.ToInt32(reader["LocalDrivingLicenseApplicationID"]);
                    ApplicationID = Convert.ToInt32(reader["ApplicationID"]);
                    LicenseClassID = Convert.ToInt32(reader["LicenseClassID"]);
                }
            }
            catch { }
            finally { con.Close(); }

            return isFound;
        }
        static public bool ClassAlreadyExist(int PersonID, int ClassID)
        {
            bool isFound = false;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM Applications
                             JOIN LocalDrivingLicenseApplications ON LocalDrivingLicenseApplications.ApplicationID = Applications.ApplicationID
                             WHERE Applications.ApplicantPersonID = @PersonID AND Applications.ApplicationStatus in (1,3) AND LocalDrivingLicenseApplications.LicenseClassID = @ClassID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@ClassID", ClassID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) isFound = true;
            }
            catch { }
            finally { con.Close(); }

            return isFound;
        }
        static public int AddNewLDLApplication(int ApplicationID, int LicenseClassID)
        {
            int CurrentID = -1;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"INSERT INTO LocalDrivingLicenseApplications
                             Values
                             (@ApplicationID, @LicenseClassID)

                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

            try
            {
                con.Open();
                object res = cmd.ExecuteScalar();

                if (res != null && int.TryParse(res.ToString(), out int id))
                    CurrentID = id;
            }
            catch { }
            finally { con.Close(); }


            return CurrentID;
        }

        static public DataTable GetAllLDLApplications()
        {
            DataTable LDLApps = new DataTable();

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM LocalDrivingLicenseApplications_View ORDER BY ""Application Date"" DESC";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows) LDLApps.Load(reader);
            }
            catch { }
            finally { con.Close(); }

            return LDLApps;
        }

        static public int deleteApplication(int LocalDrivingLicenseApplicationID)
        {
            int affectedRows = 0;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"DELETE LocalDrivingLicenseApplications
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);

            try
            {
                con.Open();
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { con.Close(); }


            return affectedRows;
        }

        static public int updateApplication(int LocalDrivingLicenseApplicationID, int newClassID)
        {
            int affectedRows = 0;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"UPDATE LocalDrivingLicenseApplications
                             SET LicenseClassID = @newClassID
                             WHERE LocalDrivingLicenseApplicationID = @LocalDrivingLicenseApplicationID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@LocalDrivingLicenseApplicationID", LocalDrivingLicenseApplicationID);
            cmd.Parameters.AddWithValue("@newClassID", newClassID);

            try
            {
                con.Open();
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { con.Close(); }


            return affectedRows;
        }
    }
    
}

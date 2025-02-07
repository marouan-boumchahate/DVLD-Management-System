using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Application
    {
        static public bool GetApplication(int ID, ref int PersonID, ref DateTime appDate, ref int AppTypeID, ref byte AppStatus, ref DateTime lastStatusDate, ref double PaidFees, ref int CreatedBy)
        {
            bool isFound = false;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM Applications
                             WHERE ApplicationID = @ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    isFound = true;

                    ID = Convert.ToInt32(reader["ApplicationID"]);
                    PersonID = Convert.ToInt32(reader["ApplicantPersonID"]);
                    AppTypeID = Convert.ToInt32(reader["ApplicationTypeID"]);
                    appDate = Convert.ToDateTime(reader["ApplicationDate"]);
                    AppStatus = Convert.ToByte(reader["ApplicationStatus"]);
                    lastStatusDate = Convert.ToDateTime(reader["LastStatusDate"]);
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    CreatedBy = Convert.ToInt32(reader["CreatedByUserID"]);
                }
            }
            catch { }
            finally { con.Close(); }

            return isFound;
        }
    
        static public int AddNewApplication(int PersonID, DateTime appDate, int AppTypeID, byte AppStatus, DateTime lastStatusDate, double PaidFees, int CreatedBy)
        {
            int CurrentID = -1;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"INSERT INTO Applications
                             Values
                             (@PersonID, @appDate, @AppTypeID, @AppStatus, @lastStatusDate, @PaidFees, @CreatedBy)

                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@appDate", appDate);
            cmd.Parameters.AddWithValue("@AppStatus", AppStatus);
            cmd.Parameters.AddWithValue("@AppTypeID", AppTypeID);
            cmd.Parameters.AddWithValue("@lastStatusDate", lastStatusDate);
            cmd.Parameters.AddWithValue("@PaidFees", PaidFees);
            cmd.Parameters.AddWithValue("@CreatedBy", CreatedBy);

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
    
        static public int UpdateApplication(int ApplicationID, int status, DateTime LastStatusDate)
        {
            int affectedRows = 0;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"UPDATE Applications
                             SET ApplicationStatus = @status, LastStatusDate = @LastStatusDate

                             WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            cmd.Parameters.AddWithValue("@LastStatusDate", LastStatusDate);
            cmd.Parameters.AddWithValue("@status", status);

            try
            {
                con.Open();
                affectedRows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { con.Close(); }


            return affectedRows;
        }
        static public int deleteApplication(int ApplicationID)
        {
            int affectedRows = 0;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"DELETE Applications
                             WHERE ApplicationID = @ApplicationID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ApplicationID", ApplicationID);

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

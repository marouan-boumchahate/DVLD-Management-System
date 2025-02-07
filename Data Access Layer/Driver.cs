

using System.Data.SqlClient;
using System.Data;
using System;

namespace Data_Access_Layer
{
    public class Driver
    {
        static public bool GetDriverData(ref int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isFound = false;

            SqlConnection Con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM Drivers
                             WHERE DriverID = @DriverID or PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                Con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    DriverID = Convert.ToInt32(reader["DriverID"]);
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    CreatedByUserID = Convert.ToInt32(reader["CreatedByUserID"]);
                    CreatedDate = Convert.ToDateTime(reader["CreatedDate"]);

                    isFound = true;
                }

            }
            catch { }
            finally { Con.Close(); }

            return isFound;
        }

        static public bool isDriverExist(int DriverID)
        {
            bool isFound = false;

            SqlConnection Con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM Drivers
                             WHERE DriverID = @DriverID";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                Con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) isFound = true;

            }
            catch { }
            finally { Con.Close(); }

            return isFound;
        }

        static public DataTable GetAllDrivers()
        {
            DataTable dt = new DataTable();

            SqlConnection Con = new SqlConnection(Settings.connection);

            string query = @"SELECT Drivers.DriverID as ""Driver ID"", People.PersonID as ""Person ID"", People.NationalNo as ""National No"",
                             	   People.FirstName + ' ' + People.SecondName + ' ' +
                             	   CASE
                             			WHEN People.ThirdName is null THEN ''
                             			ELSE People.ThirdName
                             	   END
                             	   + People.LastName as ""Full Name"", CAST(Drivers.CreatedDate as DATE) as ""Date"",
                             	   (Select Count(*) FROM Licenses WHERE DriverID = Drivers.DriverID and IsActive = 1) as ""Active Licenses""
                             
                             FROM Drivers
                             JOIN People ON People.PersonID = Drivers.PersonID";

            SqlCommand cmd = new SqlCommand(query, Con);

            try
            {
                Con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.HasRows) dt.Load(reader);
            }
            catch { }
            finally { Con.Close(); }

            return dt;
        }

        static public int AddNewDriver(int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            int CurrentID = -1;

            SqlConnection Con = new SqlConnection(Settings.connection);

            string query = @"INSERT INTO Drivers
                             VALUES
                             (@PersonID, @CreatedByUserID, @CreatedDate)

                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            cmd.Parameters.AddWithValue("@CreatedDate", CreatedDate);

            try
            {
                Con.Open();

                object obj = cmd.ExecuteScalar();

                if ((obj != null) && (int.TryParse(obj.ToString(), out int Res)))
                    CurrentID = Res;
            }
            catch { }
            finally { Con.Close(); }

            return CurrentID;
        }
    }
}

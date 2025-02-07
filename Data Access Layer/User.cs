using System;
using System.Data;
using System.Data.SqlClient;

namespace Data_Access_Layer
{
    public class User
    {
        static public bool GetUser(ref int UserID, ref int PersonID, ref string UserName, ref string Password, ref bool isActive)
        {
            bool isFound = false;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM Users
                             WHERE UserID = @UserID or UserName = @UserName or PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@UserId", UserID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    isFound = true;

                    UserID = Convert.ToInt32(reader["UserID"]);
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    UserName = Convert.ToString(reader["UserName"]);
                    Password = Convert.ToString(reader["Password"]);
                    isActive = Convert.ToBoolean(reader["isActive"]);
                }
            }
            catch { }
            finally {con.Close();}  

            return isFound;
        }

        static public bool isUserExist(int UserID, string UserName)
        {
            bool isFound = false;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM Users
                             WHERE UserID = @UserID or UserName = @UserName";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("UserId", UserID);
            cmd.Parameters.AddWithValue("UserName", UserName);

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

        static public DataTable GetAllUsers()
        {
            DataTable dt = new DataTable();

            SqlConnection Con = new SqlConnection(Settings.connection);

            string query = @"SELECT Users.UserID, Users.PersonID, People.FirstName + ' ' + People.SecondName + ' ' 
                             	   + 
                             	   CASE
                             			WHEN People.ThirdName is Null THEN ''
                             			ELSE People.ThirdName
                             	   END
                             	   +
                             	   ' ' + People.LastName as ""FullName"", Users.UserName, 
                             	   CASE
                             			WHEN Users.IsActive = 1 THEN 'Yes'
                             			ELSE 'No'
                             	   End as IsActive
                             FROM Users
                             JOIN People ON People.PersonID = Users.PersonID";

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

        static public int AddNewUser(int PersonID, string UserName, string Password, bool isActive)
        {
            int CurrentID = -1;

            SqlConnection Con = new SqlConnection(Settings.connection);

            string query = @"INSERT INTO Users
                             VALUES
                             (@PersonID, @UserName, @Password, @isActive)

                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@isActive", isActive);

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

        static public int UpdateUser(int UserID, string UserName, string Password, bool isActive)
        {
            int affectedRows = 0;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"UPDATE Users
                             SET UserName = @UserName, Password = @Password, isActive = @isActive

                             WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@UserName", UserName);
            cmd.Parameters.AddWithValue("@Password", Password);
            cmd.Parameters.AddWithValue("@isActive", isActive);
            cmd.Parameters.AddWithValue("@UserID", UserID);

            try
            {
                con.Open();

                affectedRows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { con.Close(); }

            return affectedRows;
        }
    
        static public int DeleteUser(int UserID)
        {
            int affectedRows = 0;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"DELETE Users
                             WHERE UserID = @UserID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@UserID", UserID);

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

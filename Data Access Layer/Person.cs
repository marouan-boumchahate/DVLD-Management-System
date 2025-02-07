using System;
using System.Data;
using System.Data.SqlClient;
using System.Net;
using System.Security.Policy;

namespace Data_Access_Layer
{
    public class Person
    {
        static public bool GetPersonData(ref int PersonID, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref string NationalNo, ref DateTime DateOfBirth, ref char Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityCountryID, ref string ImagePath)
       {
            bool isFound = false;

            SqlConnection Con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM People
                             WHERE PersonID = @PersonID or NationalNo = @NationalNo";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("PersonID", PersonID);
            cmd.Parameters.AddWithValue("NationalNo", NationalNo);

            try
            {
                Con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    PersonID = Convert.ToInt32(reader["PersonID"]);
                    NationalityCountryID = Convert.ToInt32(reader["NationalityCountryID"]);
                    FirstName = Convert.ToString(reader["FirstName"]);
                    SecondName = Convert.ToString(reader["SecondName"]);
                    ThirdName = (reader["ThirdName"] == DBNull.Value) ? "" : Convert.ToString(reader["ThirdName"]);
                    LastName = Convert.ToString(reader["LastName"]);
                    NationalNo = Convert.ToString(reader["NationalNo"]);
                    Phone = Convert.ToString(reader["Phone"]);
                    Email = (reader["Email"] == DBNull.Value) ? "" :  Convert.ToString(reader["Email"]);
                    Address = Convert.ToString(reader["Address"]);
                    ImagePath = (reader["ImagePath"] == DBNull.Value) ? "" : Convert.ToString(reader["ImagePath"]);
                    Gender = (Convert.ToBoolean(reader["Gendor"]) == true) ? 'M' : 'F';
                    DateOfBirth = Convert.ToDateTime(reader["DateOfBirth"]);

                    isFound = true;
                }

            }
            catch { }
            finally { Con.Close(); }

            return isFound;
       }

        static public bool isPersonExist(int PersonID, string NationalNo)
        {
            bool isFound = false;

            SqlConnection Con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM People
                             WHERE PersonID = @PersonID or NationalNo = @NationalNo";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("PersonID", PersonID);
            cmd.Parameters.AddWithValue("NationalNo", NationalNo);

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

        static public DataTable GetAllPeople()
        {
            DataTable dt = new DataTable();

            SqlConnection Con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM People";

            SqlCommand cmd = new SqlCommand(query, Con);

            try
            {
                Con.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.HasRows) dt.Load(reader);
            }
            catch { }
            finally { Con.Close(); }

            return dt;
        }

        static public int AddNewPerson(string FirstName, string SecondName, string ThirdName, string LastName, string NationalNo, DateTime DateOfBirth, char Gender, string Address, string Phone, string Email, int NationalityCountryID, string ImagePath)
        {
            int CurrentID = -1;

            SqlConnection Con = new SqlConnection(Settings.connection);

            string query = @"INSERT INTO People
                             VALUES
                             (@NationalNo, @FirstName, @SecondName, @ThirdName, @LastName, @DateOfBirth, @Gender, @Address, @Phone, @Email, @NationalityCountryID, @ImagePath)

                             SELECT SCOPE_IDENTITY();";

            SqlCommand cmd = new SqlCommand(query, Con);
            cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
            cmd.Parameters.AddWithValue("@FirstName", FirstName);
            cmd.Parameters.AddWithValue("@SecondName", SecondName);
            cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
            cmd.Parameters.AddWithValue("@LastName", LastName);
            cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", (Gender == 'F') ? false : true);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);

            if (Email == "") cmd.Parameters.AddWithValue("@Email", DBNull.Value);
            else cmd.Parameters.AddWithValue("@Email", Email);

            cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityCountryID);
            
            if (ImagePath == "") cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);
            else cmd.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                Con.Open();

                object obj = cmd.ExecuteScalar();

                if((obj != null) && (int.TryParse(obj.ToString(), out int Res)))
                    CurrentID = Res;
            }
            catch { }
            finally { Con.Close(); }

            return CurrentID;
        }
    
        static public int UpdatePerson(int PersonID, string Address, string Phone, string Email, string ImagePath)
        {
            int affectedRows = 0;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"UPDATE People
                             SET Address = @Address, Phone = @Phone, Email = @Email, ImagePath = @ImagePath

                             WHERE PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Address", Address);
            cmd.Parameters.AddWithValue("@Phone", Phone);

            if(!string.IsNullOrEmpty(Email)) cmd.Parameters.AddWithValue("@Email", Email);
            else cmd.Parameters.AddWithValue("@Email", DBNull.Value);

            if(!string.IsNullOrEmpty(ImagePath)) cmd.Parameters.AddWithValue("@ImagePath", ImagePath);
            else cmd.Parameters.AddWithValue("@ImagePath", DBNull.Value);

            cmd.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                con.Open();

                affectedRows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { con.Close(); }

            return affectedRows;
        }

        static public int DeletePerson(int PersonID)
        {
            int affectedRows = 0;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"DELETE People

                             WHERE PersonID = @PersonID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@PersonID", PersonID);

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

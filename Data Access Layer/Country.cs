using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class Country
    {
        static public Dictionary<string, int> GetAllCountries()
        {
            Dictionary<string, int> Countries = new Dictionary<string, int>();

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM Countries";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Countries[reader["CountryName"].ToString()] = Convert.ToInt16(reader["CountryID"]);
                }
            }
            catch { }
            finally { con.Close(); }

            return Countries;
        }

        static public bool GetCountry(ref int ID, ref string Name)
        {
            bool isFound = false;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM Countries
                             WHERE CountryID = @ID or CountryName = @Name";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Name", Name);

            try
            {
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if(reader.Read())
                {
                    ID = Convert.ToInt32(reader["CountryID"]);
                    Name = reader["CountryName"].ToString();

                    isFound = true;
                }
            }
            catch { }
            finally { con.Close(); }

            return isFound;
        }
    }
}

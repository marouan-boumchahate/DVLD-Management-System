using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class LicenseClass
    {
        static public DataTable GetAllLicenseClasses()
        {
            DataTable LicenseClasses = new DataTable();

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM LicenseClasses";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) LicenseClasses.Load(reader);
            }
            catch { }
            finally { con.Close(); }


            return LicenseClasses;
        }

        static public bool GetLicenseClass(ref int ID, ref string Name, ref string Des, ref int MinAge, ref int length, ref double Fees)
        {
            bool isFound = false;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM LicenseClasses
                             WHERE LicenseClassID = @ID or ClassName = @Name";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Name", Name);

            try
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    ID = Convert.ToInt32(reader["LicenseClassID"]);
                    Name = reader["ClassName"].ToString();
                    Des = reader["ClassDescription"].ToString();
                    MinAge = Convert.ToInt16(reader["MinimumAllowedAge"]);
                    length = Convert.ToInt16(reader["DefaultValidityLength"]);
                    Fees = Convert.ToDouble(reader["ClassFees"]);
                }
            }
            catch { }
            finally { con.Close(); }


            return isFound;
        }
    }
}

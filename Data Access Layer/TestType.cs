using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class TestType
    {
        static public DataTable GetAllTestTypes()
        {
            DataTable TestTypes = new DataTable();

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM TestTypes";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) TestTypes.Load(reader);
            }
            catch { }
            finally { con.Close(); }


            return TestTypes;
        }

        static public bool GetTestType(int ID, ref string Title, ref string Des, ref double Fees)
        {
            bool isFound = false;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM TestTypes
                             WHERE TestTypeID = @ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    Title = reader["TestTypeTitle"].ToString();
                    Des = reader["TestTypeDescription"].ToString();
                    Fees = Convert.ToDouble(reader["TestTypeFees"]);
                }
            }
            catch { }
            finally { con.Close(); }


            return isFound;
        }

        static public int UpdateTestType(int ID, string Title, string Des, double Fees)
        {
            int AffectedRows = 0;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"UPDATE TestTypes
                             SET TestTypeTitle = @Title, TestTypeDescription = @Des, TestTypeFees = @Fees
                             WHERE TestTypeID = @ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Title", Title);
            cmd.Parameters.AddWithValue("@Des", Des);
            cmd.Parameters.AddWithValue("@Fees", Fees);

            try
            {
                con.Open();

                AffectedRows = cmd.ExecuteNonQuery();
            }
            catch { }
            finally { con.Close(); }


            return AffectedRows;
        }
    }
}

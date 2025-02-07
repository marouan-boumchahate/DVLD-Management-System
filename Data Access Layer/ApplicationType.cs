using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Access_Layer
{
    public class ApplicationType
    {
        static public DataTable GetAllApplicationTypes()
        {
            DataTable AppTypes = new DataTable();

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM ApplicationTypes";

            SqlCommand cmd = new SqlCommand(query, con);

            try
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows) AppTypes.Load(reader);
            }
            catch { }
            finally {con.Close();}


            return AppTypes;
        }

        static public bool GetApplicationType(int ID, ref string Title, ref double Fees)
        {
            bool isFound = false;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"SELECT * FROM ApplicationTypes
                             WHERE ApplicationTypeID = @ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);

            try
            {
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    isFound = true;

                    Title = reader["ApplicationTypeTitle"].ToString();
                    Fees = Convert.ToDouble(reader["ApplicationFees"]);
                }
            }
            catch { }
            finally { con.Close(); }


            return isFound;
        }

        static public int UpdateApplicationType(int ID, string Title, double Fees)
        {
            int AffectedRows = 0;

            SqlConnection con = new SqlConnection(Settings.connection);

            string query = @"UPDATE ApplicationTypes
                             SET ApplicationTypeTitle = @Title, ApplicationFees = @Fees
                             WHERE ApplicationTypeID = @ID";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@Title", Title);
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

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Sessional2_Q3
{
    public class ProductDAL
    {
        private readonly string connectionString;

        public ProductDAL()
        {
            // Fetch connection string from Web.config
            connectionString = ConfigurationManager.ConnectionStrings["ProductDbConnectionString"].ConnectionString;
        }

        public DataTable GetAllProducts()
        {
            DataTable dt = new DataTable();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT P_Id, P_Name, P_Cost FROM Product";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public void InsertProduct(string name, decimal cost)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Product (P_Name, P_Cost) VALUES (@Name, @Cost)";
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Cost", cost);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
    }
}
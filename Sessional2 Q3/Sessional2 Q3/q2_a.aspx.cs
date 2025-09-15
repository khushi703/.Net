using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessional2_Q3
{
    public partial class q2_1 : System.Web.UI.Page
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["ProductDbConnectionString"].ConnectionString;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindGrid(); // Load data initially
            }
        }

        // Insert
        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO Product (P_Name, P_Cost) VALUES (@Name, @Cost)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Cost", Convert.ToDecimal(txtCost.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            BindGrid();
        }

        // Update
        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "UPDATE Product SET P_Name=@Name, P_Cost=@Cost WHERE P_Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Cost", Convert.ToDecimal(txtCost.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            BindGrid();
        }

        // Delete
        protected void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM Product WHERE P_Id=@Id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Id", Convert.ToInt32(txtId.Text));

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            BindGrid();
        }

        // Select (Read)
        protected void btnSelect_Click(object sender, EventArgs e)
        {
            BindGrid();
        }

        // Helper method: Fetch and bind to GridView using DataSet
        private void BindGrid()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM Product";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataSet ds = new DataSet();
                da.Fill(ds); // store results in DataSet (read-only)

                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }
    }
}
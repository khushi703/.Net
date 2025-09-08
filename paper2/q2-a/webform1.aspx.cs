using System;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI;

namespace WebApplication1
{
    public partial class WebForm1 : Page
    {
        string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;

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
                string query = "INSERT INTO Products (p_Name, p_Cost) VALUES (@Name, @Cost)";
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
                string query = "UPDATE Products SET p_Name=@Name, p_Cost=@Cost WHERE p_id=@Id";
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
                string query = "DELETE FROM Products WHERE p_id=@Id";
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
                string query = "SELECT * FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataSet ds = new DataSet();
                da.Fill(ds); // store results in DataSet (read-only)

                GridView1.DataSource = ds;
                GridView1.DataBind();
            }
        }
    }
}

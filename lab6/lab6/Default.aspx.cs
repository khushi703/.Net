using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace lab6
{
    public partial class Default : System.Web.UI.Page
    {
        string cs = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
            }
        }

        void LoadData()
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Students", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
        }

        protected void btnInsert_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Students (Name, Age) VALUES (@Name, @Age)", con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                con.Open();
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            // Example: Update by Id = 1
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("UPDATE Students SET Name=@Name, Age=@Age WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Name", txtName.Text);
                cmd.Parameters.AddWithValue("@Age", txtAge.Text);
                cmd.Parameters.AddWithValue("@Id", 1); // Change to selected row's Id
                con.Open();
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            // Example: Delete Id = 1
            using (SqlConnection con = new SqlConnection(cs))
            {
                SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE Id=@Id", con);
                cmd.Parameters.AddWithValue("@Id", 1); // Change to selected row's Id
                con.Open();
                cmd.ExecuteNonQuery();
            }
            LoadData();
        }
    }
}
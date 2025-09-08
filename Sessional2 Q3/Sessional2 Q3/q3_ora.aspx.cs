using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sessional2_Q3
{
    public partial class q3_ora : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            string empId = txtEmpId.Text.Trim();
            string newName = txtEmpName.Text.Trim();
            string newDesg = txtEmpDesg.Text.Trim();

            if (string.IsNullOrEmpty(empId) || string.IsNullOrEmpty(newName) || string.IsNullOrEmpty(newDesg))
            {
                lblMsg.Text = "All fields are required.";
                return;
            }

            string connString = ConfigurationManager.ConnectionStrings["dbCon"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connString))
            {
                string query = "UPDATE Employee SET Emp_Name=@EmpName, Emp_Desg=@EmpDesg WHERE Emp_Id=@EmpId";

                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    // Parameterized query prevents SQL injection
                    cmd.Parameters.AddWithValue("@EmpName", newName);
                    cmd.Parameters.AddWithValue("@EmpDesg", newDesg);
                    cmd.Parameters.AddWithValue("@EmpId", empId);

                    con.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                        lblMsg.Text = "Employee updated successfully!";
                    else
                        lblMsg.Text = "Emp_Id not found.";
                }
            }
        }
    }
}
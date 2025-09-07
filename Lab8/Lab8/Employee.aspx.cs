using System;
using System.Configuration;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab8
{
    public partial class Employee : System.Web.UI.Page
    {
        private EmployeeDataDataContext db;

        protected void Page_Load(object sender, EventArgs e)
        {
            string connString = ConfigurationManager.ConnectionStrings["CompanyDbConnectionString"].ConnectionString;
            db = new EmployeeDataDataContext(connString);

            if (!IsPostBack)
            {
                LoadEmployees();
            }
        }

        void LoadEmployees()
        {
            var employees = from emp in db.CompanyDbs
                            select emp;

            GridView1.DataSource = employees;
            GridView1.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                decimal salary = 0;
                decimal.TryParse(txtSalary.Text, out salary);

                var emp = new CompanyDb
                {
                    FirstName = txtFirstName.Text.Trim(),
                    LastName = txtLastName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Department = txtDepartment.Text.Trim(),
                    Salary = salary,
                    HireDate = DateTime.Now
                };

                db.CompanyDbs.InsertOnSubmit(emp);
                db.SubmitChanges();

                // The identity Id should now be populated
                txtId.Text = emp.Id.ToString();

                LoadEmployees();
                // Don't clear inputs after add so user can see the generated ID
            }
            catch (Exception ex)
            {
                // Add error handling
                Response.Write($"<script>alert('Error adding employee: {ex.Message}');</script>");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id)) return; // nothing selected / invalid

            var emp = db.CompanyDbs.SingleOrDefault(x => x.Id == id);
            if (emp == null) return;

            decimal salary = 0;
            decimal.TryParse(txtSalary.Text, out salary);

            emp.FirstName = txtFirstName.Text.Trim();
            emp.LastName = txtLastName.Text.Trim();
            emp.Email = txtEmail.Text.Trim();
            emp.Department = txtDepartment.Text.Trim();
            emp.Salary = salary;

            db.SubmitChanges();
            LoadEmployees();
            ClearInputs();
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtId.Text, out int id)) return;

            var emp = db.CompanyDbs.SingleOrDefault(x => x.Id == id);
            if (emp == null) return;

            db.CompanyDbs.DeleteOnSubmit(emp);
            db.SubmitChanges();
            LoadEmployees();
            ClearInputs();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (GridView1.SelectedDataKey != null)
                {
                    int id = Convert.ToInt32(GridView1.SelectedDataKey.Value);

                    // Load the employee data
                    var emp = db.CompanyDbs.SingleOrDefault(x => x.Id == id);
                    if (emp != null)
                    {
                        txtId.Text = emp.Id.ToString();
                        txtFirstName.Text = emp.FirstName ?? "";
                        txtLastName.Text = emp.LastName ?? "";
                        txtEmail.Text = emp.Email ?? "";
                        txtDepartment.Text = emp.Department ?? "";
                        txtSalary.Text = emp.Salary?.ToString() ?? "";
                    }
                }
            }
            catch (Exception ex)
            {
                Response.Write($"<script>alert('Error selecting employee: {ex.Message}');</script>");
            }
        }

        private void ClearInputs(bool exceptId = true)
        {
            if (!exceptId) txtId.Text = "";
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtDepartment.Text = "";
            txtSalary.Text = "";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q2
{
    public partial class q2c : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnChange_Click(object sender, EventArgs e)
        {
            string user = txtUsername.Text;
            string oldPass = txtOldPass.Text;
            string newPass = txtNewPass.Text;
            string confirmPass = txtConfirmPass.Text;

            if (!Regex.IsMatch(user, @"^[a-zA-Z]{1,30}$"))
            {
                lblResult.Text = "Username must be alphabetic & < 30 chars";
                return;
            }

            if (newPass == oldPass)
            {
                lblResult.Text = "New password must not be same as old";
                return;
            }

            if (!Regex.IsMatch(newPass, @"^(?=.*[A-Z])(?=.*[a-z])(?=.*\d)(?=.*[\W_]).{8,}$"))
            {
                lblResult.Text = "<span style='color:red'>Weak Password</span>";
                return;
            }

            if (newPass != confirmPass)
            {
                lblResult.Text = "Password and confirm password must match";
                return;
            }

            lblResult.Text = "<span style='color:green'>Password Changed Successfully</span>";
        }

    }
}
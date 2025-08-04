using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3
{
    public partial class q3or_b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                bltEvents.Items.Clear();
                lblEvents.Text = "Select Gender to see events.";
            }
        }

        protected void rblGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedGender = rblGender.SelectedValue;
            bltEvents.Items.Clear();

            if (selectedGender == "Male")
            {
                lblEvents.Text = "Male Sports Events:";
                List<string> maleEvents = new List<string> { "Cricket", "Football", "Hockey", "Kabaddi" };
                foreach (string evt in maleEvents)
                {
                    bltEvents.Items.Add(evt);
                }
            }
            else if (selectedGender == "Female")
            {
                lblEvents.Text = "Female Sports Events:";
                List<string> femaleEvents = new List<string> { "Badminton", "Volleyball", "Throwball", "Kho Kho" };
                foreach (string evt in femaleEvents)
                {
                    bltEvents.Items.Add(evt);
                }
            }
        }
    }
}
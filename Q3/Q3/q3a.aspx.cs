using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q3
{
    public partial class q3a : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lstNumbers.Items.Add("25");
                lstNumbers.Items.Add("12");
                lstNumbers.Items.Add("43");
                lstNumbers.Items.Add("9");
                lstNumbers.Items.Add("31");
            }
        }

        protected void btnAsc_Click(object sender, EventArgs e)
        {
            var numbers = lstNumbers.Items.Cast<ListItem>().Select(item => int.Parse(item.Text)).OrderBy(n => n).ToList();
            lstSorted.Items.Clear();
            foreach (int num in numbers)
            {
                lstSorted.Items.Add(num.ToString());
            }
        }

        protected void btnDesc_Click(object sender, EventArgs e)
        {
            var numbers = lstNumbers.Items.Cast<ListItem>().Select(item => int.Parse(item.Text)).OrderByDescending(n => n).ToList();
            lstSorted.Items.Clear();
            foreach (int num in numbers)
            {
                lstSorted.Items.Add(num.ToString());
            }
        }

    }
}
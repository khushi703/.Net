using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Q2
{
    public partial class q2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void calEvent_DayRender(object sender, DayRenderEventArgs e)
        {
            if (e.Day.Date == DateTime.Today)
            {
                e.Cell.BackColor = System.Drawing.Color.Yellow;
            }

            if (e.Day.Date == new DateTime(DateTime.Today.Year, 8, 15))
            {
                e.Cell.BackColor = System.Drawing.Color.LightGreen;
                e.Cell.ForeColor = System.Drawing.Color.Red;
                e.Cell.Font.Bold = true;
            }
        }

        protected void calEvent_SelectionChanged(object sender, EventArgs e)
        {
            DateTime selected = calEvent.SelectedDate;
            int diff = selected.DayOfWeek - DayOfWeek.Sunday;
            DateTime sunday = selected.AddDays(-diff);

            lblWeek.Text = "Week Dates: <br/>";
            for (int i = 0; i < 7; i++)
            {
                lblWeek.Text += sunday.AddDays(i).ToShortDateString() + "<br/>";
            }
        }

    }
}
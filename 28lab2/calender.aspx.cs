using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;

public partial class calender : System.Web.UI.Page
{
    List<DateTime> holidays = new List<DateTime>
    {
        new DateTime(2025, 7, 4),
        new DateTime(2025, 7, 21)
    };

    DateTime sessionalWeekStart = new DateTime(2025, 7, 1);
    DateTime examWeekStart = new DateTime(2025, 7, 8);
    DateTime externalWeekStart = new DateTime(2025, 7, 15);

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            HolidayList.Items.Clear();
            foreach (DateTime holiday in holidays)
            {
                if (holiday.Month == DateTime.Now.Month)
                {
                    HolidayList.Items.Add(holiday.ToLongDateString());
                }
            }
        }
    }

    protected void Calendar1_SelectionChanged(object sender, EventArgs e)
    {
        txtSelectedDate.Text = Calendar1.SelectedDate.ToShortDateString();
    }

    protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
    {
        DateTime current = e.Day.Date;

        // Grey out non-current month days
        if (current.Month != Calendar1.VisibleDate.Month)
        {
            e.Cell.ForeColor = System.Drawing.Color.Gray;
            e.Day.IsSelectable = false;
        }

        // Highlight weekends
        if (current.DayOfWeek == DayOfWeek.Saturday || current.DayOfWeek == DayOfWeek.Sunday)
        {
            e.Cell.BackColor = System.Drawing.Color.LightPink;
        }

        // Highlight holidays
        foreach (DateTime holiday in holidays)
        {
            if (holiday.Date == current.Date)
            {
                e.Cell.BackColor = System.Drawing.Color.LightGreen;
                e.Cell.Font.Bold = true;
            }
        }

        // Highlight sessional, exam, and external weeks
        if ((current >= sessionalWeekStart && current < sessionalWeekStart.AddDays(7)) ||
            (current >= examWeekStart && current < examWeekStart.AddDays(7)) ||
            (current >= externalWeekStart && current < externalWeekStart.AddDays(7)))
        {
            e.Cell.BackColor = System.Drawing.Color.LightBlue;
        }
    }
}

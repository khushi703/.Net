<%@ Page Language="C#" AutoEventWireup="true" CodeFile="calender.aspx.cs" Inherits="calender" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Custom Calendar</title>
    <style>
        .weekend { background-color: #FFEEEE; }
        .holiday { background-color: #D0FFD0; }
        .external-week { background-color: #D0E0FF; }
        .non-current { color: gray; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Custom Calendar</h2>
            <asp:Calendar ID="Calendar1" runat="server" 
                OnSelectionChanged="Calendar1_SelectionChanged" 
                OnDayRender="Calendar1_DayRender" />
            <br />
            Selected Date:
            <asp:TextBox ID="txtSelectedDate" runat="server" ReadOnly="true" />
            <br /><br />
            Holidays:
            <asp:BulletedList ID="HolidayList" runat="server" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q2b.aspx.cs" Inherits="Q2.q2b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Calendar ID="calEvent" runat="server"
            FirstDayOfWeek="Sunday"
            OnDayRender="calEvent_DayRender"
            SelectionMode="DayWeek" 
            OnSelectionChanged="calEvent_SelectionChanged" />
        <asp:Label ID="lblWeek" runat="server" />

    </form>
</body>
</html>

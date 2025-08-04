<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q3a.aspx.cs" Inherits="Q3.q3a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstNumbers" runat="server" SelectionMode="Multiple"></asp:ListBox>
        <br /><br />
        <asp:Button ID="btnAsc" runat="server" Text="Ascending" OnClick="btnAsc_Click" />
        <asp:Button ID="btnDesc" runat="server" Text="Descending" OnClick="btnDesc_Click" />
        <br /><br />
        <asp:ListBox ID="lstSorted" runat="server" SelectionMode="Multiple"></asp:ListBox>
    </form>
</body>
</html>

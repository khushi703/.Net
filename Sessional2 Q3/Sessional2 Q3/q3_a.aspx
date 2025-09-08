<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q3_a.aspx.cs" Inherits="Sessional2_Q3.q3_a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="lblPrompt" runat="server" Text="Enter ISBN:"></asp:Label>
        <asp:TextBox ID="txtISBN" runat="server" />
        <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" />
        <br /><br />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
        <asp:GridView ID="gvResults" runat="server" AutoGenerateColumns="true" />
    </form>
</body>
</html>

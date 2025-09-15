<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="lab9.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Login</h2>
        <asp:Label runat="server" Text="Username: " />
        <asp:TextBox ID="txtUsername" runat="server" /><br /><br />
        <asp:Label runat="server" Text="Password: " />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /><br /><br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" /><br /><br />
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
    </form>
</body>
</html>

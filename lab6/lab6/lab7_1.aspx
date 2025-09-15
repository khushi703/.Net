<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="lab7_1.aspx.cs" Inherits="lab6.lab7_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Login (Vulnerable to SQL Injection)</h2>
        <asp:Label Text="Username:" runat="server" />
        <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        <br />
        <asp:Label Text="Password:" runat="server" />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        <br />
        <asp:Label ID="lblStatus" runat="server" ForeColor="Red"></asp:Label>
    </div>
</form>
</body>
</html>

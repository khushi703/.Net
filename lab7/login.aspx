<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Login.WebForm1" %>

<!DOCTYPE html>
<html>
<head runat="server">
    <title>SQL Injection Demo</title>
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

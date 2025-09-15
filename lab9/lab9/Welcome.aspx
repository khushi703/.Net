<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Welcome.aspx.cs" Inherits="lab9.Welcome" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Welcome, <asp:Label ID="lblUser" runat="server"></asp:Label>!</h2>
        <a href="ChangePassword.aspx">Change Password</a> |
        <a href="EditProfile.aspx">Edit Profile</a> |
        <a href="Logout.aspx">Logout</a>
    </form>
</body>
</html>

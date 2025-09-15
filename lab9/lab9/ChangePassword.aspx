<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="lab9.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Change Password</h2>
        <asp:Label Text="New Password: " runat="server" />
        <asp:TextBox ID="txtNewPassword" runat="server" TextMode="Password" /><br /><br />
        <asp:Button ID="btnChange" runat="server" Text="Change" OnClick="btnChange_Click" /><br /><br />
        <asp:Label ID="lblStatus" runat="server" ForeColor="Green" />
        <br />
        <a href="Welcome.aspx">Back</a>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditProfile.aspx.cs" Inherits="lab9.EditProfile" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Edit Profile</h2>
        <asp:Label Text="Full Name: " runat="server" />
        <asp:TextBox ID="txtFullName" runat="server" /><br /><br />
        <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" /><br /><br />
        <asp:Label ID="lblStatus" runat="server" ForeColor="Green" />
        <br />
        <a href="Welcome.aspx">Back</a>
    </form>
</body>
</html>

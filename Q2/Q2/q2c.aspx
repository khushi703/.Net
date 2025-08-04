<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q2c.aspx.cs" Inherits="Q2.q2c" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Username:
            <asp:TextBox ID="txtUsername" runat="server" /><br/>
        </div>
        <div>
            Old Password:
            <asp:TextBox ID="txtOldPass" runat="server" TextMode="Password" /><br/>
        </div>
        <div>
            New Password:
            <asp:TextBox ID="txtNewPass" runat="server" TextMode="Password" /><br/>
        </div>
        <div>
            Confirm Password:
            <asp:TextBox ID="txtConfirmPass" runat="server" TextMode="Password" /><br/>
        </div>
        <div>
            Result:
            <asp:Label ID="lblResult" runat="server" /><br/>
        </div>
        <asp:Button ID="btnChange" runat="server" Text="Change Password" OnClick="btnChange_Click" />
    </form>
</body>
</html>

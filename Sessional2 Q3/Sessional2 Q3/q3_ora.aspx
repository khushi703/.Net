<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q3_ora.aspx.cs" Inherits="Sessional2_Q3.q3_ora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Update Employee Details</h2>
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red" /><br /><br />

        <asp:Label ID="lblEmpId" runat="server" Text="Enter Emp Id: " />
        <asp:TextBox ID="txtEmpId" runat="server" /><br /><br />

        <asp:Label ID="lblEmpName" runat="server" Text="New Employee Name: " />
        <asp:TextBox ID="txtEmpName" runat="server" /><br /><br />

        <asp:Label ID="lblEmpDesg" runat="server" Text="New Designation: " />
        <asp:TextBox ID="txtEmpDesg" runat="server" /><br /><br />

        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
    </form>
</body>
</html>

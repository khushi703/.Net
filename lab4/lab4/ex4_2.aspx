<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ex4_2.aspx.cs" Inherits="lab4.ex4_2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtName" runat="server" Placeholder="Name"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqName" runat="server" ControlToValidate="txtName"
            ErrorMessage="Name is required." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />

        <asp:TextBox ID="txtEmail" runat="server" Placeholder="Email"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqEmail" runat="server" ControlToValidate="txtEmail"
            ErrorMessage="Email is required." ForeColor="Red"></asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="regEmail" runat="server" ControlToValidate="txtEmail"
            ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$"
            ErrorMessage="Invalid email format." ForeColor="Red"></asp:RegularExpressionValidator>
        <br />

        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" Placeholder="Password"></asp:TextBox>
        <asp:RequiredFieldValidator ID="reqPassword" runat="server" ControlToValidate="txtPassword"
            ErrorMessage="Password is required." ForeColor="Red"></asp:RequiredFieldValidator>
        <br />

        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Please fix these errors:" />
        <br />

        <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
    </form>
</body>
</html>

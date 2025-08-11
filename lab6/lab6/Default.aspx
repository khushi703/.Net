<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="lab6.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="txtName" runat="server" Placeholder="Enter Name"></asp:TextBox>
        <asp:TextBox ID="txtAge" runat="server" Placeholder="Enter Age"></asp:TextBox>
        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <hr />
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>

    </form>
</body>
</html>

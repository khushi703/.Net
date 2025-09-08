<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="paper.WebForm2" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Management</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Products</h2>

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true"></asp:GridView>
            <br />

            <h3>Add New Product</h3>
            <asp:Label Text="Product Name:" runat="server" />
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox><br /><br />

            <asp:Label Text="Product Cost:" runat="server" />
            <asp:TextBox ID="txtCost" runat="server"></asp:TextBox><br /><br />

            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        </div>
    </form>
</body>
</html>

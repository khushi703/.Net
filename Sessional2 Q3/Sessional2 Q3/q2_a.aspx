<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q2_a.aspx.cs" Inherits="Sessional2_Q3.q2_1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Product CRUD Operations</h2>

            <asp:Label Text="Product ID:" runat="server" />
            <asp:TextBox ID="txtId" runat="server" /><br /><br />

            <asp:Label Text="Product Name:" runat="server" />
            <asp:TextBox ID="txtName" runat="server" /><br /><br />

            <asp:Label Text="Product Cost:" runat="server" />
            <asp:TextBox ID="txtCost" runat="server" /><br /><br />

            <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
            <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Button ID="btnSelect" runat="server" Text="Select" OnClick="btnSelect_Click" />
            <br /><br />

            <!-- GridView for displaying results -->
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="true" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q2_c.aspx.cs" Inherits="Sessional2_Q3.q2_c" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Product Management</title>
    <style>
        table, th, td { border: 1px solid black; border-collapse: collapse; padding:5px; }
        th { background-color: #f2f2f2; }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Product Management</h2>
        <asp:Label ID="lblMsg" runat="server" ForeColor="Red" /><br /><br />

        <table>
            <tr>
                <td>Product Name:</td>
                <td><asp:TextBox ID="txtName" runat="server" /></td>
            </tr>
            <tr>
                <td>Product Cost:</td>
                <td><asp:TextBox ID="txtCost" runat="server" /></td>
            </tr>
            <tr>
                <td>Product ID (for Update/Delete):</td>
                <td><asp:TextBox ID="txtId" runat="server" /></td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnInsert" runat="server" Text="Insert" OnClick="btnInsert_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />

        <h3>All Products</h3>
        <asp:GridView ID="GridViewProducts" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="P_Id" HeaderText="Product ID" ReadOnly="True" />
                <asp:BoundField DataField="P_Name" HeaderText="Product Name" />
                <asp:BoundField DataField="P_Cost" HeaderText="Product Cost" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>

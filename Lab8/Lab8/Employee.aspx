<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Employee.aspx.cs" Inherits="Lab8.Employee" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Employee CRUD with LINQ to SQL</h2>

        <table>
            <tr>
                <td>Id:</td>
                <td><asp:TextBox ID="txtId" runat="server" ReadOnly="true" /></td>
            </tr>
            <tr>
                <td>First Name:</td>
                <td><asp:TextBox ID="txtFirstName" runat="server" /></td>
            </tr>
            <tr>
                <td>Last Name:</td>
                <td><asp:TextBox ID="txtLastName" runat="server" /></td>
            </tr>
            <tr>
                <td>Email:</td>
                <td><asp:TextBox ID="txtEmail" runat="server" /></td>
            </tr>
            <tr>
                <td>Department:</td>
                <td><asp:TextBox ID="txtDepartment" runat="server" /></td>
            </tr>
            <tr>
                <td>Salary:</td>
                <td><asp:TextBox ID="txtSalary" runat="server" /></td>
            </tr>
        </table>
        <br />
        <asp:Button ID="btnAdd" runat="server" Text="Add Employee" OnClick="btnAdd_Click" />
        <asp:Button ID="btnUpdate" runat="server" Text="Update Employee" OnClick="btnUpdate_Click" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete Employee" OnClick="btnDelete_Click" />
        <br /><br />

        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" DataKeyNames="Id" 
            OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="ID" ReadOnly="true" />
                <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                <asp:BoundField DataField="Email" HeaderText="Email" />
                <asp:BoundField DataField="Department" HeaderText="Department" />
                <asp:BoundField DataField="Salary" HeaderText="Salary" DataFormatString="{0:C}" />
                <asp:BoundField DataField="HireDate" HeaderText="Hire Date" DataFormatString="{0:yyyy-MM-dd}" />
                <asp:CommandField ShowSelectButton="true" />
            </Columns>
        </asp:GridView>
    </form>
</body>
</html>

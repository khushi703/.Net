<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q3_b.aspx.cs" Inherits="Sessional2_Q3.q3_b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Books and Categories</h2>
        <asp:GridView ID="GridViewBooks" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="B_Id" HeaderText="Book Id" />
                <asp:BoundField DataField="B_Title" HeaderText="Title" />
                <asp:BoundField DataField="B_Author" HeaderText="Author" />
                <asp:BoundField DataField="C_Name" HeaderText="Category" />
            </Columns>
        </asp:GridView>
        <hr />
        <asp:Label ID="LabelLiteratureCount" runat="server" Font-Bold="true" /><br />
        <asp:Label ID="LabelProASPDetails" runat="server" /><br />
        <asp:Label ID="LabelTatvamasiAuthor" runat="server" /><br />
        <asp:Label ID="LabelHouselCategory" runat="server" /><br />
    </div>
    </form>
</body>
</html>

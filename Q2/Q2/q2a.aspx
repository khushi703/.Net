<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q2a.aspx.cs" Inherits="Q2.q2a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="ddlType" runat="server">
           <asp:ListItem>Hyperlink</asp:ListItem>
           <asp:ListItem>LinkButton</asp:ListItem>
           <asp:ListItem>ImageButton</asp:ListItem>
        </asp:DropDownList>

        <asp:TextBox ID="txtCount" runat="server"></asp:TextBox>
        <asp:Button ID="btnGenerate" runat="server" Text="Generate Controls" OnClick="btnGenerate_Click" />
        <br />
        <asp:PlaceHolder ID="phControls" runat="server" />

    </form>
</body>
</html>

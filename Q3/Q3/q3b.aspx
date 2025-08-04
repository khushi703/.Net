<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q3b.aspx.cs" Inherits="Q3.q3b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:FileUpload ID="file1" runat="server" />
        <asp:FileUpload ID="file2" runat="server" />
        <asp:FileUpload ID="file3" runat="server" />
        <asp:Button ID="btnUpload" runat="server" Text="Upload Files" OnClick="btnUpload_Click" />
        <asp:Label ID="lblStatus" runat="server" />
    </form>
</body>
</html>

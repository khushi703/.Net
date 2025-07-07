<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_28lab2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <script>
                function checkTextBox2Value() {
                    var tb2 = document.getElementById('<%= TextBox2.ClientID %>');
                    var divBtn = document.getElementById('<%= Button5.ClientID %>');

                    if (tb2.value === "0") {
                      tb2.style.backgroundColor = "red";
                      divBtn.disabled = true;
                    } else {
                      tb2.style.backgroundColor = "";
                      divBtn.disabled = false;
                    }
                  }
            </script>
            form
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" onkeyup="checkTextBox2Value()"></asp:TextBox >
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="+" onClick="addition"/>
            <asp:Button ID="Button3" runat="server" Text="-" onClick="subtraction" />
            <asp:Button ID="Button4" runat="server" Text="*" onClick="multiplication"/>
            <asp:Button ID="Button5" runat="server" Text="/" onClick="division"/>
   
        </div>
    </form>
</body>
</html>

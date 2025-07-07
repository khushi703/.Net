<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="_28lab2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Calculator</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <script>
                function checkTextBox2Value() {
                    var tb2 = document.getElementById('<%= TextBox2.ClientID %>');
                    var divBtn = document.getElementById('<%= ButtonDivide.ClientID %>');

                    if (tb2.value === "0") {
                        tb2.style.backgroundColor = "red";
                        divBtn.disabled = true;
                    } else {
                        tb2.style.backgroundColor = "";
                        divBtn.disabled = false;
                    }
                }
            </script>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:TextBox ID="TextBox2" runat="server" onkeyup="checkTextBox2Value()"></asp:TextBox>
            <asp:TextBox ID="TextBox3" runat="server" ReadOnly="true"></asp:TextBox>

            <asp:Button ID="ButtonAdd" runat="server" Text="+" CommandName="Calculate" CommandArgument="add" OnCommand="CalculateOperation" />
            <asp:Button ID="ButtonSubtract" runat="server" Text="-" CommandName="Calculate" CommandArgument="subtract" OnCommand="CalculateOperation" />
            <asp:Button ID="ButtonMultiply" runat="server" Text="*" CommandName="Calculate" CommandArgument="multiply" OnCommand="CalculateOperation" />
            <asp:Button ID="ButtonDivide" runat="server" Text="/" CommandName="Calculate" CommandArgument="divide" OnCommand="CalculateOperation" />
        </div>
    </form>
</body>
</html>

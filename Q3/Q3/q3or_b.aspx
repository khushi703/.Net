<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q3or_b.aspx.cs" Inherits="Q3.q3or_b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Sports Event Registration</title>
    <style>
        .header, .footer {
            background-color: #003366;
            color: white;
            text-align: center;
            padding: 10px;
        }
        .container {
            display: flex;
            justify-content: space-between;
            padding: 20px;
        }
        .left-panel, .right-panel {
            width: 45%;
            padding: 10px;
            border: 1px solid #ccc;
        }
        .right-panel {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="header">
            <h2>Sports Event Registration</h2>
        </div>

        <div class="container">
            <!-- Left Panel -->
            <div class="left-panel">
                <asp:Label ID="lblEvents" runat="server" Text="Select Gender to see events."></asp:Label><br />
                <asp:BulletedList ID="bltEvents" runat="server" />
            </div>

            <!-- Right Panel -->
            <div class="right-panel">
                <asp:Label ID="lblGender" runat="server" Text="Select Gender:"></asp:Label><br /><br />
                <asp:RadioButtonList ID="rblGender" runat="server" AutoPostBack="true" OnSelectedIndexChanged="rblGender_SelectedIndexChanged">
                    <asp:ListItem Text="Male" Value="Male" />
                    <asp:ListItem Text="Female" Value="Female" />
                </asp:RadioButtonList>
            </div>
        </div>

        <div class="footer">
            <p>&copy; 2025 Sports Event Management</p>
        </div>
    </form>
</body>
</html>

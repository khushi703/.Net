<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="q3or_a.aspx.cs" Inherits="Q3.q3or_a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Image Map - Shape Interaction</h2>

        <asp:ImageMap ID="imgMap" runat="server" ImageUrl="~/images/shapes.png" HotSpotMode="Navigate" OnClick="imgMap_Click" Width="400px" Height="200px">
            <asp:RectangleHotSpot 
                Top="150" 
                Left="20" 
                Bottom="180" 
                Right="100" 
                PostBackValue="Rectangle" 
                AlternateText="Rectangle" />
            <asp:CircleHotSpot X="300" Y="80" Radius="40" PostBackValue="Circle" AlternateText="Circle" />
            <asp:PolygonHotSpot Coordinates="100,60,120,80,100,100,80,80" PostBackValue="Diamond" AlternateText="Diamond" />
        </asp:ImageMap>

        <br /><br />
        <asp:Label ID="lblShape" runat="server" Font-Bold="true" Font-Size="Large" ForeColor="Blue" />
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="!Home Page.aspx.cs" Inherits="_Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Early Birds Co.</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 201px">
            <asp:Image ID="logo" runat="server" ImageAlign="Right" Height="100" Width="100" ImageUrl="https://cdn.discordapp.com/attachments/803986527822282783/833697634455388230/bird-logo-with-border-no-name.png" />
            <strong>Early Birds Co.</strong><br />
            Backend Home Page<br />
            <br />
            <asp:Button ID="btnCustomer" runat="server" OnClick="btnCustomer_Click" Text="Customer Management" Width="160px"/>
            <br />
            <asp:Button ID="btnOrder" runat="server" Text="Order Management" Width="160px" OnClick="btnOrder_Click" />
            <br />
            <asp:Button ID="btnStaff" runat="server" Text="Staff Management" Width="160px" OnClick="btnStaff_Click" />
            <br />
            <asp:Button ID="btnStock" runat="server" Text="Stock Management" Width="160px" OnClick="btnStock_Click" />
            <br />
            <asp:Button ID="btnShipping" runat="server" Text="Shipping Management" Width="160px" OnClick="btnShipping_Click" />
        </div>
    </form>
</body>
</html>

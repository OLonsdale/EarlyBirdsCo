<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 333px;
        }
    </style>
</head>
<body style="height: 329px">
    <form id="form1" runat="server">
        <asp:Label ID="lblItemId" runat="server" Text="Item ID " width="93px"></asp:Label>
        <asp:TextBox ID="txtItemId" runat="server"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Height="22px" Text="Find" Width="42px" OnClick="btnFind_Click" />
        <br />
        <asp:Label ID="lblItemName" runat="server" Text="Item Name" width="88px"></asp:Label>
&nbsp;<asp:TextBox ID="txtItemName" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblPrice" runat="server" Text="Price" width="93px"></asp:Label>
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblMaterial" runat="server" Text="Material" width="93px"></asp:Label>
        <asp:TextBox ID="txtMaterial" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="93px" style="margin-bottom: 0px"></asp:Label>
        <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="lblLastPurchased" runat="server" Text="Last Purchased"></asp:Label>
        <asp:TextBox ID="txtLastPurchased" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
    </form>
</body>
</html>

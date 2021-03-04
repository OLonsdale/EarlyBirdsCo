<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblOrderNum" runat="server" Text="Order Number" Width="160px"></asp:Label>
            <asp:TextBox ID="txtOrderNum" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" Width="100px" />
        </div>
        <p>
            <asp:Label ID="lblCustomerNum" runat="server" Text="Customer Number" width="160px"></asp:Label>
            <asp:TextBox ID="txtCustomerNum" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblItemNum" runat="server" Text="Item Number" width="160px"></asp:Label>
            <asp:TextBox ID="txtItemNum" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblDateFinalised" runat="server" Text="Date Finalised" width="160px"></asp:Label>
            <asp:TextBox ID="txtDateFinalised" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblStandaloneOrSet" runat="server" Text="Standalone or Set" width="160px"></asp:Label>
            <asp:TextBox ID="txtStandaloneOrSet" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblQuantity" runat="server" Text="Quantity" width="160px"></asp:Label>
            <asp:TextBox ID="txtQuantity" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="lblTotalPrice" runat="server" Text="Total Price" width="160px"></asp:Label>
            <asp:TextBox ID="txtTotalPrice" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:CheckBox ID="chkReadyForShipping" runat="server" Text="Ready For Shipping" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <asp:Button ID="btnOK" runat="server" Height="29px" OnClick="btnOK_Click" Text="OK" Width="100px" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" Width="100px" />
    </form>
</body>
</html>

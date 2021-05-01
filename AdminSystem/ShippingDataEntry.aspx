<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShippingDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 377px">
            <asp:Label ID="lblShipping" runat="server" Text="Shipping ID" width="102px"></asp:Label>
            <asp:TextBox ID="txtShippingId" runat="server" width="102px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
            <br />
            <br />
            <asp:Label ID="lblShippingType" runat="server" Text="Shipping Type" width="102px"></asp:Label>
            <asp:DropDownList ID="lstShippingType" runat="server" AutoPostBack="True" Height="19px" OnSelectedIndexChanged="lstShippingType_SelectedIndexChanged" width="109px">
                <asp:ListItem>----------</asp:ListItem>
                <asp:ListItem>Standard</asp:ListItem>
                <asp:ListItem>Express</asp:ListItem>
            </asp:DropDownList>
            <br />
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price" width="102px" Font-Italic="True"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" width="102px" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDateOfDispatch" runat="server" Text="Date of Dispatch"></asp:Label>
            <asp:TextBox ID="txtDateOfDispatch" runat="server" width="102px"></asp:TextBox>
            <asp:Label ID="lblDateOfDispatchNull" runat="server" Font-Size="Small" Text="(Leave blank if order has not been dispatched)"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblTrackingNo" runat="server" Text="Tracking No" width="102px" Font-Italic="True" Visible="False"></asp:Label>
            <asp:TextBox ID="txtTrackingNo" runat="server" ReadOnly="True" width="102px" Visible="False"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>

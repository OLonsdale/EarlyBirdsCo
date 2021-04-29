<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShippingDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 242px">
            <asp:Label ID="lblShipping" runat="server" Text="Shipping ID" width="102px"></asp:Label>
            <asp:TextBox ID="txtShippingId" runat="server" width="102px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click" />
            <br />
            <asp:Label ID="lblShippingType" runat="server" Text="Shipping Type" width="102px"></asp:Label>
            <asp:TextBox ID="txtShippingType" runat="server" width="102px"></asp:TextBox>
            <br />
            <asp:Label ID="lblPrice" runat="server" Text="Price" width="102px"></asp:Label>
            <asp:TextBox ID="txtPrice" runat="server" width="102px"></asp:TextBox>
            <br />
            <asp:Label ID="lblDateOfDispatch" runat="server" Text="Date of Dispatch"></asp:Label>
            <asp:TextBox ID="txtDateOfDispatch" runat="server" width="102px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDispatched" runat="server" Text="Dispatched" width="75px"></asp:Label>
            <asp:CheckBox ID="chkDispatched" runat="server" Text=" " width="23px" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>

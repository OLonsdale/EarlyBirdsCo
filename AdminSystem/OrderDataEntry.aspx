<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblOrderId" runat="server" style="z-index: 1; left: 12px; top: 46px; position: absolute" Text="Order Number"></asp:Label>
        <asp:Label ID="lblDateFinalised" runat="server" style="z-index: 1; left: 10px; top: 79px; position: absolute" Text="Date Finalised"></asp:Label>
        <asp:TextBox ID="txtOrderId" runat="server" style="z-index: 1; left: 147px; top: 46px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtDateFinalised" runat="server" style="z-index: 1; left: 146px; top: 77px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblItemId" runat="server" style="z-index: 1; left: 10px; top: 116px; position: absolute" Text="Item Number"></asp:Label>
        <asp:TextBox ID="txtItemId" runat="server" style="z-index: 1; left: 144px; top: 113px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblQuantity" runat="server" style="z-index: 1; left: 11px; top: 150px; position: absolute" Text="Item Quantity"></asp:Label>
        <asp:Label ID="lblTotalPrice" runat="server" style="z-index: 1; left: 13px; top: 183px; position: absolute" Text="Total Price"></asp:Label>
        <asp:CheckBox ID="chkIsEmpty" runat="server" style="z-index: 1; left: 15px; top: 224px; position: absolute" Text="Is Order Empty" />
        <asp:TextBox ID="txtQuantity" runat="server" style="z-index: 1; left: 144px; top: 151px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtTotalPrice" runat="server" style="z-index: 1; left: 142px; top: 184px; position: absolute"></asp:TextBox>
        <asp:Label ID="lblError" runat="server" style="z-index: 1; left: 13px; top: 266px; position: absolute"></asp:Label>
        <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" style="z-index: 1; left: 13px; top: 305px; position: absolute" Text="OK" />
        <asp:Button ID="btnCancel" runat="server" style="z-index: 1; top: 306px; position: absolute; left: 63px" Text="Cancel" />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:Button ID="btnFind" runat="server" CausesValidation="False" Height="37px" Text="Find" Width="68px" />
        </p>
    </form>
</body>
</html>

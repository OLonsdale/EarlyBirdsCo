<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShippingList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 560px">
            <asp:ListBox ID="lstShippingList" runat="server" Height="404px" Width="440px"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
            <br />
            <br />
            <br />
            Filter by Tracking Number:
            <asp:TextBox ID="txtFilterByTrackingNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>

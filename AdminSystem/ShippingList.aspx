<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShippingList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 616px">
            <asp:ListBox ID="lstShippingList" runat="server" Height="404px" Width="440px"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <br />
            <br />
            <br />
&nbsp;<asp:Label ID="txtFilter" runat="server" Font-Size="Larger" Text="Dispatched Status"></asp:Label>
            <br />
            <asp:Button ID="btnDispatched" runat="server" OnClick="btnDispatched_Click" Text="Dispatched Orders" height="26px" width="164px" />
            <br />
            <asp:Button ID="btnAllOrders" runat="server" height="26px" OnClick="btnAllOrders_Click" Text="All Orders" width="164px" />
            <br />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
        </div>
    </form>
</body>
</html>

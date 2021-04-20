<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StockList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            height: 569px;
        }
    </style>
</head>
<body style="height: 573px">
    <form id="form1" runat="server">
        <a href="!Home Page.aspx">
        <img alt="Home" src="https://i.imgur.com/HpX3Z3E.png" width="100" height="100" align="right"/></a>
        <div>
            <asp:ListBox ID="lstStock" runat="server" Height="399px" Width="449px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblAvailability" runat="server" Font-Bold="True" Font-Size="Large" Text="Availability"></asp:Label>
        <br />
        <asp:Button ID="btnInStock" runat="server" OnClick="btnInStock_Click" Text="In Stock" />
        <asp:Button ID="btnAllStock" runat="server" OnClick="btnAllStock_Click" Text="All Stock" />
        <br />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server" ForeColor="Red"></asp:Label>
    </form>
</body>
</html>

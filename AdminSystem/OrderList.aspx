<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ListBox ID="lstOrderList" runat="server" Height="300px" Width="400px"></asp:ListBox>
        </div>
        <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="75px" />
        <asp:Button ID="btnEdit" runat="server" OnClick="btnEdit_Click" Text="Edit" Width="75px" />
        <asp:Button ID="btnDelete" runat="server" OnClick="btnDelete_Click" Text="Delete" Width="75px" />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter a key type  "></asp:Label>
        <asp:TextBox ID="txtFilter" runat="server" Width="150px"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" Width="75px" />
        <asp:Button ID="btnClear" runat="server" OnClick="Button2_Click" Text="Clear" Width="75px" />
        <br />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>

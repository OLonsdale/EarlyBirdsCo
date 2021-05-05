<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">

        <a href="!Home Page.aspx">
            <img alt="Home" src="https://i.imgur.com/HpX3Z3E.png" width="100" height="100" align="right" />
        </a>

        <asp:ListBox ID="lstStaffList" runat="server" Height="440px" OnSelectedIndexChanged="lstStaffNumberList_SelectedIndexChanged" Width="343px"></asp:ListBox>
        <br />
        <asp:Button ID="btnView" runat="server" OnClick="btnView_Click" Text="View" UseSubmitBehavior="False" />
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" UseSubmitBehavior="False" />
        <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" UseSubmitBehavior="False" />
        <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" UseSubmitBehavior="False" />
        <asp:Button ID="btnConfirmDelete" runat="server" Text="Confirm Delete" OnClick="btnConfirmDelete_Click" Visible="False" UseSubmitBehavior="False" />
        <asp:Button ID="btnAbortDelete" runat="server" Text="Abort Delete" OnClick="btnAbortDelete_Click" Visible="False" UseSubmitBehavior="False" />
        <br />
        <asp:Label ID="lblError" runat="server"></asp:Label>

        <p>
            Filter by first name:
            <asp:TextBox ID="txtFirstNameFilter" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" TabIndex="1" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" UseSubmitBehavior="False" />
    </form>
</body>
</html>

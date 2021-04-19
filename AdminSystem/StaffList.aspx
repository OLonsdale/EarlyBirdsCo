<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <a href="http://localhost:54436/!Home%20Page.aspx">
         <img alt="Home" src="https://cdn.discordapp.com/attachments/803986527822282783/833697654658826260/bird-logo-with-name-and-five-pixel-blue-border.png"
         width=100" height="100" align="right">
      </a>
            
        <asp:ListBox ID="lstStaffList" runat="server" Height="515px" OnSelectedIndexChanged="lstStaffNumberList_SelectedIndexChanged" Width="685px"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />
            <asp:Button ID="btnConfirmDelete" runat="server" Text="Confirm Delete" OnClick="btnConfirmDelete_Click" Visible="False" />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
    
        <p>
            Filter by first name:
            <asp:TextBox ID="txtFirstNameFilter" runat="server"></asp:TextBox>
        </p>
        <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" Text="Apply" />
        <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" />
        </form>
</body>
</html>

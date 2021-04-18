<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffList.aspx.cs" Inherits="_1_List" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstStaffNumberList" runat="server" Height="515px" OnSelectedIndexChanged="lstStaffNumberList_SelectedIndexChanged" Width="685px"></asp:ListBox>
            <br />
            <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
            <br />
            <asp:Label ID="lblError" runat="server"></asp:Label>
    </form>
</body>
</html>

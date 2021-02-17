<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblCustomerId" runat="server" Text="Customer ID"></asp:Label>
            <asp:TextBox ID="txtCustomerId" runat="server"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
            <br />
            <asp:Label ID="lblName" runat="server" Text="Name" width="100px"></asp:Label>
            <asp:TextBox ID="txtName" runat="server" width="168px"></asp:TextBox>
            <br />
            <asp:Label ID="lblDateOfBirth" runat="server" Text="Date of birth" width="100px"></asp:Label>
            <asp:TextBox ID="txtDateOfBirth" runat="server" width="168px"></asp:TextBox>
            <br />
            <asp:Label ID="lblAddress" runat="server" Text="Address" width="100px"></asp:Label>
            <asp:TextBox ID="txtAddress" runat="server" width="168px"></asp:TextBox>
            <br />
            <asp:Label ID="lblEmail" runat="server" Text="Email" width="100px"></asp:Label>
            <asp:TextBox ID="txtEmail" runat="server" width="168px"></asp:TextBox>
            <br />
            <asp:CheckBox ID="chkIsMember" runat="server" Text="Membership" />
            <br />
            <asp:Label ID="lblError" runat="server" width="100px"></asp:Label>
            <br />
            <asp:Button ID="btnOk" runat="server" OnClick="btnOk_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffDataEntry.aspx.cs" Inherits="_1_DataEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Enter Staff Data</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffNumber" runat="server" Text="Staff Number" width="100px" Height="30px"></asp:Label>
        <asp:TextBox ID="txtStaffNumber" runat="server" Height="20px" Width="170px"></asp:TextBox>
        <asp:Button ID="btnFind" runat="server" Text="Find" Height="25px" OnClick="btnFind_Click" style="margin-top: 5px" Width="38px" />
        <asp:Label ID="lblStaffNumberError" runat="server" Height="30px" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblFirstName" runat="server" Text="First Name" width="100px" Height="30px"></asp:Label>
        <asp:TextBox ID="txtFirstName" runat="server" Height="20px" Width="170px"></asp:TextBox>
        <asp:Label ID="lblFirstNameError" runat="server" Height="30px" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name" width="100px" Height="30px"></asp:Label>
        <asp:TextBox ID="txtLastName" runat="server" Height="20px" Width="170px"></asp:TextBox>
        <asp:Label ID="lblLastNameError" runat="server" Height="30px" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblStartDate" runat="server" Text="Start Date" width="100px" Height="30px"></asp:Label>
        <asp:TextBox ID="txtStartDate" runat="server" Height="20px" Width="170px"></asp:TextBox>
        <asp:Label ID="lblStartDateError" runat="server" Height="30px" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblHourlyRate" runat="server" Text="Hourly Rate" width="100px" Height="30px"></asp:Label>
        <asp:TextBox ID="txtHourlyRate" runat="server" Height="20px" Width="170px"></asp:TextBox>
        <asp:Label ID="lblHourlyRateError" runat="server" Height="30px" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number" width="100px" Height="30px"></asp:Label>
        <asp:TextBox ID="txtPhoneNumber" runat="server" Height="20px" Width="170px"></asp:TextBox>
        <asp:Label ID="lblPhoneNumberError" runat="server" Height="30px" ForeColor="Red"></asp:Label>
        <br />
        <br />
        <asp:Label ID="lblIsManager" runat="server" Text="Manager" width="100px"></asp:Label>
        <asp:CheckBox ID="chkIsManager" runat="server" OnCheckedChanged="chkIsManager_CheckedChanged" />
        <br />
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
    </form>
</body>
</html>

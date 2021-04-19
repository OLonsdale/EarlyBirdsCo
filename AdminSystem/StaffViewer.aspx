<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StaffViewer.aspx.cs" Inherits="_1Viewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Test</title>
    </head>
<body>
    <form id="form2" runat="server">
        <div>
        </div>
        <asp:Label ID="lblStaffNumber" runat="server" Text="Staff Number:" width="120px" Height="20px"></asp:Label>
        <asp:Label ID="StaffNumber" runat="server" Height="20px" Text="Label" Width="300px"></asp:Label>
        <br />
        <asp:Label ID="lblFirstName" runat="server" Text="First Name:" width="120px" Height="20px"></asp:Label>
        <asp:Label ID="FirstName" runat="server" Height="20px" Text="Label" Width="300px"></asp:Label>
        <br />
        <asp:Label ID="lblLastName" runat="server" Text="Last Name:" width="120px" Height="20px"></asp:Label>
        <asp:Label ID="LastName" runat="server" Height="20px" Text="Label" Width="300px"></asp:Label>
        <br />
        <asp:Label ID="lblStartDate" runat="server" Text="Start Date:" width="120px" Height="20px"></asp:Label>
        <asp:Label ID="StartDate" runat="server" Height="20px" Text="Label" Width="300px"></asp:Label>
        <br />
        <asp:Label ID="lblHourlyRate" runat="server" Text="Hourly Rate:" width="120px" Height="20px"></asp:Label>
        <asp:Label ID="HourlyRate" runat="server" Height="20px" Text="Label" Width="300px"></asp:Label>
        <br />
        <asp:Label ID="lblPhoneNumber" runat="server" Text="Phone Number:" width="120px" Height="20px"></asp:Label>
        <asp:Label ID="PhoneNumber" runat="server" Height="20px" Text="Label" Width="300px"></asp:Label>
        <br />
        <asp:Label ID="lblIsManager" runat="server" Text="Is a Manager:" width="120px" Height="20px"></asp:Label>
        <asp:Label ID="IsManager" runat="server" Height="20px" Text="Label" Width="300px"></asp:Label>
        <br />
        <br />
        <asp:Button ID="btnOK" runat="server" Text="Back" OnClick="btnOK_Click" />
    </form>
</body>
</html>

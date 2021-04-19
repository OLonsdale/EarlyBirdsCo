<%@ Page Language="C#" AutoEventWireup="true" CodeFile="!Home Page.aspx.cs" Inherits="_Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Early Birds Co.</title>
    <style type="text/css">
        .auto-style1 {height: 867px;}
        .center{display: block; margin-left: auto; margin-right:auto; width:50%;}
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <asp:Image ID="title" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="https://i.imgur.com/h2MmLfB.png" Width="300px" class="center" />
            <asp:Image ID="logo" runat="server" ImageAlign="Middle" Height="100" Width="100" ImageUrl="https://i.imgur.com/cTFGWuM.png" class="center" />
            <br />
            <asp:ImageButton ID="btnCustomer" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="https://i.imgur.com/aT8sDWQ.png" OnClick="ImageButton1_Click" Width="300px" BorderColor="#3589DE" BorderStyle="Solid" BorderWidth="3px" class="center" />
            <br />
            <asp:ImageButton ID="btnStaff" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="https://i.imgur.com/6EDBvmj.png" OnClick="ImageButton5_Click" Width="300px" BorderColor="#3589DE" BorderStyle="Solid" BorderWidth="3px" class="center" />
            <br />
            <asp:ImageButton ID="btnOrder" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="https://i.imgur.com/ec4z8hG.png" OnClick="ImageButton2_Click" Width="300px" BorderColor="#3589DE" BorderStyle="Solid" BorderWidth="3px" class="center" />
            <br />
            <asp:ImageButton ID="btnStock" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="https://i.imgur.com/Mx3jKHp.png" OnClick="ImageButton4_Click" Width="300px" BorderColor="#3589DE" BorderStyle="Solid" BorderWidth="3px" class="center" />
            <br />
            <asp:ImageButton ID="btnShipping" runat="server" Height="100px" ImageAlign="Middle" ImageUrl="https://i.imgur.com/sx5qjk7.png" OnClick="ImageButton3_Click" Width="300px" BorderColor="#3589DE" BorderStyle="Solid" BorderWidth="3px" class="center" />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WebApp._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to Advanced C#<br />
            <asp:Label ID="lblName" runat="server" Text="Enter Name:"></asp:Label>
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnDisplay" runat="server" OnClick="btnDisplay_Click" Text="Display Message" />
            <br />
            <br />
            <asp:TextBox ID="txtDisplay" runat="server" Width="279px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSecond" runat="server" OnClick="btnSecond_Click" Text="Go To Page 2" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ATM.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitle" runat="server" Text="ATM Login" Font-Bold="True" Font-Size="Larger"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblID" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lblPassword" runat="server" Text="Password:"></asp:Label>
            <asp:TextBox ID="txtPassword" TextMode="Password" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" Text="Login" />
            <br />
            <br />
            <asp:TextBox ID="txtStatus" runat="server" ReadOnly="True" Width="382px"></asp:TextBox>
        </div>
    </form>
</body>
</html>

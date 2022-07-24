<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Deposit.aspx.cs" Inherits="ATM.Deposit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitleDeposit" runat="server" Font-Bold="True" Font-Size="Large" Text="Deposit"></asp:Label>
            <br />
            <asp:Label ID="lblCurrentBalance" runat="server" Text="Current Balance:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblDollarSign" runat="server" Font-Bold="True" Font-Size="Large" Text="$"></asp:Label>
            <asp:TextBox ID="txtBalance" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblDeposit" runat="server" Text="Deposit Amount: $"></asp:Label>
            <asp:TextBox ID="txtDeposit" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnDeposit" runat="server" OnClick="btnDeposit_Click" Text="Deposit" />
            <br />
            <br />
            <asp:TextBox ID="txtStatus" runat="server" ReadOnly="True" Width="451px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Return To Main Menu" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainMenu.aspx.cs" Inherits="ATM.MainMenu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblTitleMainMenu" runat="server" Font-Bold="True" Font-Size="Larger" Text="ATM Main Menu"></asp:Label>
            <br />
            <asp:Label ID="lblWelcome" runat="server" Text="Welcome, your current balance is:"></asp:Label>
            <br />
            <asp:Label ID="lblDollarSign" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="$"></asp:Label>
            <asp:TextBox ID="txtBalance" runat="server" Font-Size="Medium" OnTextChanged="txtBalance_TextChanged" ReadOnly="True" Width="147px"></asp:TextBox>
            <br />
            <br />
            Please select an option:<br />
            <asp:Button ID="btnWithdraw" runat="server" OnClick="btnWithdraw_Click" Text="Withdraw" />
            <br />
            <br />
            <asp:Button ID="btnDeposit" runat="server" Text="Deposit" OnClick="btnDeposit_Click" />
            <br />
            <br />
            <asp:Button ID="btnQuit" runat="server" OnClientClick="window.close(); return false;" Text="Quit" />
        </div>
        <br />
    </form>
</body>
</html>

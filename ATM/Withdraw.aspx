<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Withdraw.aspx.cs" Inherits="ATM.Withdraw" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblWithdraw" runat="server" Font-Bold="True" Font-Size="Large" Text="Withdraw"></asp:Label>
            <br />
            <asp:Label ID="lblCurrentBalance" runat="server" Text="Current Balance:"></asp:Label>
            <br />
            <br />
            <asp:Label ID="lblDollar" runat="server" Font-Bold="True" Font-Size="Large" Text="$"></asp:Label>
            <asp:TextBox ID="txtBalance" runat="server" OnTextChanged="txtBalance_TextChanged" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblAmount" runat="server" Text="Withdrawal Amount: $"></asp:Label>
            <asp:TextBox ID="txtWithdraw" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnWithdraw" runat="server" OnClick="btnWithdraw_Click" Text="Withdraw" />
            <br />
            <br />
            <asp:TextBox ID="txtStatus" runat="server" ReadOnly="True" Width="584px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnReturn" runat="server" OnClick="btnReturn_Click" Text="Return To Main Menu" />
        </div>
    </form>
</body>
</html>

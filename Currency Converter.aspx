<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Currency Converter.aspx.cs" Inherits="Currency_Converter.Currency_Converter" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Currency Converter</div>
    <table class="auto-style1">
        <tr>
            <td>Enter amount in £:</td>
            <td>
                <asp:TextBox ID="Amount" runat="server" Width="148px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>Currency Selection</td>
            <td>
                <asp:DropDownList ID="CurrencySelect" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                    <asp:ListItem Value="1">Euros</asp:ListItem>
                    <asp:ListItem Value="2">US$</asp:ListItem>
                    <asp:ListItem Value="3">AUS$</asp:ListItem>
                    <asp:ListItem Value="4">Yen</asp:ListItem>
                </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="CalcButton" runat="server" OnClick="Button1_Click" Text="Calculate" Width="94px" />
            </td>
            <td>
                <asp:Label ID="Result" runat="server" Text="Result"></asp:Label>
            </td>
        </tr>
    </table>
    </form>
    </body>
</html>

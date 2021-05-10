<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>BankCard Lab</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 214px;
        }
        .auto-style5 {
            width: 98px;
            text-align: right;
            background-color: #99CCFF;
        }
        .auto-style7 {
            width: 214px;
            text-align: left;
        }
        .auto-style8 {
            width: 98px;
        }
        .auto-style9 {
            width: 128px;
            background-color: #99CCFF;
        }
        .auto-style11 {
            width: 371px;
        }
        .auto-style12 {
            width: 128px;
        }
        .auto-style13 {
            width: 98px;
            text-align: right;
            background-color: #FFFFFF;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblCardNo" runat="server" Text="Kart Numarası"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtCardNo" runat="server" Width="195px"></asp:TextBox>
                    </td>
                    <td class="auto-style12">
                        <asp:Image ID="Image2" runat="server" Height="22px" ImageUrl="~/image/1AA.png" Width="57px" />
                        <asp:Image ID="Image1" runat="server" Height="29px" ImageUrl="~/image/card.jpg" Width="62px" />
                    </td>
                    <td class="auto-style11">
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem>Mastercard</asp:ListItem>
                            <asp:ListItem>Visa</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:Label ID="lblDigitControl" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblCCV" runat="server" Text="CCV"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:TextBox ID="txtCCV" runat="server" TextMode="Number" Width="51px"></asp:TextBox>
                        <asp:Label ID="lblCCVControl" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td class="auto-style9">
                        <asp:Label ID="lbldate" runat="server" Text="Son Kullanma Tarihi"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtMonth" runat="server" TextMode="Number" Width="40px"></asp:TextBox>
                        <asp:TextBox ID="txtYear" runat="server" TextMode="Number" Width="42px"></asp:TextBox>
                        <asp:Label ID="lblMonth" runat="server" ForeColor="Red"></asp:Label>
                        <asp:Label ID="lblYear" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblLuhnControl" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td>
                        <asp:Label ID="lblCardTypeControl" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Label ID="lblOwner" runat="server" Text="Kart Sahibi Adı"></asp:Label>
                    </td>
                    <td class="auto-style3">
                        <asp:TextBox ID="txtCardOwner" runat="server" Width="200px"></asp:TextBox>
                    </td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="lblCardOwner" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style12">
                        <asp:Button ID="btnGiris" runat="server" OnClick="btnGiris_Click" Text="Giriş" />
                    </td>
                    <td class="auto-style11">
                        <asp:Label ID="lblLogin" runat="server" ForeColor="Blue"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style12">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

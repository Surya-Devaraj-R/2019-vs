<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RadioButton.aspx.cs" Inherits="Webapps_july23.RadioButton" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
            margin-right: 0px;
        }
        .auto-style2 {
            height: 21px;
        }
        .auto-style3 {
            width: 248px;
        }
        .auto-style4 {
            height: 21px;
            width: 248px;
        }
        .auto-style5 {
            width: 248px;
            height: 23px;
        }
        .auto-style6 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style3">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server">
                        <asp:ListItem Value="Spiderman">Spidyy</asp:ListItem>
                        <asp:ListItem Value="Skull">DarkSide</asp:ListItem>
                        <asp:ListItem Value="Greymon">Agumon</asp:ListItem>
                    </asp:RadioButtonList>
                </td>
                <td>
                    <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
                        <asp:ListItem Value="Rookie">Gabumon</asp:ListItem>
                        <asp:ListItem Value="Rookie">Tentamon</asp:ListItem>
                        <asp:ListItem Value="Rookie">Impmon</asp:ListItem>
                        <asp:ListItem Value="Rookie">Gomamon</asp:ListItem>
                    </asp:ListBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Select" />
                </td>
                <td>
                    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style2">
                    <asp:Label ID="Label3" runat="server" Text="Text"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style5">
                    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:Label ID="Label4" runat="server" Text="Value"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>

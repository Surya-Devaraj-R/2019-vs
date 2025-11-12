<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Webapps_july23.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 245px;
        }
        .auto-style3 {
            width: 245px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style5 {
            width: 245px;
            height: 30px;
        }
        .auto-style6 {
            height: 30px;
        }
        .auto-style9 {
            height: 30px;
            width: 351px;
        }
        .auto-style10 {
            height: 23px;
            width: 351px;
        }
        .auto-style11 {
            width: 351px;
        }
    </style>
</head>
<body bgcolor ="Yellow">

    <form id="form1" runat="server">
        <div>
            
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label1" runat="server" Text="UserName"></asp:Label>
                    </td>
                    <td class="auto-style10">
                        <asp:TextBox ID="TextBox1" runat="server" Width="343px"></asp:TextBox>
                    </td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style2">
                        <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="TextBox2" runat="server" Width="342px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Login" />
                    </td>
                    <td class="auto-style9"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style4"></td>
                </tr>
                <tr>
                    <td class="auto-style3">
                        <asp:Label ID="Label3" runat="server" Text="Label" Visible="False"></asp:Label>
                    </td>
                    <td class="auto-style10"></td>
                    <td class="auto-style4">
                        <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Calculator.aspx">Calc</asp:HyperLink>
                    </td>

                </tr>
            </table>
            
        </div>
    </form>
</body>
</html>

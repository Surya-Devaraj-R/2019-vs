<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="ASP_ADO_Example.ChangePassword" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 293px;
        }
        .auto-style3 {
            width: 293px;
            height: 23px;
        }
        .auto-style4 {
            height: 23px;
        }
        .auto-style7 {
            width: 416px;
        }
        .auto-style8 {
            width: 293px;
            height: 24px;
        }
        .auto-style9 {
            height: 24px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Change Password</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Current Password</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" Width="262px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">New Password</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server" Width="262px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                    <td class="auto-style2">Re enter password</td>
                    <td class="auto-style7">
                        <asp:TextBox ID="TextBox3" runat="server" Width="259px"></asp:TextBox>
                </td>
                    <td>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Password not correct"></asp:CompareValidator>
                </td>
                </tr>
            <tr>
                <td class="auto-style3"></td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style8"></td>
                <td class="auto-style9"></td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Change" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Status"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>

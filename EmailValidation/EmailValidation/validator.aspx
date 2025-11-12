<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="validator.aspx.cs" Inherits="EmailValidation.validator" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Email Validation Form</title>
    <style type="text/css">
        .auto-style1 { width: 100%; }
        .auto-style2 { width: 433px; }
    </style>
    <%--<script>
        function validateInput() {
            var input = document.getElementById("email").value;
            var regex = /^[a-zA-Z0-9._-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,6}$/; // email pattern
            var errorMsg = document.getElementById("errorMsg");

            if (!regex.test(input)) {
                errorMsg.textContent = "Please enter a valid email address.";
                return false; // stops form submission
            } else {
                errorMsg.textContent = "";
                return true; // allows form submission
            }
        }
    </script>--%>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Email validation</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">EmailID</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" TextMode="Email" Width="247px"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClientClick="return validateEmailJS();" OnClick="Button1_Click" Text="Check" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div></div>
    </form>
</body>
</html>

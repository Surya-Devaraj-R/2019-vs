<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="linq1.aspx.cs" Inherits="LinqeX.linq1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        .Button1{
            border : 3px solid red;
            cursor: pointer;  
            transition: background-color 0.3s ease; 
        }
        .Button1:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="ClientApplication.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
       th, td {
            border: 1px solid black;
            border-radius: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <center>
        <div>
            <table>
                <tr>
                    <th>
                        <asp:TextBox ID="txtNumber1" runat="server"></asp:TextBox></th>
                    <th>
                        <asp:TextBox ID="txtNumber2" runat="server"></asp:TextBox></th>
                    <th>
                        <asp:TextBox ID="txtResult" runat="server"></asp:TextBox></th>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" /></td>
                    <td>
                        <asp:Button ID="btnSub" runat="server" Text="Sub" OnClick="btnSub_Click" /></td>
                    <td>
                        <asp:Button ID="btnDiv" runat="server" Text="Div" OnClick="btnDiv_Click" /></td>
                    <td>
                        <asp:Button ID="btnDivOneWay" runat="server" Text="DivOneWay" OnClick="btnDivOneWay_Click" /></td>
                </tr>
                <tr>
                    <td colspan="3">
                        <asp:Label ID="lblErrMsg" runat="server"></asp:Label></td>
                </tr>
            </table>
        </div>
            </center>
    </form>
</body>
</html>

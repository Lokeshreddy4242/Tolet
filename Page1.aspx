<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="PresentationLayer.Page1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 397px;
            font-size: x-large;
        }
        .auto-style3 {
            width: 397px;
            height: 15px;
            font-size: x-large;
        }
        .auto-style4 {
            height: 15px;
        }
        .auto-style5 {
            font-size: x-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style2"><strong>Enter Eno</strong></td>
                    <td>
                        <strong>
                        <asp:TextBox ID="txtEno" runat="server" CssClass="auto-style5"></asp:TextBox>
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2"><strong>Enter Ename</strong></td>
                    <td>
                        <strong>
                        <asp:TextBox ID="txtEname" runat="server" CssClass="auto-style5"></asp:TextBox>
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>Enter Salary</strong></td>
                    <td class="auto-style4">
                        <strong>
                        <asp:TextBox ID="txtSalary" runat="server" CssClass="auto-style5"></asp:TextBox>
                        </strong>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td>
                        <strong>
                        <asp:Button ID="btnSave" runat="server" Text="Save" CssClass="auto-style5" OnClick="btnSave_Click" />
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" />
                        </strong>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

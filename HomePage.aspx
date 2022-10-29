<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="PresentationLayer.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/HomePage.css" rel="stylesheet" />
 <style type="text/css">
        .auto-style1 {
            font-size: 220px;
           text-align:center;
            height: 518px;
            font-family: sans-serif;
        }
        .auto-style2 {
            height: 412px;
        }
        .auto-style3 {
            color: #993399;
        }
        .auto-style4 {
            color: #FFFFFF;
        }
        .imgicon{
            text-align: center;
            margin-top: -150px;
        }
        .img{
            border-radius: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style2">
        <asp:Label ID="lblSession1" runat="server"></asp:Label>
        <asp:Label ID="lblSession2" runat="server"></asp:Label>
        <div class="auto-style1">
            
            <span class="auto-style3">To-L</span><span class="auto-style4">et<br />
                </span>
            </div>
        <br />
        <div class="imgicon">
                <asp:ImageButton ID="img" runat="server" ImageUrl="~/Images/family.png"  Height="8%" Width="8%" CssClass="img" OnClick="img_Click1"  /> &nbsp;  &nbsp;
                <asp:ImageButton ID="img2" runat="server" ImageUrl="~/Images/images.png" Height="8%" Width="8%" CssClass="img" /> &nbsp; &nbsp;
                <asp:ImageButton Height="8%" Width="8%" ID="ImageButton2" ImageUrl="~/Images/download.png" runat="server" CssClass="img"></asp:ImageButton>&nbsp; &nbsp;
                <asp:ImageButton Height="8%" Width="8%" ID="ImageButton1" ImageUrl="~/Images/oyo.png" runat="server" CssClass="img" OnClick="ImageButton1_Click"  ></asp:ImageButton> 
        </div>
                                                                                                                                
    </form>
</body>
</html>

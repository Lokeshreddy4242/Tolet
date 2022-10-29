<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateAccount.aspx.cs" Inherits="PresentationLayer.CreateAccount" %>

<!DOCTYPE html>
<script src="JavaScript/CreateAccount.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/CreateAccount.css" rel="stylesheet" />
    
<style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%,-50%);
            width: 350px;
            height: 584px;
            padding: 50px 40px;
            box-sizing: border-box;
            background-color: #FF99FF;
        }
        .auto-style2 {
            font-weight: bold;
            color: #3333FF;
        }
        .auto-style3 {
            width: 100%;
            outline-width: medium;
            outline-style: none;
            outline-color: invert;
            height: 40px;
            font-size: 16px;
            border-left-style: none;
            border-left-color: inherit;
            border-left-width: medium;
            border-right-style: none;
            border-right-color: inherit;
            border-right-width: medium;
            border-top-style: none;
            border-top-color: inherit;
            border-top-width: medium;
            border-bottom: 3px solid #fff;
            margin-bottom: 20px;
            background-color: transparent;
        }
        .auto-style4 {
            font-weight: bold;
            color: #0000CC;
        }
       
        .auto-style6 {
            padding: 0;
            text-align: center;
            color: rgb(153, 51, 153);
            margin-bottom: 50px;
            margin-top: - 30px;
            margin-left: 0;
            margin-right: 0;
        }
    </style>
   </head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <%--<img src="Images/My project-1.png" alt="Alternate Text" class="user" />--%>
            <h2 class="auto-style6">Create Account</h2>
               <%-- <asp:Label ID="lblUsername" runat="server" CssClass="auto-style2"></asp:Label>--%>
                <asp:TextBox ID="txtUserName" runat="server" CssClass="auto-style3" placeholder="User Name" ></asp:TextBox>
            <asp:TextBox ID="txtEmail" runat="server" CssClass="auto-style3" placeholder="Email" ></asp:TextBox>
               <%-- <asp:Label ID="lblPassword" runat="server" CssClass="auto-style4"></asp:Label>--%>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style3" placeholder="Password" ></asp:TextBox>
             <asp:TextBox ID="txtconfirmpassword" runat="server" CssClass="auto-style3" placeholder="Confirm Password" ></asp:TextBox>
            <asp:TextBox ID="txtMobile" runat="server" CssClass="auto-style3" placeholder="Mobile" ></asp:TextBox>
                <asp:Button ID="btnSignin" runat="server" Text="Create" CssClass="btnlogin" OnClick="btnSignin_Click" OnClientClick="return userValid();"/>
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style5" NavigateUrl="~/Login.aspx" >Sign In</asp:HyperLink>
            <br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" ></asp:Label>
         </div>
    </form>
</body>
</html>

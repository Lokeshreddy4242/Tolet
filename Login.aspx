<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="PresentationLayer.Login" %>

<!DOCTYPE html>
<script src="JavaScript/CreateAccount.js"></script>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/Login.css" rel="stylesheet" />
 <style type="text/css">
        .auto-style1 {
            position: absolute;
            top: 50%;
            left: 50%;
            transform: translate(-50%,-50%);
            width: 350px;
            height: 420px;
            padding: 80px 40px;
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
            <h2 class="auto-style6">Log In Here</h2>
               <%-- <asp:Label ID="lblUsername" runat="server" CssClass="auto-style2"></asp:Label>--%>
                <asp:TextBox ID="txtUserName" runat="server" CssClass="auto-style3" placeholder="User Name" ></asp:TextBox>
               <%-- <asp:Label ID="lblPassword" runat="server" CssClass="auto-style4"></asp:Label>--%>
                <asp:TextBox ID="txtPassword" runat="server" CssClass="auto-style3" placeholder="**********" ></asp:TextBox>
                <asp:Button ID="btnSignin" runat="server" Text="Sign In" CssClass="btnlogin" OnClick="btnSignin_Click" />
                <asp:HyperLink ID="HyperLink1" runat="server" CssClass="auto-style5" NavigateUrl="~/Createaccount.aspx" >Create Account</asp:HyperLink>
                  &nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblErrorMsg" runat="server" Text="" ForeColor="Red" ></asp:Label>
              <%--  <asp:HyperLink ID="HyperLink2" runat="server" CssClass="auto-style5" >Forget Account</asp:HyperLink>--%>
            
         </div>
    </form>
           
        
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Family.aspx.cs" Inherits="PresentationLayer.Family" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
<style>
        .bgcolor
        {
            background-color:#74137a;
        }
        .box
        {
          
        }
      
        .auto-style1 {
        color: #FFFFFF;
    }
    .auto-style2 {
        color: #FFFFFF;
        font-weight: bold;
        background-color: #000066;
    }
    .auto-style3 {
        font-size: x-large;
    }
      
        .auto-style4 {
        color: #FF0000;
    }
    .auto-style5 {
        font-size: x-large;
        color: #FFFFFF;
    }
      
        .auto-style6 {
        font-size: x-large;
        color: #FF0000;
    }
      
        </style>
</head>
    <%--<center>--%>
<body>
    <form id="form1" runat="server">
        
            <div>
                <br />
                <span class="auto-style6">To-L</span><strong><span class="auto-style3"><span class="auto-style4">et</span>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </span><asp:Button ID="Button1" runat="server"  Text="Family Rooms Upload" OnClick="Button1_Click" CssClass="auto-style2" Height="40px" />
                </strong>
        </div>
        <br />
        <br />
        <center>
        <div>
             <asp:TextBox ID="txtSearch" TextMode="Search" runat="server" CssClass="auto-style5" Width="61%" Height="37px" placeholder="Search Location"></asp:TextBox>
            <asp:Button ID="btnSearch" runat="server" Text="Search" BackColor="#000066" ForeColor="White" CssClass="auto-style5" />
            </div>
        <br />
        <br />
        <div class="auto-style1">
             <asp:Repeater ID="rptDetails" runat="server" >
        <HeaderTemplate>
        <table>
          
        <tr style="background:red;font-weight:bolder">
        </tr>
        </HeaderTemplate>
        <ItemTemplate>
           
          <table>
         <tr>
              <td> <%--<asp:Image ID="lblImage" ImageUrl='<%#Eval("Image1") %>' runat="server" Height="50%" Width="24%" AlternateText="HouseImage" />--%>
                  <asp:Image ID="lblImage2" ImageUrl='<%#Eval("Image2") %>' runat="server" Height="50%" Width="33%" AlternateText="HouseImage" />
                  <asp:Image ID="Image1" ImageUrl='<%#Eval("Image3") %>' runat="server" Height="50%" Width="33%" AlternateText="HouseImage" />
                  <asp:Image ID="Image2" ImageUrl='<%#Eval("Image4") %>' runat="server" Height="50%" Width="33%" AlternateText="HouseImage" />
       
                 
              <td style="width:190px">
       
            <table class="bgcolor">
                <tr>
                    <td>
                    <b>Rent:</b>
                        </td>
                     <td><asp:Label ID="lblRent" runat="server" Text=' <%#Eval("OwnerName") %>'></asp:Label></td>
                    
               </tr>
                <tr>
                    <td>
                        <b>Name:</b>
                    </td>
                     <td><asp:Label ID="lblName" runat="server" Text=' <%#Eval("Rent") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <b>Phone Number:</b>
                    </td>
                     <td><asp:Label ID="lblPhoneNumber" runat="server" Text=' <%#Eval("PhoneNumber") %>'></asp:Label></td>
                </tr>
                <tr>
                    <td>
                        <b>Address:</b>
                    </td>
                    <td><asp:Label ID="lblAddress" runat="server" Text=' <%#Eval("Address") %>'></asp:Label></td>
                    
                </tr>
                  <td>
                     <asp:ImageButton Height="40px" Width="40px" ID="lbtBack" ImageUrl="~/Images/edit1.jpg" runat="server"  ></asp:ImageButton>
                </td>
             <%--  <td>
                    <asp:ImageButton Height="40px" Width="40px" ID="ImageButton1" ImageUrl="~/Images/delete.jpg" runat="server" OnClick="ImageButton1_Click1" ></asp:ImageButton>
                </td>--%>
            </td>
               
                </table>
            </tr>
                </table>
        </ItemTemplate>
        </asp:Repeater>
        </div>
    </form>
</body>
</html>

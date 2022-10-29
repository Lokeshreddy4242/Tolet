<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FamilyRoomsUpload.aspx.cs" Inherits="PresentationLayer.FamilyRoomsUpload" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="CSS/FileUpload.css" rel="stylesheet" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="fuImage1" runat="server" CssClass="ImagePath" />
            <br />
            <asp:FileUpload ID="fuImage2" runat="server" />
            <br />
            <asp:FileUpload ID="fuImage3" runat="server" />
            <br />
            <asp:FileUpload ID="fuImage4" runat="server" />
        </div>
        <div>
            <asp:TextBox ID="txtOwenerName" runat="server" Placeholder="Owner Name"></asp:TextBox>
            <asp:TextBox ID="txtRent" runat="server" placeholder="Rent" TextMode="Number"></asp:TextBox>
            <asp:TextBox ID="txtPhoneNumber" runat="server" placeholder="Phone Number" TextMode="Phone" ></asp:TextBox>
            <asp:TextBox ID="txtAddress" runat="server" placeholder="Adderess" TextMode="MultiLine" ></asp:TextBox>
        </div>
        <div>
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        </div>
    </form>
</body>
</html>

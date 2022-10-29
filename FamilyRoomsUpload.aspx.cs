using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using BusinessObjects;

namespace PresentationLayer
{
    public partial class FamilyRoomsUpload : System.Web.UI.Page
    {
        BusinessLogicLayer.FamilyRoomsUploadBAL FamilyRoomsUploadBAL = new BusinessLogicLayer.FamilyRoomsUploadBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnSave_Click(object sender, EventArgs e)
        {
            BusinessObjects.FamilyRoomsUploadBO obj = new BusinessObjects.FamilyRoomsUploadBO();
            if (fuImage1.HasFile)
            {
                fuImage1.SaveAs(Server.MapPath("~/Images/") + Path.GetFileName(fuImage1.FileName));
                obj.Image1 = "Images/" + Path.GetFileName(fuImage1.FileName);
            }
            if (fuImage2.HasFile)
            {
                fuImage1.SaveAs(Server.MapPath("~/Images/") + Path.GetFileName(fuImage2.FileName));
                obj.Image2 = "Images/" + Path.GetFileName(fuImage2.FileName);
            }
            if (fuImage3.HasFile)
            {
                fuImage1.SaveAs(Server.MapPath("~/Images/") + Path.GetFileName(fuImage3.FileName));
                obj.Image3 = "Images/" + Path.GetFileName(fuImage3.FileName);
            }
            if (fuImage4.HasFile)
            {
                fuImage4.SaveAs(Server.MapPath("~/Images/") + Path.GetFileName(fuImage4.FileName));
                obj.Image4 = "Images/" + Path.GetFileName(fuImage4.FileName);
            }
            obj.OwnerName = txtOwenerName.Text;
            obj.Rent = int.Parse(txtRent.Text);
            obj.PhoneNumber = txtPhoneNumber.Text;
            obj.Address = txtAddress.Text;
            int i = FamilyRoomsUploadBAL.familyRooms(obj);
            if(i==1)
            {
                Response.Write("<script>alert('Uploaded successfully!.')</script>");
            }
            else
            {
                Response.Write("<script>alert('Uploaded Failed!.')</script>");
            }
            Response.Redirect("Family.aspx");

        }
    }
}
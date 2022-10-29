using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayer
{
    public partial class HomePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["UserName"] != null)
            {
                lblSession1.Text = "Welcome " + Session["UserName"];
            }
             
        }

        protected void img_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void img_Click1(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Family.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("https://www.oyorooms.com/?gclid=Cj0KCQjw--2aBhD5ARIsALiRlwA07jeETy7r4wYPgpL5Gn3IPkcaZulHpTS6HxO0gzkG0ltP294NCl8aAlScEALw_wcB");
        }
    }
}
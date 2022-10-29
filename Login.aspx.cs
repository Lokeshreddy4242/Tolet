using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
//using BusinessObjects;
//using BusinessLogicLayer;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PresentationLayer
{
    public partial class Login : System.Web.UI.Page
    {
        //BusinessLogicLayer.LoginBAL LoginBAL = new BusinessLogicLayer.LoginBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //txtUserName.Text = "";
            //txtPassword.Text = "";
        }

        string getUserId()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            string q = "select UserId from User_Masters where username='" + txtUserName.Text + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            string sr = cmd.ExecuteScalar().ToString();
            con.Close();
            return sr;
        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {

            string user = txtUserName.Text;
            string pass = txtPassword.Text;

            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            string q = "select count(*) from User_Masters where USERNAME='" + user + "'and PASSWORD='" + pass + "'";
            SqlCommand cmd = new SqlCommand(q, con);
            object sr = cmd.ExecuteScalar();
            int a = Convert.ToInt32(sr);
           // Label1.Visible = true;

            if (a == 1)
            {
                Session["UserName"] = getUserId();
                Server.Transfer("HomePage.aspx");
            }
            else
            {
                Response.Write("<script>alert('Invaliod UserName and Password!.')</script>");
            }
            con.Close();
            txtUserName.Text = "";
            txtPassword.Text = "";

        }


        //=============================================================
        //BusinessObjects.LoginBO obj = new BusinessObjects.LoginBO();
        //obj.UserName = txtUserName.Text;
        //obj.Password = txtPassword.Text;
        //if (obj.getUser())
        //{
        //    Response.Redirect("HomePage.aspx");
        //}
        //else
        //{
        //    Response.Write("<script>alert('Invaliod UserName and Password!.')</script>");
        //}
    }
}

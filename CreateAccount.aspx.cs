using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessObjects;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class CreateAccount : System.Web.UI.Page
    {
        BusinessLogicLayer.CreateAccountBAL createAccountBAL = new BusinessLogicLayer.CreateAccountBAL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            
            BusinessObjects.CreateAccountBO createAccount = new BusinessObjects.CreateAccountBO();
            createAccount.UserName = txtUserName.Text;
            createAccount.Email = txtEmail.Text;
            createAccount.Password = txtPassword.Text;
            createAccount.Mobile = txtMobile.Text;
            createAccount.CreatedDate = DateTime.Now;
            int i = createAccountBAL.CreateAccount(createAccount);
            if (i == 1)
                Response.Write("<script>alert('Account Created successfullyy')</script>");
            
            else
                Response.Write("<script>alert('Account Creation Failed')</script>");
            txtUserName.Text = "";
            txtPassword.Text = "";
            txtMobile.Text = "";
            txtEmail.Text = "";
            txtconfirmpassword.Text = "";
            Response.Redirect("Login.aspx");




        }
    }
}
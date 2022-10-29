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
    public partial class Page1 : System.Web.UI.Page
    {
        BusinessLogicLayer.EmployeeBAL objempBAL = new BusinessLogicLayer.EmployeeBAL();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Response.Write("<script>alert('Account Created successfullyy')</script>");
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            BusinessObjects.EmployeeBO objempbo = new BusinessObjects.EmployeeBO();
            try
            {
                objempbo.Eno = int.Parse(txtEno.Text);
                objempbo.Ename = txtEname.Text;
                objempbo.Salary = double.Parse(txtSalary.Text);
                int i = objempBAL.SaveEmp(objempbo);
                if (i == 1)
                    Response.Write("Save");
                
            }
            catch(Exception ex)
            {
                Response.Write("Failed");
            }
            
           
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Createaccount.aspx");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace PresentationLayer
{
    public partial class Family : System.Web.UI.Page
    {
        BusinessLogicLayer.FamilyBAL familyBAL = new BusinessLogicLayer.FamilyBAL();
        BusinessObjects.FamilyBO familyBO = new BusinessObjects.FamilyBO();
        private SqlDataAdapter da;

        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack ==false)
            {
                GetFamily();
            }
            
        }

        //protected void rptDetails_ItemCommand(object source, RepeaterCommandEventArgs e)
        //{
        //    BusinessObjects.FamilyBO family = new BusinessObjects.FamilyBO();

        //    rptDetails.DataSource = familyBAL.getFamily();
        //    rptDetails.DataBind();
        //    familyBO.House_Id = Convert.ToInt32(Request.QueryString["House_Id"]);

        //}

        public void GetFamily()
        {
            BusinessObjects.FamilyBO family = new BusinessObjects.FamilyBO();

            rptDetails.DataSource = familyBAL.getFamily();
            rptDetails.DataBind();
            familyBO.House_Id = Convert.ToInt32(Request.QueryString["House_Id"]);

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("FamilyRoomsUpload.aspx");
        }
    }
}
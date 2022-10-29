using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using BusinessObjects;


namespace DataAccessLayer
{
    public class FamilyDAL
    {
        //public List<FamilyBO> GetFamilies(FamilyBO family)
        //{
        //    List<FamilyBO> lstFamilyDTO = new List<FamilyBO>();
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("uspgetFamilyHouses", con);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.AddWithValue("@House_Id", family.House_Id);
        //    SqlDataAdapter da = new SqlDataAdapter(cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);

        //    foreach (DataRow dr in dt.Rows)
        //    {
        //        family = new FamilyBO();
        //        family.House_Id = Convert.ToInt32(dr["House_Id"]);
        //        family.Image1 = dr["Image1"].ToString();
        //        family.Image2 = dr["Image2"].ToString();
        //        family.Image3 = dr["Image3"].ToString();
        //        family.Image4 = dr["Image4"].ToString();
        //        family.OwenerName = dr["OwenerName"].ToString();
        //        family.Rent = dr["Rent"].ToString();
        //        family.PhoneNmber = dr["PhoneNumber"].ToString();
        //        family.Address = dr["Address"].ToString();
        //        lstFamilyDTO.Add(family);
        //    }
        //    return lstFamilyDTO;
        //}


        public DataSet getFamily()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("uspgetFamilyHouses", con);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
    }
}

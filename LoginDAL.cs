//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Data.SqlClient;
//using System.Data;
//using System.Configuration;
//using BusinessObjects;

//namespace DataAccessLayer
//{
//    public class LoginDAL
//    {
        //public string UserName { get; private set; }
        //public string Password { get; private set; }
        
        //public DataSet  IsValid(BusinessObjects.LoginBO objLogin)
        //{
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
        //    con.Open();
        //    SqlCommand cmd = new SqlCommand("select * from User_Masters where UserName='" + UserName + "'and Password='" + Password + "'", con);
        //    DataSet ds = new DataSet();
        //    SqlDataAdapter sda = new SqlDataAdapter(cmd);
        //    sda.Fill(ds);
        //    con.Close();
        //    return ds;
        //    //int a = Convert.ToInt32(cmd.ExecuteScalar());
           
        //    //return a;
        //    // cmd.CommandType = CommandType.StoredProcedure;
        //    //cmd.Parameters.AddWithValue("@UserId", objLogin.UserId);
        //    //cmd.Parameters.AddWithValue("@UserName", objLogin.UserName);
        //    // cmd.Parameters.AddWithValue("@Password", objLogin.Password);
        //    // string a = cmd.ExecuteScalar().ToString();
        //    // return a;
        //    //cmd.Parameters.Add("@ERROR", SqlDbType.Char, 500);
        //    //cmd.Parameters["@ERROR"].Direction = ParameterDirection.Output;
        //    //SqlDataAdapter da = new SqlDataAdapter();
        //    //DataSet ds = new DataSet();
        //    //da = new SqlDataAdapter(cmd);
        //    //da.Fill(ds);
        //    //con.Close();
        //    //return ds;

        //}

        //public string userlog(BusinessObjects.LoginBO objLogin)//getting the userType
        //{
        //    SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
        //        con.Open();
        //        SqlCommand cmd = new SqlCommand("select userType from User_Masters where userName='" + UserName + "' and password='" + Password + "'", con);
        //    string a = cmd.ExecuteScalar().ToString();

        //       con.Close();
        //      return a;

//        //}
//    }
//}

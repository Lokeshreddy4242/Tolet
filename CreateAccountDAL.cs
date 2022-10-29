using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using BusinessObjects;

namespace DataAccessLayer
{
    public class CreateAccountDAL
    {
        public int CreateAccount(BusinessObjects.CreateAccountBO objCreateAccount)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("uspUserMasters",con);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@UserId", objCreateAccount.UserId);
            cmd.Parameters.AddWithValue("@UserName", objCreateAccount.UserName);
            cmd.Parameters.AddWithValue("@Email", objCreateAccount.Email);
            cmd.Parameters.AddWithValue("@Password", objCreateAccount.Password);
            cmd.Parameters.AddWithValue("@CreatedDate", objCreateAccount.CreatedDate);
            cmd.Parameters.AddWithValue("@Mobile", objCreateAccount.Mobile);
            //cmd.Parameters.AddWithValue("@IsDeleted", objCreateAccount.IsDeleted);

            int i= cmd.ExecuteNonQuery();
            con.Close();
            return i;
           
                 
        }
    }
}

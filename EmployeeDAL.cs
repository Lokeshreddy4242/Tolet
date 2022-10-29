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
    public class EmployeeDAL
    {
        public int SaveEmp(BusinessObjects.EmployeeBO objempbo)
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
            con.Open();
            SqlCommand cmd = new SqlCommand("proc_save", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@eno",objempbo.Eno);
            cmd.Parameters.AddWithValue("@ename",objempbo.Ename);
            cmd.Parameters.AddWithValue("@sal",objempbo.Salary);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }
    }
}

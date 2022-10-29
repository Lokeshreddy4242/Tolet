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
    public class FamilyRoomsUploadDAL
    {
        public int familyRooms(BusinessObjects.FamilyRoomsUploadBO familyRooms)
        {
            try
            {
                SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
                con.Open();
                SqlCommand cmd = new SqlCommand("uspFamilyRoomsUpload", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Image1", familyRooms.Image1);
                cmd.Parameters.AddWithValue("@Image2", familyRooms.Image2);
                cmd.Parameters.AddWithValue("@Image3", familyRooms.Image3);
                cmd.Parameters.AddWithValue("@Image4", familyRooms.Image4);
                cmd.Parameters.AddWithValue("@OwnerName", familyRooms.OwnerName);
                cmd.Parameters.AddWithValue("@Rent", familyRooms.Rent);
                cmd.Parameters.AddWithValue("@PhoneNumber", familyRooms.PhoneNumber);
                cmd.Parameters.AddWithValue("@Address", familyRooms.Address);
                int i = cmd.ExecuteNonQuery();
                con.Close();
                return i;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            
        }
    }
}

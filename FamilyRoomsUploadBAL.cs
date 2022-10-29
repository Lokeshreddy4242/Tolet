using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class FamilyRoomsUploadBAL
    {
        DataAccessLayer.FamilyRoomsUploadDAL FamilyRoomsUploadDAL = new DataAccessLayer.FamilyRoomsUploadDAL();

        public int familyRooms(BusinessObjects.FamilyRoomsUploadBO familyRooms) 
        {
            int i = FamilyRoomsUploadDAL.familyRooms(familyRooms);
            return i;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLogicLayer;
using BusinessObjects;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{
    public class FamilyBAL
    {
        DataAccessLayer.FamilyDAL FamilyDAL = new DataAccessLayer.FamilyDAL();
        public DataSet getFamily()
        {
            DataSet ds = FamilyDAL.getFamily();
            return ds;

        }
       
    }
}

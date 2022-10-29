using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public class EmployeeBAL
    {
        DataAccessLayer.EmployeeDAL objectDAL = new DataAccessLayer.EmployeeDAL();
        public int SaveEmp(BusinessObjects.EmployeeBO objempbo)
        {
            int i = objectDAL.SaveEmp(objempbo);
            return i;
        }
    }
}

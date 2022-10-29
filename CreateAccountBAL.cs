using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class CreateAccountBAL
    {
        DataAccessLayer.CreateAccountDAL CreateAccountDAL = new DataAccessLayer.CreateAccountDAL();

        public int CreateAccount(BusinessObjects.CreateAccountBO objCreateAccount)
        {
            int i = CreateAccountDAL.CreateAccount(objCreateAccount);
            return i;
        }
    }
}

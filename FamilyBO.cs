using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    public class FamilyBO
    {

        public int _House_Id;
        public int House_Id
        {
            get
            {
                return _House_Id;
            }
            set
            {
                _House_Id = value;
            }
        }

        private string _Image1;
        public string Image1
        {
            get
            {
                return _Image1;
            }
            set
            {
                _Image1 = value;
            }

        }
        private string _Image2;
        public string Image2
        {
            get
            {
                return _Image2;
            }
            set
            {
                _Image2 = value;
            }

        }
        private string _Image3;
        public string Image3
        {
            get
            {
                return _Image3;
            }
            set
            {
                _Image3 = value;
            }

        }
        private string _Image4;
        public string Image4
        {
            get
            {
                return _Image4;
            }
            set
            {
                _Image4 = value;
            }

        }
        private string _OwenerName;
        public string OwenerName
        {
            get
            {
                return _OwenerName;
            }
            set
            {
                _OwenerName = value;
            }

        }
        private string _Rent;
        public string Rent
        {
            get
            {
                return _Rent;
            }
            set
            {
                _Rent = value;
            }

        }
        private string _PhoneNmber;
        public string PhoneNmber
        {
            get
            {
                return _PhoneNmber;
            }
            set
            {
                _PhoneNmber = value;
            }

        }
        private string _Address;
        public string Address
        {
            get
            {
                return _Address;
            }
            set
            {
                _Address = value;
            }

        }

        public FamilyBO()
        {
            _House_Id = 0;
            _Image1 = string.Empty;
            _Image2 = string.Empty;
            _Image3 = string.Empty;
            _Image4 = string.Empty;
            _OwenerName = string.Empty;
            _Rent = string.Empty;
            _PhoneNmber = string.Empty;
            _Address = string.Empty;
        }

    }
}

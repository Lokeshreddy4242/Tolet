using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessObjects
{
    partial class RoomsUploadBO
    {
        public int HouseId { get; set; }
        public string Image1 { get; set; }
        public string Image2 { get; set; }
        public string Image3 { get; set; }
        public string Image4 { get; set; }
        public string OwnerName { get; set; }
        public int Rent { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
    }
}

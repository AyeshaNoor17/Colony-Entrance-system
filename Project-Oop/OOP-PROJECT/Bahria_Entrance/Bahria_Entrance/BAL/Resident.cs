using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahria_Entrance.BAL
{
    public class Resident
    {
        public string CNIC { get; set; }
        public string Name { get; set; }
        public string R_Address { get; set; }
        public int CardNo { get; set; }
        public string PhoneNo { get; set; }
        public int HouseNo { get; set; }

        public Resident(string CNIC, string Name, string R_Address, int CardNo, string PhoneNo, int HouseNo)
        {
            this.CNIC = CNIC;
            this.Name = Name;
            this.R_Address = R_Address;
            this.CardNo = CardNo;
            this.PhoneNo = PhoneNo;
            this.HouseNo = HouseNo;
        }
    }
}

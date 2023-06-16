using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bahria_Entrance.BAL
{
    public class Visitor
    {
        public string CNIC { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public int VisitNo { get; set; }
        public int HouseNo { get; set; }

        public Visitor(string CNIC, string Name, string PhoneNumber, int VisitNo, int HouseNo)
        {
            this.CNIC = CNIC;
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.VisitNo = VisitNo;
            this.HouseNo = HouseNo;
        }

        public Visitor(string CNIC,int VisitNo)
        {
            this.CNIC = CNIC;
            this.VisitNo = VisitNo;
        }
    }
}

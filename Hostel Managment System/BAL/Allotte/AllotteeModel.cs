using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.BAL.Allotte
{
    class AllotteeModel
    {
        
            public string AllotteeID { get; set; }
            public string CNIC { get; set; }
            public string DOB { get; set; }
            public string PhoneNumber { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }



            public AllotteeModel(string allotteeID, string cnic, string dob, string phoneNumber, string name, string address)
            {
                AllotteeID = allotteeID;
                CNIC = cnic;
                Name = name;
                DOB = dob;
                PhoneNumber = phoneNumber;
                Address = address;
            }
        }
    
}

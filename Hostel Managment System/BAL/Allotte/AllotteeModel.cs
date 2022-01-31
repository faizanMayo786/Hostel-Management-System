using Hostel_Managment_System.BAL.Payment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.BAL.Allotte
{
    public class AllotteeModel
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string CNIC { get; set; }
        public string DOB { get; set; }
        public string Address { get; set; }
        public PaymentModel PaymentID { get; set; }
        public AllotteeModel(string allotteeID, string cnic, string dob, string phoneNumber, string name, string address)
        {
            ID = allotteeID;
            CNIC = cnic;
            Name = name;
            DOB = dob;
            PhoneNumber = phoneNumber;
            Address = address;
        }
        public void AddPayment(PaymentModel payment)
        {
            PaymentID = payment;
        }
    }
}

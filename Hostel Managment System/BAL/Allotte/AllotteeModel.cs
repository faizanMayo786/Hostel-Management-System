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
        public string roomId { get; set; }
        public string bedId { get; set; }
        public AllotteeModel(string allotteeID, string cnic, string dob, string phoneNumber, string name, string address, string bedId = "", string roomId = "", string paymentId = "")
        {
            this.PaymentID = new PaymentModel();
            ID = allotteeID;
            CNIC = cnic;
            Name = name;
            DOB = dob;
            PhoneNumber = phoneNumber;
            Address = address;
            this.roomId = roomId;
            this.PaymentID.ID = paymentId;
            this.bedId = bedId;
        }
        public void AddPayment(PaymentModel payment)
        {
            PaymentID = payment;
        }
    }
}

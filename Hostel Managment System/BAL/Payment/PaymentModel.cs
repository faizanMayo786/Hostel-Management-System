using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.BAL.Payment
{
    public class PaymentModel
    {
        public string ID { get; set; }
        public string Date { get; set; }
        public string AllotteId { get; set; }
        public PaymentModel(string id = "", string date = "", string allotteId = "")
        {
            ID = id;
            Date = date;
            this.AllotteId = allotteId;
        }
        public override string ToString()
        {
            return ID.ToString();
        }

    }
}

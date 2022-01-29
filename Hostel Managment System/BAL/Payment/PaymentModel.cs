using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.BAL.Payment
{
    class PaymentModel
    {
        public string ID { get; set; }
        public string Date { get; set; }



        public PaymentModel(string id, string date)
        {
            ID = id;
            Date = date;
        }





    }
}

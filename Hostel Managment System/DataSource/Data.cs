using Hostel_Managment_System.BAL.Allotte;
using Hostel_Managment_System.BAL.Bed;
using Hostel_Managment_System.BAL.Payment;
using Hostel_Managment_System.BAL.Room;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.DataSource
{
    class Data
    {
        public static List<AllotteeModel> allotte = new List<AllotteeModel>();
        public static List<RoomModel> room = new List<RoomModel>();
        public static List<BedModel> bed = new List<BedModel>();
        public static List<PaymentModel> payment = new List<PaymentModel>();
    }
}

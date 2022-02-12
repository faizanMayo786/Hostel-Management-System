using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.BAL.Bed
{
    public class BedModel
    {

        public string ID { get; set; }
        public string RoomId { get; set; }
        public string AllotteID { get; set; }
        public string Status
        {
            get;
            set;
        }

        public BedModel(string id, string status, string roomId = "", string allotteId = "")
        {

            ID = id;
            this.RoomId = roomId;
            this.AllotteID = allotteId;
            Status = status;

        }

    }
}

using Hostel_Managment_System.BAL.Allotte;
using Hostel_Managment_System.BAL.Bed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.BAL.Room
{
    class RoomModel
    {
        protected AllotteeModel[] allottee = new AllotteeModel[4];
        protected BedModel[] bed = new BedModel[4];
        public string  NoOfBed { get; set; }
        public string RoomFloor { get; set; }
        public string ID { get; set; }
        public string  NoOfAllottee { get; set; }
        public RoomModel( string noOfBed,string roomFloor, string id, string noOfAllottee)
        {
            NoOfAllottee = noOfAllottee;
            NoOfBed = noOfBed;
            ID = id;
            RoomFloor = roomFloor;
        }


    }
}

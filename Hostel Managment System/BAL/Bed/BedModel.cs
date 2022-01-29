using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.BAL.Bed
{
    class BedModel
    {
        public string ID { get; set; }
        public string Status { get; set; }

        public BedModel(string id, string status)
        {
            ID = id;
            Status = status;
        }
    }
}

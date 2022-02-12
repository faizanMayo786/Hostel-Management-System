using Hostel_Managment_System.BAL.Room;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.DataSource.CRUD.UpdateRecord
{
    class Room
    {
        public static void UpdateRoomRecord(RoomModel room)
        {
            string qry = $"UPDATE Room SET id = '{room.ID}', , noOfAllottee = '{room.NoOfAllottee}',roomFloor='{room.RoomFloor}',noOfBed = '{room.NoOfBed}'   WHERE id = '{room.ID}'";
            SqlConnection connection = DataSource.Connection.Connection.GetConnection();
            SqlCommand command = new SqlCommand(qry, connection);
            command.CommandType = System.Data.CommandType.Text;
            try
            {
                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

            }
        }
    }
}

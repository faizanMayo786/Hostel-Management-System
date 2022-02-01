using Hostel_Managment_System.BAL.Allotte;
using Hostel_Managment_System.BAL.Room;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.DataSource.CRUD.CreateRecord
{
    class Room
    {
        public static void AddRoomRecord(RoomModel room)
        {
            string qry = $"INSERT INTO Room (id, roomFloor, noOfBed,noOfAllottee) VALUES('{room.ID}', '{room.RoomFloor}', '{room.NoOfBed}','{room.NoOfAllottee}'); ";
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

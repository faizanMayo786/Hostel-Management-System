using Hostel_Managment_System.BAL.Payment;
using Hostel_Managment_System.BAL.Room;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Managment_System.DataSource.CRUD.ReadRecord
{
    class Room
    {
        public static void GetRoomRecord()
        {
            try
            {
                string str = "Select *  From Room";
                SqlConnection connection = Connection.Connection.GetConnection();
                SqlCommand command = new SqlCommand(str, connection);
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Room");
                var roomList = ds.Tables[0].AsEnumerable()
                .Select(dataRow => new RoomModel(
                    roomFloor: dataRow.Field<string>("roomFloor"),
                    id: dataRow.Field<string>("id")
                    )
                ).ToList();
                DataSource.Data.room = roomList;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Loading Data From Database!!!");
            }
        }
    }
}


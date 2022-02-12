using Hostel_Managment_System.BAL.Allotte;
using Hostel_Managment_System.BAL.Bed;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.DataSource.CRUD.CreateRecord
{
    class Bed
    {
        public static void AddBedRecord(BedModel bed)
        {
            string qry = $"INSERT INTO Bed (id, status,roomId,allotteId) VALUES('{bed.ID}', '{bed.Status}','{bed.RoomId}','{bed.AllotteID}'); ";
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

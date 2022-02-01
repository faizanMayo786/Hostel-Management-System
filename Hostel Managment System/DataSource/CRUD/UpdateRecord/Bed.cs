using Hostel_Managment_System.BAL.Bed;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.DataSource.CRUD.UpdateRecord
{
    class Bed
    {
        public static void UpdateBedRecord(BedModel bed)
        {
            string qry = $"UPDATE Allottee SET(id = '{bed.ID}', , status = '{bed.Status}')  WHERE id = '{bed.ID}'";
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

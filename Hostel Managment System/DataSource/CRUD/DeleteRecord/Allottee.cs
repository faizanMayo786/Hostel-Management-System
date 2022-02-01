using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.DataSource.CRUD.DeleteRecord
{
    class Allottee
    {
        public static void DeleteAllotteeRecord(string id)
        {
            string qry = $"DELETE FROM Allottee WHERE id = {id}";
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

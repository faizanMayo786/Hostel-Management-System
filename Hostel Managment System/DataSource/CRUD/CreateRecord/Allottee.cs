using Hostel_Managment_System.BAL.Allotte;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.DataSource.CRUD.CreateRecord
{
    class Allottee
    {
        public static void AddAllotteeRecord(AllotteeModel allottee)
        {
            string qry = $"INSERT INTO Allottee (id, name, phoneNumber,cnic,dob,address,paymentId,roomId,bedId)" +
                $" VALUES('{allottee.ID}', '{allottee.Name}', '{allottee.PhoneNumber}','{allottee.CNIC}','{allottee.DOB}','{allottee.Address}','{allottee.PaymentID}','{allottee.roomId}','{allottee.bedId}'); ";
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

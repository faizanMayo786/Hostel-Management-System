using Hostel_Managment_System.BAL.Allotte;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.DataSource.CRUD.UpdateRecord
{
    class Allottee
    {
        public static void UpdateAllotteeRecord(AllotteeModel allottee)
        {
            string qry = $"UPDATE Allottee SET(id = '{allottee.ID}', , name = '{allottee.Name}',phoneNumber='{allottee.PhoneNumber}',cnic = '{allottee.CNIC}',dob = '{allottee.DOB}',address = '{allottee.Address}',paymentId = '{allottee.PaymentID}')  WHERE id = '{allottee.ID}'";
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

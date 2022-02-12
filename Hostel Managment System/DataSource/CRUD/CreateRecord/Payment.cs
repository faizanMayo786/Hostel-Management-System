using Hostel_Managment_System.BAL.Allotte;
using Hostel_Managment_System.BAL.Payment;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.DataSource.CRUD.CreateRecord
{
    class Payment
    {
        public static void AddPaymentRecord(PaymentModel payment)
        {
            string qry = $"INSERT INTO Payment (id,date,allotteId) VALUES('{payment.ID}', '{payment.Date}','{payment.AllotteId}'); ";
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

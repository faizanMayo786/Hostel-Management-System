using Hostel_Managment_System.BAL.Payment;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.DataSource.CRUD.UpdateRecord
{
    class Payment
    {
        public static void UpdatePaymentRecord(PaymentModel payment)
        {
            string qry = $"UPDATE Payment SET(id = '{payment.ID}', , date = '{payment.Date}')  WHERE id = '{payment.ID}'";
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

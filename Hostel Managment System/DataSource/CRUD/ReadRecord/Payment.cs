using Hostel_Managment_System.BAL.Payment;
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
    class Payment
    {
        public static void GetPaymentRecord()
        {
            try
            {
                string str = "Select *  From Payment";
                SqlConnection connection = Connection.Connection.GetConnection();
                SqlCommand command = new SqlCommand(str, connection);
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Payment");
                var paymentList = ds.Tables[0].AsEnumerable()
                .Select(dataRow => new PaymentModel(
                    id: dataRow.Field<string>("id"),
                    date: dataRow.Field<string>("date")
                    , allotteId: dataRow.Field<string>("allotteId")
                    )
                ).ToList();
                DataSource.Data.payment = paymentList;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Loading Data From Database!!!");
            }
        }
    }
}


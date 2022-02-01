using Hostel_Managment_System.BAL.Bed;
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
    class Bed
    {
        public static void GetBedRecord()
        {
            try
            {
                string str = "Select *  From Bed";
                SqlConnection connection = Connection.Connection.GetConnection();
                SqlCommand command = new SqlCommand(str, connection);
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Bed");
                var bedList = ds.Tables[0].AsEnumerable()
                .Select(dataRow => new BedModel(
                    id: dataRow.Field<string>("id"),
                    status: dataRow.Field<string>("status")
                    )
                ).ToList();
                DataSource.Data.bed = bedList;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Loading Data From Database!!!");
            }
        }
    }
}


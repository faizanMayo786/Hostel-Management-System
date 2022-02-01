using Hostel_Managment_System.BAL.Allotte;
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
    static class Allottee
    {
        public static void GetAllotteeRecord()
        {
            try
            {
                string str = "Select *  From Allottee";
                SqlConnection connection = Connection.Connection.GetConnection();
                SqlCommand command = new SqlCommand(str, connection);
                command.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(ds, "Allottee");
                var AllotteList = ds.Tables[0].AsEnumerable()
                .Select(dataRow => new AllotteeModel(
                    allotteeID: dataRow.Field<string>("id"),
                    cnic: dataRow.Field<string>("cnic"),
                    dob: dataRow.Field<string>("dob"),
                    phoneNumber: dataRow.Field<string>("phoneNumber"),
                    name: dataRow.Field<string>("name"),
                    address: dataRow.Field<string>("address")
                    )
                ).ToList();
                DataSource.Data.allotte = AllotteList;
            }
            catch (Exception)
            {
                MessageBox.Show("Error Loading Data From Database!!!");
            }
        }
    }
}

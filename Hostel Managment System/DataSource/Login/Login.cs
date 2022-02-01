using Hostel_Managment_System.BAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.DataSource.Login
{
    class Login
    {
        public static DataSet GetLogin()
        {
            string str = $"Select username,password  From Credential";
            SqlConnection connection = Connection.Connection.GetConnection();
            SqlCommand command = new SqlCommand(str, connection);
            command.CommandType = CommandType.Text;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Credential");
            return ds;
        }
    }
}
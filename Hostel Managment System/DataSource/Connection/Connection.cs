using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Managment_System.DataSource.Connection
{
    class Connection
    {
        public static SqlConnection GetConnection()
        {
            string conn = "Data Source=MAYO;Initial Catalog=HMS;Integrated Security=True";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                MessageBox.Show("DB not Connected!");
            }
            return connection;
        }
    }
}

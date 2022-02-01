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
            string conn = "Data Source  = DESKTOP-U9183MB; Initial Catalog = HMS;Integrated Security = true;";
            SqlConnection connection = new SqlConnection(conn);
            try
            {
                connection.Open();
                MessageBox.Show("Database Connected!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("DB not Connected!");
            }
            return connection;
        } 
    }
}

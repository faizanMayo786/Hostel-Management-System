using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hostel_Managment_System.BAL.Admin
{
    class VerifyAdmin
    {
        static public bool Authentication(AdminModel admin)
        {
            DataSet dataSet = DataSource.Login.Login.GetLogin();
            if (
                 admin.Username.Equals(dataSet.Tables[0].Rows[0]["username"].ToString()) &&
                 admin.Password.Equals(dataSet.Tables[0].Rows[0]["password"].ToString())
              )
            {
                return true;
            }
            return false;
        }
    }
}
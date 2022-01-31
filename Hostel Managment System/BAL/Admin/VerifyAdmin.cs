using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.BAL.Login
{
    class VerifyAdmin
    {
        static public bool Authentication(AdminModel admin)
        {
            if(
                 admin.Username.Equals("test") &&
                 admin.Password.Equals("123")
              )
            {
                return true;
            }
            return false;
        }
    }
}

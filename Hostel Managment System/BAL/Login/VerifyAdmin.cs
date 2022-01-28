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
            if(admin.Email.Equals("Faizan")&& admin.Password.Equals("786"))
            {
                return true;
            }
            return false;
        }
    }
}

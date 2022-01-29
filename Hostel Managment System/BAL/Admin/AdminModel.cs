using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.BAL
{
    class AdminModel
    {


        public string Email { get; set; }
        public string Password { get; set; }
        public AdminModel(string email,string password)
        {
            Email = email;
            Password = password;
        }

        
    }
}

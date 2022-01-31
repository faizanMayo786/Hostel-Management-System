using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.BAL
{
    class AdminModel
    {


        public string Username { get; set; }
        public string Password { get; set; }
        public AdminModel(string username,string password)
        {
            Username = username;
            Password = password;
        }

        
    }
}

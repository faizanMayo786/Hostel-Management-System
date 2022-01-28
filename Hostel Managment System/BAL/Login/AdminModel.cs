using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.BAL
{
    class AdminModel
    {

        private string email;
        private string password;

        public string Email { 
            get { return email; } 
            set { email = value; }
        }
        public string Password
        {
            get { return password; }
            set { password= value; }

        }
        public AdminModel(string email,string password)
        {
            Email = email;
            Password = password;
        }

        
    }
}

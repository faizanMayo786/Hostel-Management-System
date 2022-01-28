using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Managment_System.PAL
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            BAL.AdminModel admin = new BAL.AdminModel(
                txtEmail.Text,
                txtPassword.Text
                ) ;
            if (BAL.Login.VerifyAdmin.Authentication(admin))
            {
                MessageBox.Show("Login Successful!");
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid Email or Password!");

            }
        }
    }
}

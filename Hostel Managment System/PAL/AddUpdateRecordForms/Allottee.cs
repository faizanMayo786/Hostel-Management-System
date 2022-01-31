using Hostel_Managment_System.BAL.Allotte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Managment_System.PAL.AddRecordForms
{
    public partial class Allottee : Form
    {
        private string heading;
        public Allottee(string heading)
        {
            InitializeComponent();
            lblText.Text = heading;
            this.heading = heading;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() != "")
            {
                AllotteeModel allotte = new AllotteeModel(
                    txtID.Text,
                    txtCNIC.Text,
                    txtDOB.Text,
                    txtPhoneNo.Text,
                    txtName.Text,
                    txtAddress.Text
                );
                DataSource.Data.allotte.Add(allotte);
                MessageBox.Show("Record Added Successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Record Not " + heading + "ed");
            }
        }

        private void Allottee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}

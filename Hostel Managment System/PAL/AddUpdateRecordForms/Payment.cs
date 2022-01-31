using Hostel_Managment_System.BAL.Payment;
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
    public partial class Payment : Form
    {
        private string heading;
        public Payment(string heading)
        {

            InitializeComponent();
            this.heading = heading;
            lblText.Text = heading;
        }
        private List<string> allottee = new List<string>();
        private void Payment_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            dtpDate.Enabled = false;
            foreach (var item in DataSource.Data.allotte)
            {
                allottee.Add(item.AllotteeID);
            }
            cmbAllotteID.DataSource = allottee;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() != "")
            {
                PaymentModel payment = new PaymentModel(
                    txtID.Text,
                    dtpDate.Text.ToString()
                );
                MessageBox.Show(cmbAllotteID.SelectedItem.ToString());
                DataSource.Data.allotte[cmbAllotteID.SelectedIndex].AddPayment(payment);
                MessageBox.Show("Record Added Successfully!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Record Not " + heading + "ed");
            }
        }

        private void Payment_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbAllotteID.SelectedIndex != -1)
            {

                txtID.Enabled = true;
                dtpDate.Enabled = true;
            }
            
        }
    }
}

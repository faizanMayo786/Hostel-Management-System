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
        private PaymentModel payment1;
        private int index;
        public Payment(string heading, PaymentModel payment, int index)
        {
            this.index = index;
            InitializeComponent();
            this.payment1 = payment;
            this.heading = heading;
            lblText.Text = heading;
        }
        private List<string> allottee = new List<string>();
        private void Payment_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (heading.Contains("Add"))
            {
                dtpDate.Enabled = false;
            }
            else
            {
                txtID.Text = payment1.ID;
                dtpDate.Text = payment1.Date;
            }
            foreach (var item in DataSource.Data.allotte)
            {
                allottee.Add(item.ID);
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
                if (heading.Contains("Add"))
                {
                    DataSource.Data.payment.Add(payment);
                    DataSource.Data.allotte[cmbAllotteID.SelectedIndex].AddPayment(payment);
                    DataSource.CRUD.CreateRecord.Payment.AddPaymentRecord(payment);
                    MessageBox.Show("Record Added Successfully!");
                }
                else
                {
                    DataSource.Data.payment[index] = payment;
                    DataSource.Data.allotte[cmbAllotteID.SelectedIndex].AddPayment(payment); MessageBox.Show("Record Added Successfully!");
                    DataSource.CRUD.UpdateRecord.Payment.UpdatePaymentRecord(payment);

                    MessageBox.Show("Record Updated Successfully!");

                }
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
                if (heading.Contains("Add"))
                    txtID.Enabled = true;
                dtpDate.Enabled = true;
            }

        }
    }
}

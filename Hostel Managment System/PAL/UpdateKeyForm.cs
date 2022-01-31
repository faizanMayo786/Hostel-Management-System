using Hostel_Managment_System.PAL.AddRecordForms;
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
    public partial class UpdateKeyForm : Form
    {
        private string heading;
        private int form;
        public UpdateKeyForm(string heading, int form)
        {
            InitializeComponent();
            this.form = form;
            this.heading = heading;

        }
        public void GenerateForm()
        {
            button1.Tag = "Submit";
            switch (form)
            {
                case 0:

                    Allottee allottee = new Allottee(
                        heading + " Allottee Record",
                        DataSource.Data.allotte[cmbRecordID.SelectedIndex],
                        cmbRecordID.SelectedIndex
                        );
                    this.Close();
                    allottee.Show();
                    break;
                case 1:
                    Payment payment = new Payment(
                        heading + " Payment Record",
                        DataSource.Data.payment[cmbRecordID.SelectedIndex],
                        cmbRecordID.SelectedIndex

                        );
                    this.Close();
                    payment.Show();

                    break;
                case 2:
                    Room room = new Room(
                        heading + " Room Record",
                        DataSource.Data.room[cmbRecordID.SelectedIndex],
                        cmbRecordID.SelectedIndex


                        );
                    this.Close();
                    room.Show();
                    break;
                case 3:
                    Bed bed = new Bed(
                        heading + " Bed Record",
                        DataSource.Data.bed[cmbRecordID.SelectedIndex],
                        cmbRecordID.SelectedIndex

                        );
                    this.Close();
                    bed.Show();
                    break;
                default:
                    break;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbRecordID.SelectedIndex != -1)
            {
                GenerateForm();
            }
            else
            {
                MessageBox.Show("Choose Record ID!");
            }
        }

        private void UpdateKeyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            if (button1.Tag.ToString() == "Submit")
            {
                return;
            }
            else
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
        }

        private void UpdateKeyForm_Load(object sender, EventArgs e)
        {
            switch (form)
            {
                case 0:
                    List<string> allottee = new List<string>();
                    foreach (var item in DataSource.Data.allotte)
                    {
                        allottee.Add(item.ID);
                    }
                    cmbRecordID.DataSource = allottee;
                    break;
                case 1:
                    List<string> payment = new List<string>();
                    foreach (var item in DataSource.Data.payment)
                    {
                        payment.Add(item.ID);
                    }
                    cmbRecordID.DataSource = payment;
                    break;
                case 2:
                    List<string> room = new List<string>();
                    foreach (var item in DataSource.Data.room)
                    {
                        room.Add(item.ID);
                    }
                    cmbRecordID.DataSource = room;
                    break;
                case 3:
                    List<string> bed = new List<string>();
                    foreach (var item in DataSource.Data.bed)
                    {
                        bed.Add(item.ID);
                    }
                    cmbRecordID.DataSource = bed;
                    break;

                default:
                    break;
            }
        }
    }
}

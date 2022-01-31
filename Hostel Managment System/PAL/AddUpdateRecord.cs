using Hostel_Managment_System.PAL.AddRecordForms;
using System;
using System.Windows.Forms;

namespace Hostel_Managment_System.PAL
{
    public partial class Add_Record : Form
    {
        private string heading;
        public Add_Record(string heading)
        {

            InitializeComponent();
            this.heading = heading;
            lblText.Text = heading + " Record";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbRecordType.SelectedIndex != -1)
            {
                button1.Tag = "Submit";
                switch (cmbRecordType.SelectedIndex)
                {
                    case 0:
                        if (heading == "Add")
                        {
                            Allottee allottee = new Allottee(heading + " Allottee Record", null, 0);
                            allottee.Show();
                        }
                        else
                        {
                            UpdateKeyForm update = new UpdateKeyForm(heading, cmbRecordType.SelectedIndex);
                            update.Show();
                        }
                        this.Close();
                        break;
                    case 1:
                        if (heading == "Add")
                        {
                            Payment payment = new Payment(heading + " Payment Record", null, 0);
                            payment.Show();
                        }

                        else
                        {
                            UpdateKeyForm update = new UpdateKeyForm(heading, cmbRecordType.SelectedIndex);
                            update.Show();
                        }
                        this.Close();
                        break;
                    case 2:
                        if (heading == "Add")
                        {
                            Room room = new Room(heading + " Room Record", null, 0);
                            room.Show();
                        }

                        else
                        {
                            UpdateKeyForm update = new UpdateKeyForm(heading, cmbRecordType.SelectedIndex);
                            update.Show();
                        }
                        this.Close();
                        break;
                    case 3:
                        if (heading == "Add")
                        {
                            Bed bed = new Bed(heading + " Bed Record", null, 0);
                            bed.Show();
                        }

                        else
                        {
                            UpdateKeyForm update = new UpdateKeyForm(heading, cmbRecordType.SelectedIndex);
                            update.Show();
                        }
                        this.Close();
                        break;
                    default:
                        break;
                }
            }
            else
            {
                MessageBox.Show("Choose Record Type!");
            }
        }

        private void Add_Record_Load(object sender, EventArgs e)
        {
        }

        private void Add_Record_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}

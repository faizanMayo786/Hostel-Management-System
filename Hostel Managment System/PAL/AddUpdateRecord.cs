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
                        Allottee allottee = new Allottee(heading + " Allottee Record");
                        allottee.Show();
                        break;
                    case 1:
                        Payment payment = new Payment(heading+" Payment Record");
                        payment.Show();
                        
                        break;
                    case 2:
                        Room room = new Room(heading+ " Room Record");
                        room.Show();
                        break;
                    case 3:
                        Bed bed = new Bed(heading + " Bed Record");
                        bed.Show();
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
            }
            else
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
            }
        }
    }
}

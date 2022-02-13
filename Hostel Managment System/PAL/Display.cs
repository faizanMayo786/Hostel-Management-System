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
    public partial class Display : Form
    {
        private int type;
        public Display(int type)
        {

            InitializeComponent();
            this.type = type;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void DisplayRecord_Load(object sender, EventArgs e)
        {
            switch (type)
            {
                case 0:
                    txtShow.Text = "Allottee Record";
                    grdDisplay.DataSource = DataSource.Data.allotte;
                    break;

                case 1:
                    txtShow.Text = "Payment Record";
                    grdDisplay.DataSource = DataSource.Data.payment;
                    break;

                case 2:
                    txtShow.Text = "Room Record";
                    grdDisplay.DataSource = DataSource.Data.room;
                    break;

                case 3:
                    txtShow.Text = "Bed Record";
                    grdDisplay.DataSource = DataSource.Data.bed;
                    break;

                default:
                    break;
            }
        }

        private void Display_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
            this.Hide();
        }
    }
}

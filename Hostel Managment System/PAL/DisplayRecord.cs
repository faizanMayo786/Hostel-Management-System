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
    public partial class DisplayRecord : Form
    {
        public DisplayRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbRecordType.SelectedIndex != -1)
            {
                button1.Tag = "Display";
                Display display = new Display(cmbRecordType.SelectedIndex);
                this.Close();
                display.Show();
            }
            else
            {
                MessageBox.Show("Choose Record Type!");
            }
        }

        private void DisplayRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            if (button1.Tag.ToString() == "Display")
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

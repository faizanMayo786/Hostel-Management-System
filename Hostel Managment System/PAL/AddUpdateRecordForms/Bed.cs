using Hostel_Managment_System.BAL.Bed;
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
    public partial class Bed : Form
    {
        private string heading;
        public Bed(string heading)
        {

            InitializeComponent();
            this.heading = heading;
            lblText.Text = heading;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() != "")
            {
                BedModel bed = new BedModel(
                    txtID.Text,
                    cmbStatus.Text.ToString()
                );
                DataSource.Data.bed.Add(bed);

                MessageBox.Show("Record Added Successfully!");

                this.Close();
            }
            else
            {
                MessageBox.Show("Record Not " + heading + "ed");

            }
        }

        private void Bed_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}

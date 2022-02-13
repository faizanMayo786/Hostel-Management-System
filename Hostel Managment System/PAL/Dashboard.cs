using Hostel_Managment_System.BAL.Allotte;
using Hostel_Managment_System.BAL.Bed;
using Hostel_Managment_System.BAL.Payment;
using Hostel_Managment_System.BAL.Room;
using Hostel_Managment_System.PAL.AddUpdateRecordForms;
using Microsoft.Build.Tasks;
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
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
        }



        private void pbxAdd_Click(object sender, EventArgs e)
        {
            Add_Record add = new Add_Record("Add");
            this.Hide();
            add.Show();
        }

        private void pbxUpdate_Click(object sender, EventArgs e)
        {
            Add_Record update = new Add_Record("Update");
            this.Hide();
            update.Show();
        }

        private void pbxDelete_Click(object sender, EventArgs e)
        {
            DeleteRecord delete = new DeleteRecord();
            this.Hide();
            delete.Show();
        }

        private void pbxSearch_Click(object sender, EventArgs e)
        {
            SearchRecord search = new SearchRecord();
            this.Hide();
            search.Show();
        }

        private void pbxDisplay_Click(object sender, EventArgs e)
        {
            DisplayRecord display = new DisplayRecord();
            this.Hide();
            display.Show();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
            
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }
    }
}

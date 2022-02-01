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
        private BedModel bed1;
        private int index;
        public Bed(string heading, BedModel bed, int index)


        {
            this.index = index;
            this.bed1 = bed;
            InitializeComponent();
            this.heading = heading;
            lblText.Text = heading;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbRoomID.SelectedIndex != -1)
            {
                if (txtID.Text.Trim() != "")
                {
                    BedModel bed = new BedModel(
                        txtID.Text,
                        cmbStatus.Text.ToString()
                    );
                    if (heading.Contains("Add"))
                    {
                        DataSource.Data.bed.Add(bed);
                        DataSource.Data.room[cmbRoomID.SelectedIndex].AllottBed(bed);
                        DataSource.CRUD.CreateRecord.Bed.AddBedRecord(bed);
                        DataSource.CRUD.UpdateRecord.Room.UpdateRoomRecord(DataSource.Data
                             .room[cmbRoomID.SelectedIndex]);
                        MessageBox.Show("Record Added Successfully!");

                    }
                    else
                    {
                        DataSource.Data.bed[index] = bed;
                        DataSource.Data.room[cmbRoomID.SelectedIndex].UpdateBed(bed);
                        DataSource.CRUD.UpdateRecord.Bed.UpdateBedRecord(bed);
                        DataSource.CRUD.UpdateRecord.Room.UpdateRoomRecord(DataSource.Data
                             .room[cmbRoomID.SelectedIndex]);
                        MessageBox.Show("Record Updated Successfully!");

                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Record Not " + heading + "ed!");
                }
            }
            else
            {
                MessageBox.Show("Choose Room ID!");
            }
        }

        private void Bed_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void Bed_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            if (heading.Contains("Add"))
            {
                cmbStatus.Enabled = false;
            }
            else
            {
                txtID.Text = bed1.ID;
                cmbStatus.Text = bed1.Status;
            }
            List<string> room = new List<string>();
            foreach (var item in DataSource.Data.room)
            {
                room.Add(item.ID);
            }
            cmbRoomID.DataSource = room;
        }

        private void cmbRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (heading.Contains("Add"))
                txtID.Enabled = true;
            cmbStatus.Enabled = true;
        }
    }
}

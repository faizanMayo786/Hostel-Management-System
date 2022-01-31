using Hostel_Managment_System.BAL.Room;
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
    public partial class Room : Form
    {
        private string heading;
        private RoomModel room1;
        private int index;
        public Room(string heading, RoomModel room, int index)
        {
            this.index = index;
            this.room1 = room;
            InitializeComponent();
            this.heading = heading;
            lblText.Text = heading;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() != "")
            {
                RoomModel room = new RoomModel(
                    txtFloor.Text,
                    txtID.Text
                );
                if (heading.Contains("Add"))
                {
                    DataSource.Data.room.Add(room);
                    MessageBox.Show("Record Added Successfully!");
                }
                else
                {
                    DataSource.Data.room[index] = room;
                    MessageBox.Show("Record Updated Successfully!");

                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Record Not " + heading + "ed");

            }
        }

        private void Room_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void Room_Load(object sender, EventArgs e)
        {
            if (!heading.Contains("Add"))
            {
                txtID.Text = room1.ID;
                txtFloor.Text = room1.RoomFloor;
                txtID.Enabled = false;
            }
        }
    }
}

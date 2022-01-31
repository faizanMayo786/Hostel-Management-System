﻿using Hostel_Managment_System.BAL.Room;
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
        public Room(string heading)
        {

            InitializeComponent();
            this.heading = heading;
            lblText.Text = heading;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() != "")
            {
                RoomModel room = new RoomModel(
                    txtNoOfBed.Text,
                    txtFloor.Text,
                    txtID.Text,
                    txtNoOfAllottee.Text
                );
                DataSource.Data.room.Add(room);
                MessageBox.Show("Record Added Successfully!");
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Record Not "+ heading+"ed");

            }
        }

        private void Room_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}

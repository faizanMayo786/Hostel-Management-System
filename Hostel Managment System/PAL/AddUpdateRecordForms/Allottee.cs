using Hostel_Managment_System.BAL.Allotte;
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
    public partial class Allottee : Form
    {
        private string heading;
        private AllotteeModel allottee1;
        private int index;
        public Allottee(string heading, AllotteeModel allottee, int index)
        {
            InitializeComponent();
            this.index = index;
            allottee1 = allottee;
            lblText.Text = heading;
            this.heading = heading;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (cmbRoomID.SelectedIndex != -1)
            {
                if (txtID.Text.Trim() != "")
                {
                    AllotteeModel allotte = new AllotteeModel(
                        txtID.Text,
                        txtCNIC.Text,
                        txtDOB.Text,
                        txtPhoneNo.Text,
                        txtName.Text,
                        txtAddress.Text,
                        cmbBedID.SelectedItem.ToString(),
                        cmbRoomID.SelectedItem.ToString()

                    );
                    DataSource.Data.bed[cmbBedID.SelectedIndex].AllotteID = allotte.ID;
                    DataSource.CRUD.UpdateRecord.Bed.UpdateBedRecord(DataSource.Data.bed[cmbBedID.SelectedIndex]);
                    DataSource.Data.room[cmbRoomID.SelectedIndex].UpdateBed(DataSource.Data.bed[cmbBedID.SelectedIndex]);
                    if (heading.Contains("Add"))
                    {
                        DataSource.Data.allotte.Add(allotte);
                        DataSource.Data
                            .room[cmbRoomID.SelectedIndex]
                            .AllottRoom(allotte);
                        DataSource.CRUD.CreateRecord.Allottee.AddAllotteeRecord(allotte);
                        DataSource.Data.room[cmbRoomID.SelectedIndex].
                            UpdateBed(DataSource.Data.bed[cmbBedID.SelectedIndex]);
                        DataSource.CRUD.UpdateRecord.Room.UpdateRoomRecord(DataSource.Data
                            .room[cmbRoomID.SelectedIndex]);
                        MessageBox.Show("Record " + heading + " Successfully!");
                    }
                    else
                    {
                        DataSource.Data.allotte[index] = allotte;
                        DataSource.Data
                            .room[cmbRoomID.SelectedIndex]
                            .UpdateAllott(allotte);
                        DataSource.CRUD.UpdateRecord.Allottee.UpdateAllotteeRecord(allotte);
                        DataSource.CRUD.UpdateRecord.Room.UpdateRoomRecord(DataSource.Data
                              .room[cmbRoomID.SelectedIndex]);
                        MessageBox.Show("Record " + heading + " Successfully!");

                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Record Not " + heading + "ed");
                }
            }
            else
            {
                MessageBox.Show("Choose Room ID!");

            }
        }

        private void Allottee_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }

        private void Allottee_Load(object sender, EventArgs e)
        {
            List<string> room = new List<string>();
            foreach (var item in DataSource.Data.room)
            {
                room.Add(item.ID);
            }
            cmbRoomID.DataSource = room;
            cmbRoomID.Text = "Choose Room ID...";
            cmbBedID.Text = "Choose Bed ID...";

            if (heading.Contains("Add"))
            {

                txtID.Enabled = false;
                txtCNIC.Enabled = false;
                txtDOB.Enabled = false;
                txtPhoneNo.Enabled = false;
                txtName.Enabled = false;
                txtAddress.Enabled = false;
                cmbBedID.Enabled = false;
            }
            else
            {
                cmbRoomID.Text = allottee1.roomId;
                txtID.Text = allottee1.ID;
                txtID.Enabled = false;
                txtCNIC.Text = allottee1.CNIC;
                txtDOB.Text = allottee1.DOB;
                txtPhoneNo.Text = allottee1.PhoneNumber;
                txtName.Text = allottee1.Name;
                cmbBedID.Text = allottee1.bedId;
                txtAddress.Text = allottee1.Address;
            }

        }

        private void cmbRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (heading.Contains("Add"))
                txtID.Enabled = true;
            txtCNIC.Enabled = true;
            txtDOB.Enabled = true;
            txtPhoneNo.Enabled = true;
            txtName.Enabled = true;
            cmbBedID.Enabled = true;
            txtAddress.Enabled = true;
            List<string> bed = new List<string>();
            foreach (var item in DataSource.Data.bed)
            {
                if (cmbRoomID.SelectedItem.ToString() == item.RoomId)
                    bed.Add(item.ID);
            }
            cmbBedID.DataSource = bed;
        }
    }
}

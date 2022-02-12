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
    public partial class DeleteRecord : Form
    {
        public DeleteRecord()
        {
            InitializeComponent();
        }

        private void DeleteRecord_Load(object sender, EventArgs e)
        {
            cmbID.Enabled = false;
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex != -1)
            {
                switch (cmbType.SelectedIndex)
                {
                    case 0:
                        List<string> allottee = new List<string>();
                        foreach (var item in DataSource.Data.allotte)
                        {
                            allottee.Add(item.ID);
                        }
                        cmbID.Enabled = true;
                        cmbID.DataSource = allottee;
                        break;
                    case 1:
                        List<string> payment = new List<string>();
                        foreach (var item in DataSource.Data.payment)
                        {
                            payment.Add(item.ID);
                        }
                        cmbID.Enabled = true;
                        cmbID.DataSource = payment;
                        break;
                    case 2:
                        List<string> room = new List<string>();
                        foreach (var item in DataSource.Data.room)
                        {
                            room.Add(item.ID);
                        }
                        cmbID.Enabled = true;
                        cmbID.DataSource = room;
                        break;
                    case 3:
                        List<string> bed = new List<string>();
                        foreach (var item in DataSource.Data.bed)
                        {
                            bed.Add(item.ID);
                        }
                        cmbID.Enabled = true;
                        cmbID.DataSource = bed;
                        break;
                    default:
                        break;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex != -1)
            {
                if (cmbID.Enabled || cmbID.SelectedIndex != -1)
                {
                    if (cmbID.SelectedItem != null)
                    {
                        switch (cmbType.SelectedIndex)
                        {
                            case 0:
                                foreach (var room in DataSource.Data.room)
                                {
                                    if (room.ID == cmbID.SelectedItem.ToString())
                                    {
                                        room.RemoveAllott(DataSource.Data.allotte[cmbID.SelectedIndex]);

                                    }
                                }
                                DataSource.Data.allotte.RemoveAt(cmbID.SelectedIndex);
                                DataSource.CRUD.DeleteRecord.Allottee.DeleteAllotteeRecord(cmbID.SelectedItem.ToString());
                                MessageBox.Show("Record Deleted");
                                this.Close();
                                break;
                            case 1:
                                DataSource.Data.payment.RemoveAt(cmbID.SelectedIndex);
                                DataSource.CRUD.DeleteRecord.Payment.DeletePaymentRecord(cmbID.SelectedItem.ToString());
                                MessageBox.Show("Record Deleted");
                                this.Close();
                                break;
                            case 2:
                                DataSource.Data.room.RemoveAt(cmbID.SelectedIndex);
                                DataSource.CRUD.DeleteRecord.Room.DeleteRoomRecord(cmbID.SelectedItem.ToString());
                                MessageBox.Show("Record Deleted");
                                this.Close();
                                break;
                            case 3:
                                DataSource.Data.bed.RemoveAt(cmbID.SelectedIndex);
                                DataSource.CRUD.DeleteRecord.Bed.DeleteBedRecord(cmbID.SelectedItem.ToString());
                                MessageBox.Show("Record Deleted");
                                this.Close();
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        MessageBox.Show("No Record to Delete!");
                    }
                }
                else
                {
                    MessageBox.Show("Choose Record Type!");
                }
            }
            else
            {
                MessageBox.Show("Choose Record Type!");
            }
        }

        private void DeleteRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Dashboard dashboard = new Dashboard();
            dashboard.Show();
        }
    }
}

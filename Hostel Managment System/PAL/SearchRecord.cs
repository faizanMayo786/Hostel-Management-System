using System;
using System.Windows.Forms;

namespace Hostel_Managment_System.PAL.AddUpdateRecordForms
{
    public partial class SearchRecord : Form
    {
        public SearchRecord()
        {
            InitializeComponent();
        }

        private void SearchRecord_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            int found = 0;
            if (cmbType.SelectedIndex != -1)
            {
                if (txtID.Enabled)
                {
                    switch (cmbType.SelectedIndex)
                    {
                        case 0:
                            foreach (var item in DataSource.Data.allotte)
                            {
                                if (item.ID == txtID.Text)
                                {


                                    MessageBox.Show("Record Found!");
                                    found = 1;
                                }
                            }
                            this.Close();
                            break;
                        case 1:
                            foreach (var item in DataSource.Data.payment)
                            {
                                if (item.ID == txtID.Text)
                                {
                                    found = 1;
                                    MessageBox.Show("Record Found!");
                                }
                            }
                            this.Close();
                            break;
                        case 2:
                            foreach (var item in DataSource.Data.room)
                            {
                                if (item.ID == txtID.Text)
                                {
                                    found = 1;
                                    MessageBox.Show("Record Found!");
                                }
                            }
                            this.Close();
                            break;
                        case 3:
                            foreach (var item in DataSource.Data.bed)
                            {
                                if (item.ID == txtID.Text)
                                {
                                    found = 1;
                                    MessageBox.Show("Record Found!");
                                }
                            }
                            this.Close();
                            break;
                        default:
                            break;
                    }
                    if (found == 0)
                    {
                        MessageBox.Show("Record not Found!");
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

        private void cmbType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbType.SelectedIndex != -1)
            {
                txtID.Enabled = true;

            }
        }

        private void SearchRecord_FormClosing(object sender, FormClosingEventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            this.Hide();
            dashboard.Show();
        }
    }
}

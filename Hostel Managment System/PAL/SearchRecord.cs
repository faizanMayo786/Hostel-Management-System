using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            if (cmbType.SelectedIndex != -1)
            {
                if (txtID.Enabled)
                {
                    switch (cmbType.SelectedIndex)
                    {
                        case 0:
                            foreach (var item in DataSource.Data.allotte)
                            {
                                if (item.AllotteeID == txtID.Text)
                                {

                                    MessageBox.Show("Record Found!");
                                }
                            }
                            this.Close();
                            break;

                        case 1:
                            foreach (var item in DataSource.Data.payment)
                            {
                                if (item.ID == txtID.Text)
                                {
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
                                    MessageBox.Show("Record Found!");
                                }
                            }
                            this.Close();
                            break;

                        default:
                            break;


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
    }
}

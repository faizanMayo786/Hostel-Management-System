﻿using System;
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
    public partial class Payment : Form
    {
        public Payment(string heading)
        {

            InitializeComponent();
            lblText.Text = heading;
        }
    }
}

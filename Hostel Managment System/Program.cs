﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Managment_System
{
    static class Program
    {


        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            DataSource.CRUD.ReadRecord.Allottee.GetAllotteeRecord();
            DataSource.CRUD.ReadRecord.Bed.GetBedRecord();
            DataSource.CRUD.ReadRecord.Payment.GetPaymentRecord();
            DataSource.CRUD.ReadRecord.Room.GetRoomRecord();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            PAL.Login login = new PAL.Login();
            login.Show();
            Application.Run();
        }
    }
}

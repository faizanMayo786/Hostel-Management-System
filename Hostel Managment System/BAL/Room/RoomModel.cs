﻿using Hostel_Managment_System.BAL.Allotte;
using Hostel_Managment_System.BAL.Bed;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hostel_Managment_System.BAL.Room
{
    public class RoomModel
    {
        protected AllotteeModel[] allottee = new AllotteeModel[4];
        protected BedModel[] bed = new BedModel[4];
        public string ID { get; set; }
        public string RoomFloor { get; set; }
        public int NoOfBed { get; set; }
        public int NoOfAllottee { get; set; }
        public RoomModel(string roomFloor, string id)
        {
            ID = id;
            RoomFloor = roomFloor;
        }

        public void AllottBed(BedModel bed)
        {
            this.bed[NoOfBed] = bed;
            NoOfBed = (NoOfBed + 1) % 4;
        }
        public void AllottRoom(AllotteeModel allottee)
        {
            this.allottee[NoOfAllottee] = allottee;
            NoOfAllottee = (NoOfAllottee + 1) % 4;
        }
        public void UpdateBed(BedModel bed)
        {
            for (int i = 0; i < NoOfBed; i++)
            {
                if (bed.ID == this.bed[i].ID)
                {
                    this.bed[i] = bed;
                }
            }
        }
        public void UpdateAllott(AllotteeModel allottee)
        {
            for (int i = 0; i < NoOfAllottee; i++)
            {
                if (allottee.ID == this.allottee[i].ID)
                {
                    this.allottee[i] = allottee;
                }
            }
        }
    }
}

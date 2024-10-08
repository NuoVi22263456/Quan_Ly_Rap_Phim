﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Cinema_DTO
    {
        public Cinema_DTO(string iD, string name, string screenType, int seats,
            string status, int row, int seatInRow)
        {
            this.ID = iD;
            this.Name = name;
            this.ScreenTypeID = screenType;
            this.Seats = seats;
            this.Status = status;
            this.Row = row;
            this.SeatInRow = seatInRow;
        }

        public Cinema_DTO(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.Name = row["TenPhong"].ToString();
            this.ScreenTypeID = row["idManHinh"].ToString();
            this.Seats = (int)row["SoChoNgoi"];
            this.Status = row["TinhTrang"].ToString();
            this.Row = (int)row["SoHangGhe"];
            this.SeatInRow = (int)row["SoGheMotHang"];
        }

        public string ID { get; set; }

        public string Name { get; set; }

        public string ScreenTypeID { get; set; }

        public int Seats { get; set; }

        public string Status { get; set; }

        public int Row { get; set; }

        public int SeatInRow { get; set; }
    }
}

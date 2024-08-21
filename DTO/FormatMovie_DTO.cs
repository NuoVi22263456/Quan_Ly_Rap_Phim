using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public  class FormatMovie_DTO
    {
        public FormatMovie_DTO(string iD, string movieName, string screenTypeName)
        {
            this.ID = iD;
            this.MovieName = movieName;
            this.ScreenTypeName = screenTypeName;
        }

        public FormatMovie_DTO(DataRow row)
        {
            this.ID = row["id"].ToString();
            this.MovieName = row["TenPhim"].ToString();
            this.ScreenTypeName = row["TenMH"].ToString();
        }

        public string ID { get; set; }

        public string MovieName { get; set; }

        public string ScreenTypeName { get; set; }
    }
}

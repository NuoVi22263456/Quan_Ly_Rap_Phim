﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
   public class ShowTimes_DAO
    {
        public static DataTable GetListShowTimeByFormatMovie(string formatMovieID, DateTime date)
        {
            string query = "USP_GetListShowTimesByFormatMovie @ID , @Date";
            return DataProvider.ExecuteQuery(query, new object[] { formatMovieID, date });
        }
        public static List<ShowTimes_DTO> GetAllListShowTimes()
        {
            List<ShowTimes_DTO> listShowTimes = new List<ShowTimes_DTO>();
            DataTable data = DataProvider.ExecuteQuery("USP_GetAllListShowTimes");
            foreach (DataRow row in data.Rows)
            {
                ShowTimes_DTO showTimes = new ShowTimes_DTO(row);
                listShowTimes.Add(showTimes);
            }
            return listShowTimes;
        }
        public static List<ShowTimes_DTO> GetListShowTimesNotCreateTickets()
        {
            List<ShowTimes_DTO> listShowTimes = new List<ShowTimes_DTO>();
            DataTable data = DataProvider.ExecuteQuery("USP_GetListShowTimesNotCreateTickets");
            foreach (DataRow row in data.Rows)
            {
                ShowTimes_DTO showTimes = new ShowTimes_DTO(row);
                listShowTimes.Add(showTimes);
            }
            return listShowTimes;
        }
        public static int UpdateStatusShowTimes(string showTimesID, int status)
        {
            string query = "USP_UpdateStatusShowTimes @idLichChieu , @status";
            return DataProvider.ExecuteNonQuery(query, new object[] { showTimesID, status });
        }

        public static DataTable GetListShowtime()
        {
            return DataProvider.ExecuteQuery("EXEC USP_GetShowtime");
        }

        public static bool InsertShowtime(string id, string cinemaID, string formatMovieID, DateTime time, float ticketPrice)
        {
            int result = DataProvider.ExecuteNonQuery("EXEC USP_InsertShowtime @id , @idPhong , @idDinhDang , @thoiGianChieu , @giaVe ", new object[] { id, cinemaID, formatMovieID, time, ticketPrice });
            return result > 0;
        }

        public static bool UpdateShowtime(string id, string cinemaID, string formatMovieID, DateTime time, float ticketPrice)
        {
            string command = string.Format("USP_UpdateShowtime @id , @idPhong , @idDinhDang , @thoiGianChieu , @giaVe ");
            int result = DataProvider.ExecuteNonQuery(command, new object[] { id, cinemaID, formatMovieID, time, ticketPrice });
            return result > 0;
        }

        public static bool DeleteShowtime(string id)
        {
            Ticket_DAO.DeleteTicketsByShowTimes(id);

            int result = DataProvider.ExecuteNonQuery("DELETE dbo.LichChieu WHERE id = '" + id + "'");
            return result > 0;
        }

        public static DataTable SearchShowtimeByMovieName(string movieName)
        {
            DataTable data = DataProvider.ExecuteQuery("EXEC USP_SearchShowtimeByMovieName @tenPhim ", new object[] { movieName });
            return data;
        }
    }
}

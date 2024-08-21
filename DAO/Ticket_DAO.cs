using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class Ticket_DAO
    {
        public static List<Ticket_DTO> GetListTicketsByShowTimes(string showTimesID)
        {
            List<Ticket_DTO> listTicket = new List<Ticket_DTO>();
            string query = "select * from Ve where idLichChieu = '" + showTimesID + "'";
            DataTable data = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Ticket_DTO ticket = new Ticket_DTO(row);
                listTicket.Add(ticket);
            }
            return listTicket;
        }

        public static List<Ticket_DTO> GetListTicketsBoughtByShowTimes(string showTimesID)
        {
            List<Ticket_DTO> listTicket = new List<Ticket_DTO>();
            string query = "select * from Ve where idLichChieu = '" + showTimesID + "' and TrangThai = 1";
            DataTable data = DataProvider.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                Ticket_DTO ticket = new Ticket_DTO(row);
                listTicket.Add(ticket);
            }
            return listTicket;
        }

        public static int CountToltalTicketByShowTime(string showTimesID)
        {
            string query = "Select count (id) from Ve where idLichChieu ='" + showTimesID + "'";
            return (int)DataProvider.ExecuteScalar(query);
        }
        public static int CountTheNumberOfTicketsSoldByShowTime(string showTimesID)
        {
            string query = "Select count (id) from Ve where idLichChieu ='" + showTimesID + "' and TrangThai = 1 ";
            return (int)DataProvider.ExecuteScalar(query);
        }
        public static int BuyTicket(string ticketID, int type, float price)
        {
            string query = "Update dbo.Ve set TrangThai = 1, LoaiVe = "
                + type + ", TienBanVe =" + price + " where id = '" + ticketID + "'";
            return DataProvider.ExecuteNonQuery(query);
        }
        public static int BuyTicket(string ticketID, int type, string customerID, float price)
        {
            string query = "Update dbo.Ve set TrangThai = 1, LoaiVe = " + type
                + ", idKhachHang =N'" + customerID + "', TienBanVe =" + price + " where id = '" + ticketID + "'";
            return DataProvider.ExecuteNonQuery(query);
        }

        public static int InsertTicketByShowTimes(string showTimesID, string seatName)
        {
            string query = "USP_InsertTicketByShowTimes @idlichChieu , @maGheNgoi";
            return DataProvider.ExecuteNonQuery(query, new object[] { showTimesID, seatName });
        }

        public static int DeleteTicketsByShowTimes(string showTimesID)
        {
            string query = "USP_DeleteTicketsByShowTimes @idlichChieu";
            return DataProvider.ExecuteNonQuery(query, new object[] { showTimesID });
        }
    }
}

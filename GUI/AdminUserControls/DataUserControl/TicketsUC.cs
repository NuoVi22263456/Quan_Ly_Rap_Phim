using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.AdminUserControls.DataUserControl
{
    public partial class TicketsUC : UserControl
    {
        public TicketsUC()
        {
            InitializeComponent();
            LoadAllListShowTimes();
        }

        void LoadAllListShowTimes()
        {
            lsvAllListShowTimes.Items.Clear();

            List<ShowTimes_DTO> allListShowTime = ShowTimes_DAO.GetAllListShowTimes();
            foreach (ShowTimes_DTO showTimes in allListShowTime)
            {
                ListViewItem lvi = new ListViewItem(showTimes.CinemaName);
                lvi.SubItems.Add(showTimes.MovieName);
                lvi.SubItems.Add(showTimes.Time.ToString("HH:mm:ss dd/MM/yyyy"));
                lvi.Tag = showTimes;

                if (showTimes.Status == 1)
                {
                    lvi.SubItems.Add("Đã tạo");
                }
                else
                {
                    lvi.SubItems.Add("Chưa Tạo");
                }
                lsvAllListShowTimes.Items.Add(lvi);
            }
        }

        void LoadTicketsByShowTimes(string showTimesID)
        {
            List<Ticket_DTO> listTicket = Ticket_DAO.GetListTicketsByShowTimes(showTimesID);
            dtgvTicket.DataSource = listTicket;
        }
        void LoadTicketsBoughtByShowTimes(string showTimesID)
        {
            List<Ticket_DTO> listTicket = Ticket_DAO.GetListTicketsBoughtByShowTimes(showTimesID);
            dtgvTicket.DataSource = listTicket;
        }

        void AutoCreateTicketsByShowTimes(ShowTimes_DTO showTimes)
        {
            int result = 0;
            Cinema_DTO cinema = Cinema_DAO.GetCinemaByName(showTimes.CinemaName);
            int Row = cinema.Row;
            int Column = cinema.SeatInRow;
            for (int i = 0; i < Row; i++)
            {
                int temp = i + 65;
                char nameRow = (char)(temp);
                for (int j = 1; j <= Column; j++)
                {
                    string seatName = nameRow.ToString() + j;
                    result += Ticket_DAO.InsertTicketByShowTimes(showTimes.ID, seatName);
                }
            }
            if (result == Row * Column)
            {
                int ret = ShowTimes_DAO.UpdateStatusShowTimes(showTimes.ID, 1);
                if (ret > 0)
                    MessageBox.Show("TẠO VÉ TỰ ĐỘNG THÀNH CÔNG!", "THÔNG BÁO");
            }
            else
                MessageBox.Show("TẠO VÉ TỰ ĐỘNG THẤT BẠI!", "THÔNG BÁO");
        }

        private void btnAddTicketsByShowTime_Click(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count > 0)
            {
                ShowTimes_DTO showTimes = lsvAllListShowTimes.SelectedItems[0].Tag as ShowTimes_DTO;
                if (showTimes.Status == 1)
                {
                    MessageBox.Show("LỊCH CHIẾU NÀY ĐÃ ĐƯỢC TẠO VÉ!!!", "THÔNG BÁO");
                    return;
                }
                AutoCreateTicketsByShowTimes(showTimes);
                LoadAllListShowTimes();
                LoadTicketsByShowTimes(showTimes.ID);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ TẠO!!!", "THÔNG BÁO");
            }
        }

        private void lsvAllListShowTimes_Click(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count > 0)
            {
                ShowTimes_DTO showTimes = lsvAllListShowTimes.SelectedItems[0].Tag as ShowTimes_DTO;
                LoadTicketsByShowTimes(showTimes.ID);
            }
        }

        private void btnDeleteTicketsByShowTime_Click(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count > 0)
            {
                ShowTimes_DTO showTimes = lsvAllListShowTimes.SelectedItems[0].Tag as ShowTimes_DTO;
                if (showTimes.Status == 0)
                {
                    MessageBox.Show("LỊCH CHIẾU NÀY CHƯA ĐƯỢC TẠO VÉ!!!", "THÔNG BÁO");
                    return;
                }
                DeleteTicketsByShowTimes(showTimes);
                LoadAllListShowTimes();
                LoadTicketsByShowTimes(showTimes.ID);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XÓA!!!", "THÔNG BÁO");
            }
        }

        private void DeleteTicketsByShowTimes(ShowTimes_DTO showTimes)
        {
            Cinema_DTO cinema = Cinema_DAO.GetCinemaByName(showTimes.CinemaName);
            int Row = cinema.Row;
            int Column = cinema.SeatInRow;
            int result = Ticket_DAO.DeleteTicketsByShowTimes(showTimes.ID);
            if (result == Row * Column)
            {
                int ret = ShowTimes_DAO.UpdateStatusShowTimes(showTimes.ID, 0);
                if (ret > 0)
                    MessageBox.Show("XÓA TẤT CẢ CÁC VÉ CỦA LỊCH CHIẾU ID=" + showTimes.ID + " THÀNH CÔNG!", "THÔNG BÁO");
            }
            else
                MessageBox.Show("XÓA TẤT CẢ CÁC VÉ CỦA LỊCH CHIẾU ID=" + showTimes.ID + " THẤT BẠI!", "THÔNG BÁO");
        }

        private void btnAllListShowTimes_Click(object sender, EventArgs e)
        {
            LoadAllListShowTimes();
        }

        private void btnShowShowTimeNotCreateTickets_Click(object sender, EventArgs e)
        {
            LoadListShowTimesNotCreateTickets();
        }

        private void LoadListShowTimesNotCreateTickets()
        {
            lsvAllListShowTimes.Items.Clear();

            List<ShowTimes_DTO> allListShowTime = ShowTimes_DAO.GetListShowTimesNotCreateTickets();
            foreach (ShowTimes_DTO showTimes in allListShowTime)
            {
                ListViewItem lvi = new ListViewItem(showTimes.CinemaName);
                lvi.SubItems.Add(showTimes.MovieName);
                lvi.SubItems.Add(showTimes.Time.ToString("HH:mm:ss dd/MM/yyyy"));
                lvi.Tag = showTimes;

                if (showTimes.Status == 1)
                {
                    lvi.SubItems.Add("Đã tạo");
                }
                else
                {
                    lvi.SubItems.Add("Chưa Tạo");
                }
                lsvAllListShowTimes.Items.Add(lvi);
            }
        }

        private void btnShowAllTicketsBoughtByShowTime_Click(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count > 0)
            {
                ShowTimes_DTO showTimes = lsvAllListShowTimes.SelectedItems[0].Tag as ShowTimes_DTO;
                LoadTicketsBoughtByShowTimes(showTimes.ID);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XEM!!!", "THÔNG BÁO");
            }
        }

        private void btnShowAllTicketsByShowTime_Click(object sender, EventArgs e)
        {
            if (lsvAllListShowTimes.SelectedItems.Count > 0)
            {
                ShowTimes_DTO showTimes = lsvAllListShowTimes.SelectedItems[0].Tag as ShowTimes_DTO;
                LoadTicketsByShowTimes(showTimes.ID);
            }
            else
            {
                MessageBox.Show("BẠN CHƯA CHỌN LỊCH CHIẾU ĐỂ XEM!!!", "THÔNG BÁO");
            }
        }

        private void lsvAllListShowTimes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvTicket_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel61_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

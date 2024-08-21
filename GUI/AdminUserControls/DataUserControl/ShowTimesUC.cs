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
    public partial class ShowTimesUC : UserControl
    {
        BindingSource showtimeList = new BindingSource();
        public ShowTimesUC()
        {
            InitializeComponent();
            LoadShowtime();
        }

        void LoadShowtime()
        {
            dtgvShowtime.DataSource = showtimeList;
            LoadShowtimeList();
            LoadFormatMovieIntoComboBox();
            AddShowtimeBinding();
        }
        void LoadShowtimeList()
        {
            showtimeList.DataSource = ShowTimes_DAO.GetListShowtime();
        }
        private void btnShowShowtime_Click(object sender, EventArgs e)
        {
            LoadShowtimeList();
        }

        //Binding
        void AddShowtimeBinding()
        {
            txtShowtimeID.DataBindings.Add("Text", dtgvShowtime.DataSource, "Mã lịch chiếu", true, DataSourceUpdateMode.Never);
            dtmShowtimeDate.DataBindings.Add("Value", dtgvShowtime.DataSource, "Thời gian chiếu", true, DataSourceUpdateMode.Never);
            dtmShowtimeTime.DataBindings.Add("Value", dtgvShowtime.DataSource, "Thời gian chiếu", true, DataSourceUpdateMode.Never);
            txtTicketPrice_Showtime.DataBindings.Add("Text", dtgvShowtime.DataSource, "Giá vé", true, DataSourceUpdateMode.Never);
        }
        void LoadFormatMovieIntoComboBox()
        {
            cboFormatID_Showtime.DataSource = FormatMovie_DAO.GetFormatMovie();
            cboFormatID_Showtime.DisplayMember = "ID";
        }

        //Insert
        void InsertShowtime(string id, string cinemaID, string formatMovieID, DateTime time, float ticketPrice)
        {
            if (ShowTimes_DAO.InsertShowtime(id, cinemaID, formatMovieID, time, ticketPrice))
            {
                MessageBox.Show("Thêm lịch chiếu thành công");
            }
            else
            {
                MessageBox.Show("Thêm lịch chiếu thất bại");
            }
        }
        private void btnInsertShowtime_Click(object sender, EventArgs e)
        {
            string showtimeID = txtShowtimeID.Text;
            string cinemaID = ((Cinema_DTO)cboCinemaID_Showtime.SelectedItem).ID;
            string formatMovieID = ((FormatMovie_DTO)cboFormatID_Showtime.SelectedItem).ID;
            DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
            //Bind dtmShowtimeDate to "time.date" and dtmShowtimeTime to "time.time" ... TODO : Look for a better way to do this
            float ticketPrice = float.Parse(txtTicketPrice_Showtime.Text);
            InsertShowtime(showtimeID, cinemaID, formatMovieID, time, ticketPrice);
            LoadShowtimeList();
        }

        //Update
        void UpdateShowtime(string id, string cinemaID, string formatMovieID, DateTime time, float ticketPrice)
        {
            if (ShowTimes_DAO.UpdateShowtime(id, cinemaID, formatMovieID, time, ticketPrice))
            {
                MessageBox.Show("Sửa lịch chiếu thành công");
            }
            else
            {
                MessageBox.Show("Sửa lịch chiếu thất bại");
            }
        }
        private void btnUpdateShowtime_Click(object sender, EventArgs e)
        {
            string showtimeID = txtShowtimeID.Text;
            string cinemaID = ((Cinema_DTO)cboCinemaID_Showtime.SelectedItem).ID;
            string formatMovieID = ((FormatMovie_DTO)cboFormatID_Showtime.SelectedItem).ID;
            DateTime time = new DateTime(dtmShowtimeDate.Value.Year, dtmShowtimeDate.Value.Month, dtmShowtimeDate.Value.Day, dtmShowtimeTime.Value.Hour, dtmShowtimeTime.Value.Minute, dtmShowtimeTime.Value.Second);
            //Bind dtmShowtimeDate to "time.date" and dtmShowtimeTime to "time.time" ... TODO : Look for a better way to do this
            float ticketPrice = float.Parse(txtTicketPrice_Showtime.Text);
            UpdateShowtime(showtimeID, cinemaID, formatMovieID, time, ticketPrice);
            LoadShowtimeList();
        }

        //Delete
        void DeleteShowtime(string id)
        {
            if (ShowTimes_DAO.DeleteShowtime(id))
            {
                MessageBox.Show("Xóa lịch chiếu thành công");
            }
            else
            {
                MessageBox.Show("Xóa lịch chiếu thất bại");
            }
        }
        private void btnDeleteShowtime_Click(object sender, EventArgs e)
        {
            string showtimeID = txtShowtimeID.Text;
            DeleteShowtime(showtimeID);
            LoadShowtimeList();
        }

        //Search
        private void btnSearchShowtime_Click(object sender, EventArgs e)
        {
            string movieName = txtSearchShowtime.Text;
            showtimeList.DataSource = ShowTimes_DAO.SearchShowtimeByMovieName(movieName);
        }

        private void txtSearchShowtime_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchShowtime.PerformClick();
                e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
            }
        }

        private void dtgvShowtime_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtSearchShowtime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSearchShowtime_Click(object sender, EventArgs e)
        {

        }
    }
}

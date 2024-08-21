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

namespace GUI
{
    public partial class Seller : Form
    {
        public Seller()
        {
            InitializeComponent();
            dtpThoiGian.Value = DateTime.Now;
            LoadMovie(dtpThoiGian.Value);
        }
        private void Seller_Load(object sender, EventArgs e)
        {
            LoadMovie(dtpThoiGian.Value);
            timer1.Start();
        }

        private void LoadMovie(DateTime date)
        {
            cboFilmName.DataSource = Movie_DAO.GetListMovieByDate(date);
            cboFilmName.DisplayMember = "Name";
        }

        private void dtpThoiGian_ValueChanged(object sender, EventArgs e)
        {
            LoadMovie(dtpThoiGian.Value);
        }

        private void cboFilmName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboFilmName.SelectedIndex != -1)
            {
                cboFormatFilm.DataSource = null;
                lvLichChieu.Items.Clear();
                Movie_DTO movie = cboFilmName.SelectedItem as Movie_DTO;
                cboFormatFilm.DataSource = FormatMovie_DAO.GetListFormatMovieByMovie(movie.ID);
                cboFormatFilm.DisplayMember = "ScreenTypeName";
            }
        }

        private void cboFormatFilm_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cboFormatFilm.SelectedIndex != -1)
            {
                lvLichChieu.Items.Clear();
                FormatMovie_DTO format = cboFormatFilm.SelectedItem as FormatMovie_DTO;
                LoadListShowTimeByFilm(format.ID);
            }
        }

        private void LoadListShowTimeByFilm(string formatMovieID)
        {
            DataTable data = ShowTimes_DAO.GetListShowTimeByFormatMovie(formatMovieID, dtpThoiGian.Value);
            //if (data == null) return;
            foreach (DataRow row in data.Rows)
            {
                ShowTimes_DTO showTimes = new ShowTimes_DTO(row);
                ListViewItem lvi = new ListViewItem("");
                lvi.SubItems.Add(showTimes.CinemaName);
                lvi.SubItems.Add(showTimes.MovieName);
                lvi.SubItems.Add(showTimes.Time.ToShortTimeString());
                lvi.Tag = showTimes;

                string statusShowTimes = Ticket_DAO.CountTheNumberOfTicketsSoldByShowTime(showTimes.ID)
                    + "/" + Ticket_DAO.CountToltalTicketByShowTime(showTimes.ID);

                lvi.SubItems.Add(statusShowTimes);

                float status = (float)Ticket_DAO.CountTheNumberOfTicketsSoldByShowTime(showTimes.ID)
                    / Ticket_DAO.CountToltalTicketByShowTime(showTimes.ID);

               

                lvLichChieu.Items.Add(lvi);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Load lại form để cập nhật cơ sở dữ liệu
            this.OnLoad(null);
        }


        private void lvLichChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvLichChieu.SelectedItems.Count > 0)
            {
                timer1.Stop();
                ShowTimes_DTO showTimes = lvLichChieu.SelectedItems[0].Tag as ShowTimes_DTO;
                Movie_DTO movie = cboFilmName.SelectedItem as Movie_DTO;
                Theatre frm = new Theatre(showTimes, movie);
                this.Hide();
                frm.ShowDialog();
                this.OnLoad(null);
                this.Show();
            }
        }
    }

}


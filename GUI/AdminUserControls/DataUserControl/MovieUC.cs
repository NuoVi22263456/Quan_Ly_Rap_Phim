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
    public partial class MovieUC : UserControl
    {
        BindingSource movieList = new BindingSource();
        public MovieUC()
        {
            InitializeComponent();
            LoadMovie();
        }
        void LoadMovie()
        {
            dtgvMovie.DataSource = movieList;
            LoadMovieList();
            AddMovieBinding();
        }
        void LoadMovieList()
        {
            movieList.DataSource = Movie_DAO.GetMovie();
        }
        private void btnShowMovie_Click(object sender, EventArgs e)
        {
            LoadMovieList();
        }
        void AddMovieBinding()
        {
            txtMovieID.DataBindings.Add("Text", dtgvMovie.DataSource, "Mã phim", true, DataSourceUpdateMode.Never);
            txtMovieName.DataBindings.Add("Text", dtgvMovie.DataSource, "Tên phim", true, DataSourceUpdateMode.Never);
            txtMovieDesc.DataBindings.Add("Text", dtgvMovie.DataSource, "Mô tả", true, DataSourceUpdateMode.Never);
            txtMovieLength.DataBindings.Add("Text", dtgvMovie.DataSource, "Thời lượng", true, DataSourceUpdateMode.Never);
            dtmMovieStart.DataBindings.Add("Value", dtgvMovie.DataSource, "Ngày khởi chiếu", true, DataSourceUpdateMode.Never);
            dtmMovieEnd.DataBindings.Add("Value", dtgvMovie.DataSource, "Ngày kết thúc", true, DataSourceUpdateMode.Never);
            txtMovieProductor.DataBindings.Add("Text", dtgvMovie.DataSource, "Sản xuất", true, DataSourceUpdateMode.Never);
            txtMovieDirector.DataBindings.Add("Text", dtgvMovie.DataSource, "Đạo diễn", true, DataSourceUpdateMode.Never);
            txtMovieYear.DataBindings.Add("Text", dtgvMovie.DataSource, "Năm SX", true, DataSourceUpdateMode.Never);
            LoadGenreIntoCheckedList(clbMovieGenre);
        }
        void LoadGenreIntoCheckedList(CheckedListBox checkedList)
        {
            List<Genre_DTO> genreList = Genre_DAO.GetListGenre();
            checkedList.DataSource = genreList;
            checkedList.DisplayMember = "Name";
        }
        private void txtMovieID_TextChanged(object sender, EventArgs e)
        //Use to binding the CheckedListBox Genre of Movie and picture of Movie
        {
            //picFilm.Image = null;
            for (int i = 0; i < clbMovieGenre.Items.Count; i++)
            {
                clbMovieGenre.SetItemChecked(i, false);
                //Uncheck all CheckBox first
            }

            List<Genre_DTO> listGenreOfMovie = MovieByGenre_DAO.GetListGenreByMovieID(txtMovieID.Text);
            for (int i = 0; i < clbMovieGenre.Items.Count; i++)
            {
                Genre_DTO genre = (Genre_DTO)clbMovieGenre.Items[i];
                foreach (Genre_DTO item in listGenreOfMovie)
                {
                    if (genre.ID == item.ID)
                    {
                        clbMovieGenre.SetItemChecked(i, true);
                        break;
                    }
                }
            }

            Movie_DTO movie = Movie_DAO.GetMovieByID(txtMovieID.Text);

            if (movie == null)
                return;

            //if (movie.Poster != null)
                //picFilm.Image = Movie_DAO.byteArrayToImage(movie.Poster);
        }

        void InsertMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            if (Movie_DAO.InsertMovie(id, name, desc, length, startDate, endDate, productor, director, year, image))
            {
                MessageBox.Show("Thêm phim thành công");
            }
            else
            {
                MessageBox.Show("Thêm phim thất bại");
            }
        }
        void InsertMovie_Genre(string movieID, CheckedListBox checkedListBox)
        //Insert into table 'PhanLoaiPhim'
        {
            List<Genre_DTO> checkedGenreList = new List<Genre_DTO>();
            foreach (Genre_DTO checkedItem in checkedListBox.CheckedItems)
            {
                checkedGenreList.Add(checkedItem);
            }
            MovieByGenre_DAO.InsertMovie_Genre(movieID, checkedGenreList);
        }

        private void btnUpLoadPictureFilm_Click(object sender, EventArgs e)
        {
            try
            {
                string filePathImage = null;
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
                openFile.FilterIndex = 1;
                openFile.RestoreDirectory = true;
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    filePathImage = openFile.FileName;
                    //picFilm.Image = Image.FromFile(filePathImage.ToString());
                }
            }
            catch (Exception)
            {
                return;
            }
        }

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string movieID = txtMovieID.Text;
            string movieName = txtMovieName.Text;
            string movieDesc = txtMovieDesc.Text;
            float movieLength = float.Parse(txtMovieLength.Text);
            DateTime startDate = dtmMovieStart.Value;
            DateTime endDate = dtmMovieEnd.Value;
            string productor = txtMovieProductor.Text;
            string director = txtMovieDirector.Text;
            int year = int.Parse(txtMovieYear.Text);
            InsertMovie_Genre(movieID, clbMovieGenre);
            LoadMovieList();
        }

        void UpdateMovie(string id, string name, string desc, float length, DateTime startDate, DateTime endDate, string productor, string director, int year, byte[] image)
        {
            if (Movie_DAO.UpdateMovie(id, name, desc, length, startDate, endDate, productor, director, year, image))
            {
                MessageBox.Show("Sửa phim thành công");
            }
            else
            {
                MessageBox.Show("Sửa phim thất bại");
            }
        }
        void UpdateMovie_Genre(string movieID, CheckedListBox checkedListBox)
        {
            List<Genre_DTO> checkedGenreList = new List<Genre_DTO>();
            foreach (Genre_DTO checkedItem in checkedListBox.CheckedItems)
            {
                checkedGenreList.Add(checkedItem);
            }
            MovieByGenre_DAO.UpdateMovie_Genre(movieID, checkedGenreList);
        }
        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            string movieID = txtMovieID.Text;
            string movieName = txtMovieName.Text;
            string movieDesc = txtMovieDesc.Text;
            float movieLength = float.Parse(txtMovieLength.Text);
            DateTime startDate = dtmMovieStart.Value;
            DateTime endDate = dtmMovieEnd.Value;
            string productor = txtMovieProductor.Text;
            string director = txtMovieDirector.Text;
            int year = int.Parse(txtMovieYear.Text);
          
            UpdateMovie_Genre(movieID, clbMovieGenre);
            LoadMovieList();
        }

        void DeleteMovie(string id)
        {
            if (Movie_DAO.DeleteMovie(id))
            {
                MessageBox.Show("Xóa phim thành công");
            }
            else
            {
                MessageBox.Show("Xóa phim thất bại");
            }
        }
        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            string movieID = txtMovieID.Text;
            DeleteMovie(movieID);
            LoadMovieList();
        }

        private void panel47_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void picFilm_Click(object sender, EventArgs e)
        {

        }

        private void clbMovieGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtmMovieEnd_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtmMovieStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMovieYear_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMovieDirector_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMovieProductor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMovieLength_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMovieEndDate_Click(object sender, EventArgs e)
        {

        }

        private void lblMovieStartDate_Click(object sender, EventArgs e)
        {

        }

        private void lblMovieLength_Click(object sender, EventArgs e)
        {

        }

        private void txtMovieDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMovieYear_Click(object sender, EventArgs e)
        {

        }

        private void lblMovieGenre_Click(object sender, EventArgs e)
        {

        }

        private void lblMovieDirector_Click(object sender, EventArgs e)
        {

        }

        private void lblMovieProductor_Click(object sender, EventArgs e)
        {

        }

        private void lblMovieDesc_Click(object sender, EventArgs e)
        {

        }

        private void txtMovieName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblMovieName_Click(object sender, EventArgs e)
        {

        }

        private void lblMovieID_Click(object sender, EventArgs e)
        {

        }

    }
}

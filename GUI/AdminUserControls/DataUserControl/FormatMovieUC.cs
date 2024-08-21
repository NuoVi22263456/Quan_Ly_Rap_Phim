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
    public partial class FormatMovieUC : UserControl
    {
        BindingSource formatList = new BindingSource();
        public FormatMovieUC()
        {
            InitializeComponent();
            LoadFormatMovie();
        }

        void LoadFormatMovie()
        {
            dtgvFormat.DataSource = formatList;
            LoadFormatMovieList();
            LoadMovieIDIntoCombobox(cboFormat_MovieID);
            LoadScreenIDIntoCombobox(cboFormat_ScreenID);
            AddFormatBinding();
        }
        void LoadMovieIDIntoCombobox(ComboBox comboBox)
        {
            comboBox.DataSource = Movie_DAO.GetListMovie();
            comboBox.DisplayMember = "ID";
            comboBox.ValueMember = "ID";
        }
        private void cboFormat_MovieID_SelectedValueChanged(object sender, EventArgs e)
        //Display the MovieName when MovieID changed
        {
            Movie_DTO movieSelected = cboFormat_MovieID.SelectedItem as Movie_DTO;
            txtFormat_MovieName.Text = movieSelected.Name;
        }
        void LoadScreenIDIntoCombobox(ComboBox comboBox)
        {
            comboBox.DataSource = ScreenType_DAO.GetListScreenType();
            comboBox.DisplayMember = "ID";
            comboBox.ValueMember = "ID";
        }
        private void cboFormat_ScreenID_SelectedValueChanged(object sender, EventArgs e)
        {
            ScreenType_DTO screenTypeSelected = cboFormat_ScreenID.SelectedItem as ScreenType_DTO;
            txtFormat_ScreenName.Text = screenTypeSelected.Name;
        }
        void LoadFormatMovieList()
        {
            formatList.DataSource = FormatMovie_DAO.GetListFormatMovie();
        }

        void AddFormatBinding()
        {
            txtFormatID.DataBindings.Add("Text", dtgvFormat.DataSource, "Mã định dạng", true, DataSourceUpdateMode.Never);
        }
        private void txtFormatID_TextChanged(object sender, EventArgs e)
        {
            string movieID = (string)dtgvFormat.SelectedCells[0].OwningRow.Cells["Mã phim"].Value;
            Movie_DTO movieSelecting = Movie_DAO.GetMovieByID(movieID);
            //This is the Movie that we're currently selecting in dtgv

            if (movieSelecting == null)
                return;

            //cboFormat_MovieID.SelectedItem = movieSelecting;

            int indexMovie = -1;
            int iMovie = 0;
            foreach (Movie_DTO item in cboFormat_MovieID.Items)
            {
                if (item.Name == movieSelecting.Name)
                {
                    indexMovie = iMovie;
                    break;
                }
                iMovie++;
            }
            cboFormat_MovieID.SelectedIndex = indexMovie;


            string screenName = (string)dtgvFormat.SelectedCells[0].OwningRow.Cells["Tên MH"].Value;
            ScreenType_DTO screenTypeSelecting = ScreenType_DAO.GetScreenTypeByName(screenName);
            //This is the ScreenType that we're currently selecting in dtgv

            if (screenTypeSelecting == null)
                return;

            //cboFormat_ScreenID.SelectedItem = screenTypeSelecting;

            int indexScreen = -1;
            int iScreen = 0;
            foreach (ScreenType_DTO item in cboFormat_ScreenID.Items)
            {
                if (item.Name == screenTypeSelecting.Name)
                {
                    indexScreen = iScreen;
                    break;
                }
                iScreen++;
            }
            cboFormat_ScreenID.SelectedIndex = indexScreen;
        }

        private void btnShowFormat_Click(object sender, EventArgs e)
        {
            LoadFormatMovieList();
        }

        void InsertFormat(string id, string idMovie, string idScreen)
        {
            if (FormatMovie_DAO.InsertFormatMovie(id, idMovie, idScreen))
            {
                MessageBox.Show("Thêm định dạng thành công");
            }
            else
            {
                MessageBox.Show("Thêm định dạng thất bại");
            }
        }
        private void btnInsertFormat_Click(object sender, EventArgs e)
        {
            string formatID = txtFormatID.Text;
            string movieID = cboFormat_MovieID.SelectedValue.ToString();
            string screenID = cboFormat_ScreenID.SelectedValue.ToString();
            InsertFormat(formatID, movieID, screenID);
            LoadFormatMovieList();
        }

        void UpdateFormat(string id, string idMovie, string idScreen)
        {
            if (FormatMovie_DAO.UpdateFormatMovie(id, idMovie, idScreen))
            {
                MessageBox.Show("Sửa định dạng thành công");
            }
            else
            {
                MessageBox.Show("Sửa định dạng thất bại");
            }
        }
        private void btnUpdateFormat_Click(object sender, EventArgs e)
        {
            string formatID = txtFormatID.Text;
            string movieID = cboFormat_MovieID.SelectedValue.ToString();
            string screenID = cboFormat_ScreenID.SelectedValue.ToString();
            UpdateFormat(formatID, movieID, screenID);
            LoadFormatMovieList();
        }

        void DeleteFormat(string id)
        {
            if (FormatMovie_DAO.DeleteFormatMovie(id))
            {
                MessageBox.Show("Xóa định dạng thành công");
            }
            else
            {
                MessageBox.Show("Xóa định dạng thất bại");
            }
        }
        private void btnDeleteFormat_Click(object sender, EventArgs e)
        {
            string formatID = txtFormatID.Text;
            DeleteFormat(formatID);
            LoadFormatMovieList();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvFormat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblFormat_ScreenName_Click(object sender, EventArgs e)
        {

        }

        private void lblFormat_ScreenID_Click(object sender, EventArgs e)
        {

        }

        private void lblFormat_MovieName_Click(object sender, EventArgs e)
        {

        }

        private void lblFormat_MovieID_Click(object sender, EventArgs e)
        {

        }

        private void txtFormat_ScreenName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblFormatID_Click(object sender, EventArgs e)
        {

        }

        private void txtFormat_MovieName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

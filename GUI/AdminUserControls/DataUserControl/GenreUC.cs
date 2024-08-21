using DAO;
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
    public partial class GenreUC : UserControl
    {
        BindingSource genreList = new BindingSource();

        public GenreUC()
        {
            InitializeComponent();
            LoadGenre();
        }

        void LoadGenre()
        {
            dtgvGenre.DataSource = genreList;
            LoadGenreList();
            AddGenreBinding();
        }
        void LoadGenreList()
        {
            genreList.DataSource = Genre_DAO.GetGenre();
        }
        void AddGenreBinding()
        {
            txtGenreID.DataBindings.Add("Text", dtgvGenre.DataSource, "Mã thể loại", true, DataSourceUpdateMode.Never);
            txtGenreName.DataBindings.Add("Text", dtgvGenre.DataSource, "Tên thể loại", true, DataSourceUpdateMode.Never);
            txtGenreDesc.DataBindings.Add("Text", dtgvGenre.DataSource, "Mô tả", true, DataSourceUpdateMode.Never);
        }
        private void btnShowGenre_Click(object sender, EventArgs e)
        {
            LoadGenreList();
        }

        void InsertGenre(string id, string name, string desc)
        {
            if (Genre_DAO.InsertGenre(id, name, desc))
            {
                MessageBox.Show("Thêm thể loại thành công");
            }
            else
            {
                MessageBox.Show("Thêm thể loại thất bại");
            }
        }
        private void btnInsertGenre_Click(object sender, EventArgs e)
        {
            string GenreID = txtGenreID.Text;
            string GenreName = txtGenreName.Text;
            string GenreDesc = txtGenreDesc.Text;
            InsertGenre(GenreID, GenreName, GenreDesc);
            LoadGenreList();
        }

        void UpdateGenre(string id, string name, string desc)
        {
            if (Genre_DAO.UpdateGenre(id, name, desc))
            {
                MessageBox.Show("Sửa thể loại thành công");
            }
            else
            {
                MessageBox.Show("Sửa thể loại thất bại");
            }
        }
        private void btnUpdateGenre_Click(object sender, EventArgs e)
        {
            string GenreID = txtGenreID.Text;
            string GenreName = txtGenreName.Text;
            string GenreDesc = txtGenreDesc.Text;
            UpdateGenre(GenreID, GenreName, GenreDesc);
            LoadGenreList();
        }

        void DeleteGenre(string id)
        {
            if (Genre_DAO.DeleteGenre(id))
            {
                MessageBox.Show("Xóa thể loại thành công");
            }
            else
            {
                MessageBox.Show("Xóa thể loại thất bại");
            }
        }
        private void btnDeleteGenre_Click(object sender, EventArgs e)
        {
            string GenreID = txtGenreID.Text;
            DeleteGenre(GenreID);
            LoadGenreList();
        }

        private void panel40_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvGenre_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGenreDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGenreDesc_Click(object sender, EventArgs e)
        {

        }

        private void panel38_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGenreName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGenreName_Click(object sender, EventArgs e)
        {

        }

        private void panel39_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtGenreID_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblGenreID_Click(object sender, EventArgs e)
        {

        }

        private void dtgvGenre_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

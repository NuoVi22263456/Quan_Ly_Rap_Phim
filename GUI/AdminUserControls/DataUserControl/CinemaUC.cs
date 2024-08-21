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
    public partial class CinemaUC : UserControl
    {
        BindingSource cinemaList = new BindingSource();

        public CinemaUC()
        {
            InitializeComponent();
            LoadCinema();
        }

        void LoadCinema()
        {
            dtgvCinema.DataSource = cinemaList;
            LoadCinemaList();
            AddCinemaBinding();
        }
        void LoadCinemaList()
        {
            cinemaList.DataSource = Cinema_DAO.GetListCinema();
        }
        void AddCinemaBinding()
        {
            txtCinemaID.DataBindings.Add("Text", dtgvCinema.DataSource, "Mã phòng", true, DataSourceUpdateMode.Never);
            txtCinemaName.DataBindings.Add("Text", dtgvCinema.DataSource, "Tên phòng", true, DataSourceUpdateMode.Never);
            txtCinemaSeats.DataBindings.Add("Text", dtgvCinema.DataSource, "Số chỗ ngồi", true, DataSourceUpdateMode.Never);
            txtCinemaStatus.DataBindings.Add("Text", dtgvCinema.DataSource, "Tình trạng", true, DataSourceUpdateMode.Never);
            txtNumberOfRows.DataBindings.Add("Text", dtgvCinema.DataSource, "Số hàng ghế", true, DataSourceUpdateMode.Never);
            txtSeatsPerRow.DataBindings.Add("Text", dtgvCinema.DataSource, "Ghế mỗi hàng", true, DataSourceUpdateMode.Never);
            LoadScreenTypeIntoComboBox(cboCinemaScreenType);
        }
        void LoadScreenTypeIntoComboBox(ComboBox cbo)
        {
            cbo.DataSource = ScreenType_DAO.GetListScreenType();
            cbo.DisplayMember = "Name";
            cbo.ValueMember = "ID";
        }
        private void txtCinemaID_TextChanged(object sender, EventArgs e)
        //Use this to bind data between dtgv and cbo because cbo can't be applied DataBindings normally
        {
            string screenName = (string)dtgvCinema.SelectedCells[0].OwningRow.Cells["Tên màn hình"].Value;
            DTO.ScreenType_DTO screenType = ScreenType_DAO.GetScreenTypeByName(screenName);
            //This is the ScreenType that we're currently selecting in dtgv

            cboCinemaScreenType.SelectedItem = screenType;

            int index = -1;
            int i = 0;
            foreach (ScreenType_DTO item in cboCinemaScreenType.Items)
            {
                if (item.Name == screenType.Name)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cboCinemaScreenType.SelectedIndex = index;
        }

        void InsertCinema(string id, string name, string idMH, int seats, int status, int numberOfRows, int seatsPerRow)
        {
            if (Cinema_DAO.InsertCinema(id, name, idMH, seats, status, numberOfRows, seatsPerRow))
            {
                MessageBox.Show("Thêm phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Thêm phòng chiếu thất bại");
            }
        }
        private void btnInsertCinema_Click(object sender, EventArgs e)
        {
            string cinemaID = txtCinemaID.Text;
            string cinemaName = txtCinemaName.Text;
            string screenTypeID = cboCinemaScreenType.SelectedValue.ToString();
            int cinemaSeats = int.Parse(txtCinemaSeats.Text);
            int cinemaStatus = int.Parse(txtCinemaStatus.Text);
            int numberOfRows = int.Parse(txtNumberOfRows.Text);
            int seatsPerRows = int.Parse(txtSeatsPerRow.Text);
            InsertCinema(cinemaID, cinemaName, screenTypeID, cinemaSeats, cinemaStatus, numberOfRows, seatsPerRows);
            LoadCinemaList();
        }

        void UpdateCinema(string id, string name, string idMH, int seats, int status, int numberOfRows, int seatsPerRow)
        {
            if (Cinema_DAO.UpdateCinema(id, name, idMH, seats, status, numberOfRows, seatsPerRow))
            {
                MessageBox.Show("Sửa phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Sửa phòng chiếu thất bại");
            }
        }
        private void btnUpdateCinema_Click(object sender, EventArgs e)
        {
            string cinemaID = txtCinemaID.Text;
            string cinemaName = txtCinemaName.Text;
            string screenTypeID = cboCinemaScreenType.SelectedValue.ToString();
            int cinemaSeats = int.Parse(txtCinemaSeats.Text);
            int cinemaStatus = int.Parse(txtCinemaStatus.Text);
            int numberOfRows = int.Parse(txtNumberOfRows.Text);
            int seatsPerRows = int.Parse(txtSeatsPerRow.Text);
            UpdateCinema(cinemaID, cinemaName, screenTypeID, cinemaSeats, cinemaStatus, numberOfRows, seatsPerRows);
            LoadCinemaList();
        }

        void DeleteCinema(string id)
        {
            if (Cinema_DAO.DeleteCinema(id))
            {
                MessageBox.Show("Xóa phòng chiếu thành công");
            }
            else
            {
                MessageBox.Show("Xóa phòng chiếu thất bại");
            }
        }
        private void btnDeleteCinema_Click(object sender, EventArgs e)
        {
            string cinemaID = txtCinemaID.Text;
            DeleteCinema(cinemaID);
            LoadCinemaList();
        }
        private void btnShowCinema_Click(object sender, EventArgs e)
        {
            LoadCinemaList();
        }

        private void panel33_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cboCinemaScreenType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblScreenType_Click(object sender, EventArgs e)
        {

        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtSeatsPerRow_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSeatsPerRow_Click(object sender, EventArgs e)
        {

        }

        private void panel12_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNumberOfRows_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblNumberOfRows_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCinemaStatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCinemaStatus_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCinemaSeats_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCinemaSeats_Click(object sender, EventArgs e)
        {

        }

        private void panel31_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtCinemaName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCinemaName_Click(object sender, EventArgs e)
        {

        }

        private void panel32_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblCinemaID_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dtgvCinema_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}

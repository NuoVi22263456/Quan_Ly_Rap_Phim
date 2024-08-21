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

namespace GUI.AdminUserControls
{
    public partial class StaffUC : UserControl
    {
        BindingSource staffList = new BindingSource();
        public StaffUC()
        {
            InitializeComponent();
            LoadStaff();
        }

        void LoadStaff()
        {
            dtgvStaff.DataSource = staffList;
            LoadStaffList();
            AddStaffBinding();
        }

        void LoadStaffList()
        {
            staffList.DataSource = Staff_DAO.GetListStaff();
        }

        private void btnShowStaff_Click(object sender, EventArgs e)
        {
            LoadStaffList();
        }
        void AddStaffBinding()
        {
            txtStaffId.DataBindings.Add("Text", dtgvStaff.DataSource, "Mã nhân viên", true, DataSourceUpdateMode.Never);
            txtStaffName.DataBindings.Add("Text", dtgvStaff.DataSource, "Họ tên", true, DataSourceUpdateMode.Never);
            txtStaffBirth.DataBindings.Add("Text", dtgvStaff.DataSource, "Ngày sinh", true, DataSourceUpdateMode.Never);
            txtStaffAddress.DataBindings.Add("Text", dtgvStaff.DataSource, "Địa chỉ", true, DataSourceUpdateMode.Never);
            txtStaffPhone.DataBindings.Add("Text", dtgvStaff.DataSource, "SĐT", true, DataSourceUpdateMode.Never);
            txtStaffINumber.DataBindings.Add("Text", dtgvStaff.DataSource, "CMND", true, DataSourceUpdateMode.Never);

        }


        //Thêm Staff
        void AddStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            if (Staff_DAO.InsertStaff(id, hoTen, ngaySinh, diaChi, sdt, cmnd))
            {
                MessageBox.Show("Thêm nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Thêm nhân viên thất bại");
            }
        }
        private void btnAddStaff_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            string staffName = txtStaffName.Text;
            DateTime staffBirth = DateTime.Parse(txtStaffBirth.Text);
            string staffAddress = txtStaffAddress.Text;
            string staffPhone = txtStaffPhone.Text;
            int staffINumber = Int32.Parse(txtStaffINumber.Text);
            //AddStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber);
            //LoadStaffList();
            //18+
            try
            {
                DateTime dateOfBirth = DateTime.Parse(txtStaffBirth.Text);
                int age = DateTime.Now.Year - dateOfBirth.Year;
                if (age < 18)
                {
                    MessageBox.Show("Nhân viên không đủ 18 tuổi");
                    return;
                }

                // Thêm nhân viên vào hệ thống
                AddStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber);
                LoadStaffList();

                // Hiển thị thông báo thành công
                MessageBox.Show("Nhân viên đã được thêm vào hệ thống");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        //Sửa Staff
        void UpdateStaff(string id, string hoTen, DateTime ngaySinh, string diaChi, string sdt, int cmnd)
        {
            if (Staff_DAO.UpdateStaff(id, hoTen, ngaySinh, diaChi, sdt, cmnd))
            {
                MessageBox.Show("Sửa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Sửa nhân viên thất bại");
            }
        }
        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            string staffName = txtStaffName.Text;
            DateTime staffBirth = DateTime.Parse(txtStaffBirth.Text);
            string staffAddress = txtStaffAddress.Text;
            string staffPhone = txtStaffPhone.Text;
            int staffINumber = Int32.Parse(txtStaffINumber.Text);
            UpdateStaff(staffId, staffName, staffBirth, staffAddress, staffPhone, staffINumber);
            LoadStaffList();
        }

        //Xóa Staff
        void DeleteStaff(string id)
        {
            if (Staff_DAO.DeleteStaff(id))
            {
                MessageBox.Show("Xóa nhân viên thành công");
            }
            else
            {
                MessageBox.Show("Xóa nhân viên thất bại");
            }
        }
        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            string staffId = txtStaffId.Text;
            DeleteStaff(staffId);
            LoadStaffList();
        }

        //Tìm kiếm Staff
        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            string staffName = txtSearchStaff.Text;
            DataTable staffSearchList = Staff_DAO.SearchStaffByName(staffName);
            staffList.DataSource = staffSearchList;
        }

        private void txtSearchStaff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchStaff.PerformClick();
                e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
            }
        }

        private void lblStaffID_Click(object sender, EventArgs e)
        {

        }

        private void txtStaffId_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStaffAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStaffINumber_Click(object sender, EventArgs e)
        {

        }

        private void lblStaffBirth_Click(object sender, EventArgs e)
        {

        }

        private void txtStaffPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStaffPhone_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchStaff_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStaffBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblStaffAddress_Click(object sender, EventArgs e)
        {

        }

        private void txtStaffINumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void grpStaff_Enter(object sender, EventArgs e)
        {

        }

        private void lblStaffName_Click(object sender, EventArgs e)
        {

        }

        private void txtStaffName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvStaff_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}

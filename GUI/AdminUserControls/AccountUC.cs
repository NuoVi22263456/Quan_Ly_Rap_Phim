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

namespace GUI.AdminUserControls
{
    public partial class AccountUC : UserControl
    {
        BindingSource accountList = new BindingSource();

        public AccountUC()
        {
            InitializeComponent();
            LoadAccount();
        }

        void LoadAccount()
        {
            dtgvAccount.DataSource = accountList;
            LoadAccountList();
            AddAccountBinding();
        }
        void LoadAccountList()
        {
            accountList.DataSource = Account_DAO.GetAccountList();
        }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }

        void AddAccountBinding()
        {
            txtUsername.DataBindings.Add("Text", dtgvAccount.DataSource, "Username", true, DataSourceUpdateMode.Never);
            nudAccountType.DataBindings.Add("Value", dtgvAccount.DataSource, "Loại tài khoản", true, DataSourceUpdateMode.Never);
            LoadStaffIntoComboBox(cboStaffID_Account);
        }
        void LoadStaffIntoComboBox(ComboBox cbo)
        {
            cbo.DataSource = Staff_DAO.GetStaff();
            cbo.DisplayMember = "ID";
            cbo.ValueMember = "ID";
        }
        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
            string staffID = (string)dtgvAccount.SelectedCells[0].OwningRow.Cells["Mã nhân viên"].Value;
            Staff_DTO staff = Staff_DAO.GetStaffByID(staffID);//The staff that we're currently selecting

            if (staff == null)
                //The case that nothing on dtgv - no result after searched
                return;

            cboStaffID_Account.SelectedItem = staff;

            int index = -1;
            int i = 0;
            foreach (Staff_DTO item in cboStaffID_Account.Items)
            {
                if (item.ID == staff.ID)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cboStaffID_Account.SelectedIndex = index;
        }
        private void cboStaffID_Account_SelectedIndexChanged(object sender, EventArgs e)
        {
            Staff_DTO staff = cboStaffID_Account.SelectedItem as Staff_DTO;
            if (staff == null)
                return;
            txtStaffName_Account.Text = staff.Name;
        }

        void InsertAccount(string username, int accountType, string idStaff)
        {
            if (Account_DAO.InsertAccount(username, accountType, idStaff))
            {
                MessageBox.Show("Thêm tài khoản thành công, mật khẩu mặc định : 12345");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
        }
        private void btnInsertAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            int accountType = (int)nudAccountType.Value;
            string staffID = cboStaffID_Account.SelectedValue.ToString();
            InsertAccount(username, accountType, staffID);
            LoadAccountList();
        }

        void UpdateAccount(string username, int accountType)
        {
            if (Account_DAO.UpdateAccount(username, accountType))
            {
                MessageBox.Show("Sửa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Sửa tài khoản thất bại");
            }
        }
        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            int accountType = (int)nudAccountType.Value;
            UpdateAccount(username, accountType);
            LoadAccountList();
        }

        void DeleteAccount(string username)
        {
            if (Account_DAO.DeleteAccount(username))
            {
                MessageBox.Show("Xóa tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
        }
        private void btnDeleteAccount_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            DeleteAccount(username);
            LoadAccountList();
        }

        void ResetPassword(string username)
        {
            if (Account_DAO.ResetPassword(username))
            {
                MessageBox.Show("Reset mật khẩu thành công, mật khẩu mặc định : admin");
            }
            else
            {
                MessageBox.Show("Reset mật khẩu thất bại");
            }
        }
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            ResetPassword(username);
            LoadAccountList();
        }

        private void btnSearchAccount_Click(object sender, EventArgs e)
        {
            string staffName = txtSearchAccount.Text;
            accountList.DataSource = Account_DAO.SearchAccountByStaffName(staffName);
        }

        private void txtSearchAccount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearchAccount.PerformClick();
                e.SuppressKeyPress = true;//Tắt tiếng *ting của windows
            }
        }

        private void txtSearchAccount_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvAccount_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AccountUC_Load(object sender, EventArgs e)
        {

        }
    }
}

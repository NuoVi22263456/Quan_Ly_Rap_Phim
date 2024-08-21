using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;

namespace GUI
{
    public partial class ChangePassword : Form
    {
        Account_DTO loginAccount;
        public Account_DTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }
        public ChangePassword(DTO.Account_DTO loginAccount)
        {
            InitializeComponent();
            LoginAccount = loginAccount;
        }
        void ChangeAccount(Account_DTO loginAccount)
        {
            txtStaffID.Text = loginAccount.StaffID.ToString();
            txtUsername.Text = loginAccount.UserName.ToString();
        }
        void ApplyChanges()
        {
            string username = txtUsername.Text;
            string newPass = txtNewPass.Text;
            string reEnterPass = txtReEnter.Text;
            string confirmPass = txtConfirmPass.Text;

            if (newPass != reEnterPass)
            {
                MessageBox.Show("Hai mật khẩu mới chưa trùng nhau!");
            }
            else if (newPass == "")
            {
                MessageBox.Show("Mật khẩu không được để trống.");
            }
            else
            {
                if (Account_DAO.UpdatePasswordForAccount(username, confirmPass, newPass))
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Vui lòng điền đúng mật khẩu.");
                }
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            ApplyChanges();
        }
    }
}

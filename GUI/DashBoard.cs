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
    public partial class DashBoard : Form
    {
        public DashBoard(Account_DTO acc)
        {
            InitializeComponent();
            this.LoginAccount = acc;
        }

      
        private Account_DTO loginAccount;
        public Account_DTO LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }

        void ChangeAccount(int type)
        {
            if (loginAccount.Type == 2) btnAdmin.Enabled = false;
            lblAccountInfo.Text += LoginAccount.UserName;
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminNewDesign frm = new AdminNewDesign();
            frm.ShowDialog();
            this.Show();
        }

        private void btnSeller_Click(object sender, EventArgs e)
        {

            this.Hide();
            Seller frm = new Seller();
            frm.ShowDialog();
            this.Show();
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            ChangePassword frm = new ChangePassword(loginAccount);
            frm.ShowDialog();
            this.Show();
        }
    }
}

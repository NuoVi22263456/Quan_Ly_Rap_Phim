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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        public Customer_DTO customer;
        private void btnCofirm_Click(object sender, EventArgs e)
        {
            DataTable data = Customer_DAO.GetCustomerMember(txtCustomerID.Text, txtCustomerName.Text);

            if (data.Rows.Count == 0)
            {
                MessageBox.Show("ID hoặc Họ tên của Khách Hàng không chính xác!\nVui lòng nhập lại thông tin.");
                return;
            }
            customer = new Customer_DTO(data.Rows[0]);

            DialogResult = DialogResult.OK;
        }
    }
}

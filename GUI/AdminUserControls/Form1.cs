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
    public partial class Form1 : Form
    {
        public static int t;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            t = int.Parse(txtTuoi.Text);
            Close();
        }
    }
}

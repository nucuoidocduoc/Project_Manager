using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH2019
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHello.Text = " ";
        }

        private void txtHello_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHien_Click(object sender, EventArgs e)
        {
            txtHello.Text = "Chào mừng bạn đến với lớp học";
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}

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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtHoTen.Text = " ";
            txtHo.Text = " ";
            txtTen.Text = " ";
           
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnTach_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtHoTen.Text))
            {
                MessageBox.Show("Chưa nhập thông tin");
                txtHoTen.Focus();
            }
            else
            {
            string hodem = "";
            string ten = "";
            string value = txtHoTen.Text.Trim();
            string[] tach = value.Split(' ');
                for(int i=0; i<tach.Length-1;i++)
                {
                    hodem = hodem + ' ' + tach[i];
                    ten = tach[i + 1];
                }
                txtHo.Text = hodem;
                txtTen.Text = ten;
            }
            
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtSoHang1.Text = " ";
            txtSoHang2.Text = " ";
            txtKetQua.Text = " ";
            cboDau.Text= " " ;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {
            double giaTri = 0;
          
            if (cboDau.Text == "+")
                giaTri = Convert.ToDouble(txtSoHang1.Text) + Convert.ToDouble(txtSoHang2.Text);
               
            if (cboDau.Text == "-")
                giaTri = Convert.ToDouble(txtSoHang1.Text) - Convert.ToDouble(txtSoHang2.Text);
          
            if (cboDau.Text == "x")
                giaTri = Convert.ToDouble(txtSoHang1.Text) * Convert.ToDouble(txtSoHang2.Text);
              
            if (cboDau.Text == "/")
            {
                if (Convert.ToDouble(txtSoHang2.Text) == 0)
                    MessageBox.Show ("Số bị chia không thể bằng 0");
                   giaTri = Convert.ToDouble(txtSoHang1.Text) / Convert.ToDouble(txtSoHang2.Text);
            }
              
           double value = Math.Round(giaTri,2);
            txtKetQua.Text = Convert.ToString(value);
        }

       
 
    }
}

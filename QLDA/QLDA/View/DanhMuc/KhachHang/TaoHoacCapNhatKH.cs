using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA.View.DanhMuc.KhachHang
{
    public partial class TaoHoacCapNhatKH : Form
    {
        public TaoHoacCapNhatKH()
        {
            InitializeComponent();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            Model.KhachHang khachHang = new Model.KhachHang() {
                Ten = txtTenKH.Text,
                Dia_Chi = txtDC.Text,
                SDT = txtSDT.Text,
                MST = txtMST.Text,
                STK = txtSTK.Text,
                Ten_NH = txtTenNH.Text
            };
            MainForm.RepositoryWrapper.KhachHang.Add(khachHang);
            MainForm.RepositoryWrapper.SaveChange();
        }
    }
}
using QLDA.View.DanhMuc.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitForm();
            panelMainContent.Controls.Add(new DanhSachKhachHang());
        }

        private void InitForm()
        {
            panelDanhMuc.Visible = false;
            panelQLDA.Visible = false;
            panelQLCV.Visible = false;
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if (panelDanhMuc.Visible) {
                panelDanhMuc.Visible = false;
                return;
            }
            InitForm();

            panelDanhMuc.Visible = true;
            XemChiTietKH xemChiTietKH = new XemChiTietKH();
            xemChiTietKH.ShowDialog();
        }

        private void btnQLDA_Click(object sender, EventArgs e)
        {
            if (panelQLDA.Visible) {
                panelQLDA.Visible = false;
                return;
            }
            InitForm();
            panelQLDA.Visible = true;
        }

        private void btnQLCV_Click(object sender, EventArgs e)
        {
            if (panelQLCV.Visible) {
                panelQLCV.Visible = false;
                return;
            }
            InitForm();
            panelQLCV.Visible = true;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
        }
    }
}
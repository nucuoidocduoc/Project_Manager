using QLDA.View.Template;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA.View.QuanLyDuAn.DuAn
{
    public partial class TaoHoacCapNhatDuAn : Form
    {
        private int? _idUpdate;
        private Model.DuAn _duAnUpdate;

        public bool HasReloadList { get; set; } = false;

        public TaoHoacCapNhatDuAn()
        {
            InitializeComponent();
            if (!InitCreate()) {
                Close();
            }
        }

        public TaoHoacCapNhatDuAn(int idUpdate)
        {
            InitializeComponent();
            _idUpdate = idUpdate;
        }

        private void InitUpdate()
        {
            _duAnUpdate = MainForm.RepositoryWrapper.DuAn.FindByCondition(d => d.Ma_DA == _idUpdate).FirstOrDefault();
            if (_duAnUpdate == null) {
                return;
            }
        }

        private bool InitCreate()
        {
            var khachHangs = MainForm.RepositoryWrapper.KhachHang.FindAll().ToList();
            if (khachHangs.Count < 1) {
                MessageBox.Show("Cần có chủ đầu tư để khởi tạo dự án");
                return false;
            }
            var nhanViens = MainForm.RepositoryWrapper.NhanVien.FindAll().ToList();

            cbxGiamDoc.Items.Add(new ItemComboboxTemplate() { Content = "None" });
            foreach (var nv in nhanViens) {
                cbxGiamDoc.Items.Add(new ItemComboboxTemplate() { Id = nv.Ma_NV, Prefix = Define.PREFIX_NHAN_VIEN + nv.Ma_NV, Content = nv.Ten });
            }
            foreach (var kh in khachHangs) {
                cbxChuDauTu.Items.Add(new ItemComboboxTemplate() { Id = kh.Ma_KH, Prefix = Define.PREFIX_KHACH_HANG + kh.Ma_KH, Content = kh.Ten });
            }
            cbxTrangThai.Items.Add("Finish");
            cbxChuDauTu.SelectedIndex = 0;
            cbxGiamDoc.SelectedIndex = 0;
            cbxTrangThai.SelectedIndex = 0;
            dtThoiGianBD.Value = DateTime.Now;
            dtThoiGianKT.Value = DateTime.Now;
            dtThoiGianTT.Value = DateTime.Now;
            return true;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_idUpdate == null) {
                // tao moi
                var newDuAn = new Model.DuAn() {
                    Ten = txtTen.Text,
                    Ma_KH = ((ItemComboboxTemplate)cbxChuDauTu.SelectedItem).Id,
                    Nhom = txtNhom.Text,
                    Dia_Diem = txtDiaDiem.Text,

                    Thoi_Gian_BD = dtThoiGianBD.Value,
                    Thoi_Gian_KT = dtThoiGianKT.Value,
                    Thoi_Gian_KT_TT = dtThoiGianTT.Value,
                    Dien_Giai = txtDienGiai.Text,
                    Trang_Thai = cbxTrangThai.SelectedItem.ToString()
                };
                if (cbxGiamDoc.SelectedIndex != 0) {
                    newDuAn.Ma_NV = ((ItemComboboxTemplate)cbxGiamDoc.SelectedItem).Id;
                }
                MainForm.RepositoryWrapper.DuAn.Add(newDuAn);
                MainForm.RepositoryWrapper.SaveChange();
                HasReloadList = true;
                Close();
            }
            else {
                // update
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Validation()
        {
            return true;
        }
    }
}
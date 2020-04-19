using QLDA.Repository;
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
        private RepositoryWrapper _repository;

        public bool HasReloadList { get; set; } = false;

        public TaoHoacCapNhatDuAn()
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            btnLuu.Enabled = false;
            if (!InitCreate()) {
                Close();
            }
        }

        public TaoHoacCapNhatDuAn(int idUpdate)
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            _idUpdate = idUpdate;
            InitUpdate();
        }

        private void InitUpdate()
        {
            _duAnUpdate = _repository.DuAn.FindByCondition(d => d.Ma_DA == _idUpdate).FirstOrDefault();
            if (_duAnUpdate == null) {
                return;
            }
            InitCombobox();
            if (_duAnUpdate.Ma_NV != null) {
                foreach (var item in cbxNhanVien.Items) {
                    ItemComboboxTemplate template = (ItemComboboxTemplate)item;
                    if (template.Id != null && template.Id == _duAnUpdate.Ma_NV) {
                        cbxNhanVien.SelectedItem = item;
                        break;
                    }
                }
            }
            if (_duAnUpdate.Ma_KH != null) {
                foreach (var item in cbxKhachHang.Items) {
                    ItemComboboxTemplate template = (ItemComboboxTemplate)item;
                    if (template.Id != null && template.Id == _duAnUpdate.Ma_KH) {
                        cbxNhanVien.SelectedItem = item;
                        break;
                    }
                }
            }
            if (!string.IsNullOrEmpty(_duAnUpdate.Trang_Thai)) {
                foreach (var item in cbxTrangThai.Items) {
                    string template = (string)item;
                    if (template.Equals(_duAnUpdate.Trang_Thai)) {
                        cbxNhanVien.SelectedItem = item;
                        break;
                    }
                }
            }

            txtTen.Text = _duAnUpdate.Ten;
            txtDiaDiem.Text = _duAnUpdate.Dia_Diem;
            txtDienGiai.Text = _duAnUpdate.Dien_Giai;
            txtNhom.Text = _duAnUpdate.Nhom;
            dtThoiGianBD.Value = _duAnUpdate.Thoi_Gian_BD;
            dtThoiGianKT.Value = _duAnUpdate.Thoi_Gian_KT;
            dtThoiGianTT.Value = _duAnUpdate.Thoi_Gian_KT_TT;
        }

        private bool InitCombobox()
        {
            var khachHangs = _repository.KhachHang.FindAll().ToList();
            if (khachHangs.Count < 1) {
                MessageBox.Show("Cần có chủ đầu tư để khởi tạo dự án");
                return false;
            }
            var nhanViens = _repository.NhanVien.FindAll().ToList();

            cbxNhanVien.Items.Add(new ItemComboboxTemplate() { Content = "None" });

            foreach (var nv in nhanViens) {
                cbxNhanVien.Items.Add(new ItemComboboxTemplate() { Id = nv.Ma_NV, Prefix = Define.PREFIX_NHAN_VIEN + nv.Ma_NV, Content = nv.Ten });
            }
            foreach (var kh in khachHangs) {
                cbxKhachHang.Items.Add(new ItemComboboxTemplate() { Id = kh.Ma_KH, Prefix = Define.PREFIX_KHACH_HANG + kh.Ma_KH, Content = kh.Ten });
            }
            cbxTrangThai.Items.Add(Define.PENDING);
            cbxTrangThai.Items.Add(Define.FINISHED);
            cbxTrangThai.Items.Add(Define.UNFINISH);
            cbxKhachHang.SelectedIndex = 0;
            cbxNhanVien.SelectedIndex = 0;
            cbxTrangThai.SelectedIndex = 0;
            return true;
        }

        private bool InitCreate()
        {
            if (!InitCombobox()) {
                return false;
            }

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
                    Ma_KH = ((ItemComboboxTemplate)cbxKhachHang.SelectedItem).Id,
                    Nhom = txtNhom.Text,
                    Dia_Diem = txtDiaDiem.Text,

                    Thoi_Gian_BD = dtThoiGianBD.Value,
                    Thoi_Gian_KT = dtThoiGianKT.Value,
                    Thoi_Gian_KT_TT = dtThoiGianTT.Value,
                    Dien_Giai = txtDienGiai.Text,
                    Trang_Thai = cbxTrangThai.SelectedItem.ToString()
                };
                if (cbxNhanVien.SelectedIndex != 0) {
                    newDuAn.Ma_NV = ((ItemComboboxTemplate)cbxNhanVien.SelectedItem).Id;
                }
                _repository.DuAn.Add(newDuAn);
            }
            else {
                // update
                _duAnUpdate.Ten = txtTen.Text;
                _duAnUpdate.Ma_KH = ((ItemComboboxTemplate)cbxKhachHang.SelectedItem).Id;
                _duAnUpdate.Nhom = txtNhom.Text;
                _duAnUpdate.Dia_Diem = txtDiaDiem.Text;

                _duAnUpdate.Thoi_Gian_BD = dtThoiGianBD.Value;
                _duAnUpdate.Thoi_Gian_KT = dtThoiGianKT.Value;
                _duAnUpdate.Thoi_Gian_KT_TT = dtThoiGianTT.Value;
                _duAnUpdate.Dien_Giai = txtDienGiai.Text;
                _duAnUpdate.Trang_Thai = cbxTrangThai.SelectedItem.ToString();
                if (cbxNhanVien.SelectedIndex != 0) {
                    _duAnUpdate.Ma_NV = ((ItemComboboxTemplate)cbxNhanVien.SelectedItem).Id;
                }
                else {
                    _duAnUpdate.Ma_NV = null;
                }
            }
            _repository.SaveChange();
            HasReloadList = true;
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Validation()
        {
            if (txtTen.Text.Length > 50) {
                return false;
            }
            if (txtNhom.Text.Length > 50) {
                return false;
            }
            if (txtDiaDiem.Text.Length > 100) {
                return false;
            }
            if (txtDienGiai.Text.Length > 255) {
                return false;
            }
            return true;
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = !string.IsNullOrEmpty(txtTen.Text);
        }
    }
}
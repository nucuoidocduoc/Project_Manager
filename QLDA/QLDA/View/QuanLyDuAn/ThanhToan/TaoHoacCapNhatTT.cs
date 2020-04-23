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

namespace QLDA.View.QuanLyDuAn.ThanhToan
{
    public partial class TaoHoacCapNhatTT : Form
    {
        private int _id;
        private bool _isCreate;
        private RepositoryWrapper _repository;
        private Model.ThanhToan _thanhToanUpdate;
        public bool HasReloadList { get; private set; }

        public TaoHoacCapNhatTT()
        {
            InitializeComponent();
        }

        // neu la tao moi theo du An, thi id la id cua hop dong
        // neu tao moi tu do thi id la so am
        // neu update thi id la id cua thanh toan
        public TaoHoacCapNhatTT(int id, bool isCreate = false)
        {
            InitializeComponent();
            _id = id;
            _isCreate = isCreate;
            _repository = RepositoryWrapper.Create();
            InitCBX();
            if (isCreate) {
                InitCreate();
            }
            else {
                InitUpdate();
            }
        }

        private void InitCreate()
        {
            InitDuAn();

            if (_id >= 0) {
                var hd = _repository.HopDong.FindByCondition(x => x.Ma_HD == _id).FirstOrDefault();
                if (hd == null) {
                    return;
                }
                foreach (var item in cbxDuAn.Items) {
                    int idItem = (int)((ItemComboboxTemplate)item).Id;
                    if (hd.Ma_DA == idItem) {
                        cbxDuAn.SelectedItem = item;

                        break;
                    }
                }
                foreach (var item in cbxHD.Items) {
                    int idItem = (int)((ItemComboboxTemplate)item).Id;
                    if (hd.Ma_HD == idItem) {
                        cbxHD.SelectedItem = item;
                        break;
                    }
                }
                cbxHD.Enabled = false;
                cbxDuAn.Enabled = false;
            }
            else {
                InitHD();
            }
            btnLuu.Enabled = false;
            Text = "Tạo mới thanh toán";
        }

        private void InitCBX()
        {
            cbxHinhThuc.Items.Add("Chuyển khoản");
            cbxHinhThuc.Items.Add("Tiền mặt");
            cbxLoaiTien.Items.Add(Define.VND);
            cbxLoaiTien.Items.Add(Define.USD);
            cbxHinhThuc.SelectedIndex = 0;
            cbxLoaiTien.SelectedIndex = 0;
        }

        private void InitUpdate()
        {
            InitDuAn();
            _thanhToanUpdate = _repository.ThanhToan.FindByCondition(x => x.Ma_TT == _id).FirstOrDefault();
            if (_thanhToanUpdate == null) {
                return;
            }
            var hd = _repository.HopDong.FindByCondition(x => x.Ma_HD == _thanhToanUpdate.Ma_HD).FirstOrDefault();
            if (hd == null) {
                return;
            }
            foreach (var item in cbxDuAn.Items) {
                int idItem = (int)((ItemComboboxTemplate)item).Id;
                if (hd.Ma_DA == idItem) {
                    cbxDuAn.SelectedItem = item;
                    InitHD();
                    break;
                }
            }
            foreach (var item in cbxHD.Items) {
                int idItem = (int)((ItemComboboxTemplate)item).Id;
                if (hd.Ma_HD == idItem) {
                    cbxHD.SelectedItem = item;
                    break;
                }
            }

            txtTen.Text = _thanhToanUpdate.Ten;
            txtSoTien.Text = _thanhToanUpdate.So_Tien;
            cbxHinhThuc.SelectedValue = _thanhToanUpdate.Hinh_Thuc;
            cbxLoaiTien.SelectedValue = _thanhToanUpdate.Loai_Tien;
            txtDienGiai.Text = _thanhToanUpdate.Dien_Giai;
            dtNgayThanhToan.Value = _thanhToanUpdate.Thoi_Gian_TT;

            cbxHD.Enabled = false;
            cbxDuAn.Enabled = false;
            Text = "Chỉnh sửa thanh toán " + Define.PREFIX_THANH_TOAN + _thanhToanUpdate.Ma_TT;
        }

        private void InitDuAn()
        {
            var duAns = _repository.DuAn.FindAll().ToList();
            if (duAns == null || duAns.Count < 1) {
                return;
            }
            foreach (var item in duAns) {
                cbxDuAn.Items.Add(new ItemComboboxTemplate() { Id = item.Ma_DA, Prefix = Define.PREFIX_DU_AN + item.Ma_DA, Content = item.Ten });
            }
            cbxDuAn.SelectedIndex = 0;
        }

        private void InitHD()
        {
            cbxHD.Items.Clear();
            int idDuAnSelected = (int)((ItemComboboxTemplate)cbxDuAn.SelectedItem).Id;
            var hopDongs = _repository.HopDong.FindByCondition(x => x.Ma_DA == idDuAnSelected).ToList();
            if (hopDongs == null || hopDongs.Count < 1) {
                return;
            }
            foreach (var item in hopDongs) {
                cbxHD.Items.Add(new ItemComboboxTemplate() { Id = item.Ma_HD, Prefix = Define.PREFIX_HOP_DONG + item.Ma_HD, Content = item.Ten });
            }
            cbxHD.SelectedIndex = 0;
        }

        private void cbxDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitHD();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Validation()) {
                return;
            }
            if (_isCreate) {
                Model.ThanhToan thanhToan = new Model.ThanhToan() {
                    Ten = txtTen.Text,
                    So_Tien = txtSoTien.Text,
                    Loai_Tien = cbxLoaiTien.SelectedItem.ToString(),
                    Hinh_Thuc = cbxHinhThuc.SelectedItem.ToString(),
                    Dien_Giai = txtDienGiai.Text,
                    Thoi_Gian_TT = dtNgayThanhToan.Value,
                    Ma_HD = (int)((ItemComboboxTemplate)cbxHD.SelectedItem).Id
                };
                _repository.ThanhToan.Add(thanhToan);
                _repository.SaveChange();
                HasReloadList = true;
            }
            else {
                _thanhToanUpdate.Ten = txtTen.Text;
                _thanhToanUpdate.So_Tien = txtSoTien.Text;
                _thanhToanUpdate.Loai_Tien = cbxLoaiTien.SelectedItem.ToString();
                _thanhToanUpdate.Hinh_Thuc = cbxHinhThuc.SelectedItem.ToString();
                _thanhToanUpdate.Dien_Giai = txtDienGiai.Text;
                _thanhToanUpdate.Thoi_Gian_TT = dtNgayThanhToan.Value;
                _repository.SaveChange();
                HasReloadList = true;
            }
            Close();
        }

        private bool Validation()
        {
            if (txtTen.Text.Length > 50) {
                MessageBox.Show("Tên thanh toán phải nhỏ hơn hoặc bằng 50 ký tự.");
                return false;
            }

            if (txtDienGiai.Text.Length > 255) {
                MessageBox.Show("Diễn giải phải nhỏ hơn hoặc bằng 255 ký tự.");
                return false;
            }
            if (txtSoTien.Text.Length > 50) {
                MessageBox.Show("Số tiền phải nhỏ hơn hoặc bằng 50 ký tự.");
                return false;
            }
            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtSoTien_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }

            // If you want, you can allow decimal (float) numbers
            if ((e.KeyChar == '.') && (txtSoTien.Text.IndexOf('.') > -1)) {
                e.Handled = true;
            }
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = !string.IsNullOrEmpty(txtTen.Text);
        }
    }
}
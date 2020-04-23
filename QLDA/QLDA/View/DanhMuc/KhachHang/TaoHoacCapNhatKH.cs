using QLDA.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.DanhMuc.KhachHang
{
    public partial class TaoHoacCapNhatKH : Form
    {
        private int? _idUpdate;
        private Model.KhachHang _khachHangUpdate;
        private RepositoryWrapper _repository;

        public bool HasReloadList { get; private set; } = false;

        public TaoHoacCapNhatKH()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            _repository = RepositoryWrapper.Create();
            Text = "Tạo mới khách hàng";
        }

        public TaoHoacCapNhatKH(int idUpdate)
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            _idUpdate = idUpdate;
            InitUpdate();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Validation()) {
                return;
            }

            if (_idUpdate == null) {
                Model.KhachHang khachHang = new Model.KhachHang() {
                    Ten = txtTenKH.Text,
                    Dia_Chi = txtDC.Text,
                    SDT = txtSDT.Text,
                    MST = txtMST.Text,
                    STK = txtSTK.Text,
                    Ten_NH = txtTenNH.Text
                };
                _repository.KhachHang.Add(khachHang);
                _repository.SaveChange();
                HasReloadList = true;
            }
            else {
                _khachHangUpdate.Ten = txtTenKH.Text;
                _khachHangUpdate.Dia_Chi = txtDC.Text;
                _khachHangUpdate.SDT = txtSDT.Text;
                _khachHangUpdate.MST = txtMST.Text;
                _khachHangUpdate.STK = txtSTK.Text;
                _khachHangUpdate.Ten_NH = txtTenNH.Text;
                _repository.SaveChange();
                HasReloadList = true;
            }

            Close();
        }

        private void InitUpdate()
        {
            _khachHangUpdate = _repository.KhachHang.FindByCondition(k => k.Ma_KH == _idUpdate).FirstOrDefault();
            if (_khachHangUpdate == null) {
                return;
            }
            txtTenKH.Text = _khachHangUpdate.Ten;
            txtDC.Text = _khachHangUpdate.Dia_Chi;
            txtSDT.Text = _khachHangUpdate.SDT;
            txtMST.Text = _khachHangUpdate.MST;
            txtSTK.Text = _khachHangUpdate.STK;
            txtTenNH.Text = _khachHangUpdate.Ten_NH;
            Text = "Chỉnh sửa thông tin khách hàng " + Define.PREFIX_KHACH_HANG + _khachHangUpdate.Ma_KH;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTenKH_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = !string.IsNullOrEmpty(txtTenKH.Text);
        }

        private bool Validation()
        {
            if (txtTenKH.Text.Length > 50) {
                MessageBox.Show("Tên khách hàng phải nhỏ hơn hoặc bằng 50 ký tự");
                return false;
            }
            if (txtDC.Text.Length > 100) {
                MessageBox.Show("Địa chỉ phải nhỏ hơn hoặc bằng 50 ký tự");
                return false;
            }
            if (txtSDT.Text.Length > 10) {
                MessageBox.Show("Số điện thoại phải nhỏ hơn hoặc bằng 50 ký tự");
                return false;
            }
            if (txtMST.Text.Length > 15) {
                MessageBox.Show("Mã số thuế phải nhỏ hơn hoặc bằng 50 ký tự");
                return false;
            }
            if (txtSTK.Text.Length > 15) {
                MessageBox.Show("Số tài khoản phải nhỏ hơn hoặc bằng 50 ký tự");
                return false;
            }
            if (txtTenNH.Text.Length > 50) {
                MessageBox.Show("Tên ngân hàng phải nhỏ hơn hoặc bằng 50 ký tự");
                return false;
            }
            return true;
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }
    }
}
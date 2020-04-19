using QLDA.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.DanhMuc.NhanVien
{
    public partial class TaoHoacCapNhatNV : Form
    {
        private int? _idUpdate;
        private Model.NhanVien _nhanVienUpdate;
        private RepositoryWrapper _repository;

        public bool HasReloadList { get; private set; } = false;

        public TaoHoacCapNhatNV()
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            Text = Define.THEM_MOI_NHAN_VIEN;
            btnLuu.Enabled = false;
        }

        public TaoHoacCapNhatNV(int idUpdate)
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            Text = Define.CHINH_SUA_NHAN_VIEN;
            _idUpdate = idUpdate;
            InitUpdate();
        }

        private void InitUpdate()
        {
            _nhanVienUpdate = _repository.NhanVien.FindByCondition(x => x.Ma_NV == _idUpdate).FirstOrDefault();
            if (_nhanVienUpdate == null) {
                return;
            }
            txtTenNV.Text = _nhanVienUpdate.Ten;
            txtDC.Text = _nhanVienUpdate.Dia_Chi;
            txtSDT.Text = _nhanVienUpdate.SDT;
            txtEmail.Text = _nhanVienUpdate.Email;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Validation()) {
                return;
            }
            if (_idUpdate == null) {
                Model.NhanVien nhanVien = new Model.NhanVien() {
                    Ten = txtTenNV.Text,
                    Dia_Chi = txtDC.Text,
                    SDT = txtSDT.Text,
                    Email = txtEmail.Text,
                };
                _repository.NhanVien.Add(nhanVien);
                _repository.SaveChange();
                HasReloadList = true;
                this.Close();
            }
            else {
                if (_nhanVienUpdate == null) {
                    return;
                }
                _nhanVienUpdate.Ten = txtTenNV.Text;
                _nhanVienUpdate.Dia_Chi = txtDC.Text;
                _nhanVienUpdate.SDT = txtSDT.Text;
                _nhanVienUpdate.Email = txtEmail.Text;
                _repository.SaveChange();
                HasReloadList = true;
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenNV_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = !string.IsNullOrEmpty(txtTenNV.Text);
        }

        private bool Validation()
        {
            if (txtTenNV.Text.Length > 50) {
                MessageBox.Show("Tên nhân viên phải nhỏ hơn hoặc bằng 50 ký tự");
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
            if (txtEmail.Text.Length > 50) {
                MessageBox.Show("Email phải nhỏ hơn hoặc bằng 50 ký tự");
                return false;
            }

            return true;
        }
    }
}
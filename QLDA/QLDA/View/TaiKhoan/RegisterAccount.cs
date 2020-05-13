using QLDA.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.TaiKhoan
{
    public partial class RegisterAccount : Form
    {
        private RepositoryWrapper _repositoryWrapper;
        private int? _idAccountUpdate;

        public RegisterAccount()
        {
            InitializeComponent();
            _repositoryWrapper = RepositoryWrapper.Create();
            cbxRole.Items.Add(Define.User);
            cbxRole.Items.Add(Define.Admin);
            cbxRole.SelectedIndex = 0;
        }

        public RegisterAccount(int idAccountUpdate)
        {
            InitializeComponent();
            _repositoryWrapper = RepositoryWrapper.Create();
            cbxRole.Items.Add(Define.User);
            cbxRole.Items.Add(Define.Admin);
            cbxRole.SelectedIndex = 0;
            _idAccountUpdate = idAccountUpdate;
            InitUpdate();
        }

        private bool InitUpdate()
        {
            var tk = _repositoryWrapper.TaiKhoan.FindByCondition(x => x.Ma_TK == _idAccountUpdate).FirstOrDefault();
            if (tk == null) {
                MessageBox.Show("Không tìm thấy tài khoản để cập nhật");
                return false;
            }

            txtTen.Text = tk.Ten;
            txtEmail.Text = tk.Email;
            cbxRole.SelectedItem = tk.Role;

            txtTen.Enabled = false;
            txtEmail.Enabled = false;

            return true;
        }

        public bool HasReloadList { get; internal set; }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_idAccountUpdate == null) {
                if (!Validation()) {
                    return;
                }
                var tk = new Model.TaiKhoan() {
                    Ten = txtTen.Text,
                    MK = txtMK.Text,
                    Email = txtEmail.Text,
                    Role = cbxRole.SelectedItem.ToString()
                };
                _repositoryWrapper.TaiKhoan.Add(tk);
                _repositoryWrapper.SaveChange();
            }
            else {
                if (!Validation(true)) {
                    return;
                }
                var tk = _repositoryWrapper.TaiKhoan.FindByCondition(x => x.Ma_TK == _idAccountUpdate).FirstOrDefault();
                tk.MK = txtMK.Text;
                tk.Role = cbxRole.SelectedItem.ToString();
                _repositoryWrapper.SaveChange();
            }
            HasReloadList = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Validation(bool isUpdate = false)
        {
            if (!isUpdate) {
                if (string.IsNullOrEmpty(txtTen.Text) || txtTen.Text.Length > 50) {
                    MessageBox.Show("Tên tài khoản không hợp lệ");
                    return false;
                }
                var count = _repositoryWrapper.TaiKhoan.FindByCondition(x => x.Ten.Equals(txtTen.Text)).Count();
                if (count > 0) {
                    MessageBox.Show("Tên tài khoản đã được đăng ký hãy nhập tên khác");
                    return false;
                }
                if (string.IsNullOrEmpty(txtEmail.Text) || txtEmail.Text.Length > 255 || !txtEmail.Text.Contains("@")) {
                    MessageBox.Show("Email không hợp lệ");
                    return false;
                }
                var countEmail = _repositoryWrapper.TaiKhoan.FindByCondition(x => x.Email.Equals(txtEmail.Text)).Count();
                if (countEmail > 0) {
                    MessageBox.Show("Email đã được đăng ký, hãy nhập email khác");
                    return false;
                }
            }

            if (string.IsNullOrEmpty(txtMK.Text) || txtMK.Text.Length > 50) {
                MessageBox.Show("Mật khẩu không hợp lệ");
                return false;
            }

            return true;
        }
    }
}
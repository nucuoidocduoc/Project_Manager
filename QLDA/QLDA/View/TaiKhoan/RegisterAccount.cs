using QLDA.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.TaiKhoan
{
    public partial class RegisterAccount : Form
    {
        private RepositoryWrapper _repositoryWrapper;

        public RegisterAccount()
        {
            InitializeComponent();
            _repositoryWrapper = RepositoryWrapper.Create();
            cbxRole.Items.Add(Define.User);
            cbxRole.Items.Add(Define.Admin);
            cbxRole.SelectedIndex = 0;
        }

        public bool HasReloadList { get; internal set; }

        private void btnLuu_Click(object sender, EventArgs e)
        {
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
            HasReloadList = true;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Validation()
        {
            if (string.IsNullOrEmpty(txtTen.Text) || txtTen.Text.Length > 50) {
                MessageBox.Show("Tên tài khoản không hợp lệ");
                return false;
            }
            var count = _repositoryWrapper.TaiKhoan.FindByCondition(x => x.Ten.Equals(txtTen.Text)).Count();
            if (count > 0) {
                MessageBox.Show("Tên tài khoản đã được đăng ký hãy nhập tên khác");
                return false;
            }
            if (string.IsNullOrEmpty(txtMK.Text) || txtMK.Text.Length > 50) {
                MessageBox.Show("Mật khẩu không hợp lệ");
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
            return true;
        }
    }
}
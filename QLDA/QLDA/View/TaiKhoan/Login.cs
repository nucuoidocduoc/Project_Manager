using QLDA.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.TaiKhoan
{
    public partial class Login : Form
    {
        private RepositoryWrapper _repository;

        public Login()
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            txtMK.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTen.Text) || string.IsNullOrEmpty(txtMK.Text)) {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu chưa chính xác");
                return;
            }
            var tk = _repository.TaiKhoan.FindByCondition(x => x.Ten.Equals(txtTen.Text) && x.MK.Equals(txtMK.Text)).FirstOrDefault();
            if (tk == null) {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu chưa chính xác");
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
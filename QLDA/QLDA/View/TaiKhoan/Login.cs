using QLDA.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.TaiKhoan
{
    public partial class Login : Form
    {
        private RepositoryWrapper _repository;
        public int IdLogin { get; private set; }

        public Login()
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            _repository.TaiKhoan.FindAll().ToList();
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
            IdLogin = tk.Ma_TK;
            DialogResult = DialogResult.OK;
            Close();
            //var form = new MainForm(tk.Ma_TK);
            //form.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                btnLogin_Click(null, null);
            }
        }

        private void txtMK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                btnLogin_Click(null, null);
            }
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13) {
                btnLogin_Click(null, null);
            }
        }
    }
}
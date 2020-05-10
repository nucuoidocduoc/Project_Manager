using QLDA.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.DanhMuc.NhomDA
{
    public partial class TaoHoacCapNhatNhomDA : Form
    {
        private int? _idUpdate;
        private Model.NhomDA _nhomDAUpdate;
        private RepositoryWrapper _repository;

        public bool HasReloadList { get; private set; }

        public TaoHoacCapNhatNhomDA()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            _repository = RepositoryWrapper.Create();
            Text = "Tạo mới nhóm dự án";
        }

        public TaoHoacCapNhatNhomDA(int idUpdate)
        {
            InitializeComponent();
            _idUpdate = idUpdate;
            _repository = RepositoryWrapper.Create();
            Text = "Cập nhật nhóm dự án";
            InitUpdate();
        }

        private void InitUpdate()
        {
            _nhomDAUpdate = _repository.NhomDA.FindByCondition(x => x.Ma_Nhom == _idUpdate).FirstOrDefault();
            if (_nhomDAUpdate == null) {
                return;
            }
            txtTen.Text = _nhomDAUpdate.Ten;
            txtDienGiai.Text = _nhomDAUpdate.Dien_Giai;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Validation()) {
                return;
            }
            if (_idUpdate == null) {
                Model.NhomDA nhomDA = new Model.NhomDA() {
                    Ten = txtTen.Text,

                    Dien_Giai = txtDienGiai.Text
                };
                _repository.NhomDA.Add(nhomDA);
                _repository.SaveChange();
                HasReloadList = true;
            }
            else {
                _nhomDAUpdate.Ten = txtTen.Text;

                _nhomDAUpdate.Dien_Giai = txtDienGiai.Text;
                _repository.SaveChange();
                HasReloadList = true;
            }
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private bool Validation()
        {
            if (txtTen.Text.Length > 50) {
                MessageBox.Show("Tên phải nhỏ hơn hoặc bằng 50 ký tự");
                return false;
            }

            return true;
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnLuu.Enabled = !string.IsNullOrEmpty(txtTen.Text);
        }
    }
}
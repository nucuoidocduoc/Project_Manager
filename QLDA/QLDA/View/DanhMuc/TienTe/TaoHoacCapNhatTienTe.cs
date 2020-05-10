using QLDA.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.DanhMuc.TienTe
{
    public partial class TaoHoacCapNhatTienTe : Form
    {
        private int? _idUpdate;
        private Model.TienTe _tienTeUpdate;
        private RepositoryWrapper _repository;

        public bool HasReloadList { get; private set; }

        public TaoHoacCapNhatTienTe()
        {
            InitializeComponent();
            btnLuu.Enabled = false;
            _repository = RepositoryWrapper.Create();
            Text = "Tạo mới tiền tệ";
        }

        public TaoHoacCapNhatTienTe(int idUpdate)
        {
            InitializeComponent();
            _idUpdate = idUpdate;
            _repository = RepositoryWrapper.Create();
            Text = "Cập nhật tiền tệ";
            InitUpdate();
        }

        private void InitUpdate()
        {
            _tienTeUpdate = _repository.TienTe.FindByCondition(x => x.Ma_Tien_Te == _idUpdate).FirstOrDefault();
            if (_tienTeUpdate == null) {
                return;
            }
            txtTen.Text = _tienTeUpdate.Ten;
            txtTiGia.Text = _tienTeUpdate.Ti_gia.ToString();
            txtDienGiai.Text = _tienTeUpdate.Dien_Giai;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Validation()) {
                return;
            }
            if (_idUpdate == null) {
                Model.TienTe tienTe = new Model.TienTe() {
                    Ten = txtTen.Text,
                    Ti_gia = double.Parse(txtTiGia.Text),
                    Dien_Giai = txtDienGiai.Text
                };
                _repository.TienTe.Add(tienTe);
                _repository.SaveChange();
                HasReloadList = true;
            }
            else {
                _tienTeUpdate.Ten = txtTen.Text;
                _tienTeUpdate.Ti_gia = double.Parse(txtTiGia.Text);
                _tienTeUpdate.Dien_Giai = txtDienGiai.Text;
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
                MessageBox.Show("Tên tiền tệ phải nhỏ hơn hoặc bằng 50 ký tự");
                return false;
            }
            if (!double.TryParse(txtTiGia.Text, out double value)) {
                MessageBox.Show("Tỉ giá phải có giá trị phù hợp");
                return false;
            }
            return true;
        }

        private void txtTiGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) {
                e.Handled = true;
            }
        }

        private void txtTen_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnLuu.Enabled = !string.IsNullOrEmpty(txtTen.Text);
        }
    }
}
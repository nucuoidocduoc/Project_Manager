using QLDA.Repository;
using QLDA.View.Template;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.QuanLyCongViec.QuyTrinh
{
    public partial class TaoHoacCapNhatQuyTrinh : Form
    {
        private int _id;
        private bool _isCreate;
        private RepositoryWrapper _repository;

        public bool HasReloadList { get; private set; }

        public TaoHoacCapNhatQuyTrinh()
        {
            InitializeComponent();
        }

        public TaoHoacCapNhatQuyTrinh(int id, bool isCreate = false)
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            _id = id;
            _isCreate = isCreate;
            InitCombobox();
            if (isCreate) {
                InitCreate();
            }
            else {
                InitUpdate();
            }
        }

        private void InitUpdate()
        {
            var qtUpdate = _repository.QuyTrinh.FindByCondition(x => x.Ma_QT == _id).FirstOrDefault();
            if (qtUpdate == null) {
                return;
            }
            txtTen.Text = qtUpdate.Ten;
            cbxLoaiQT.SelectedValue = qtUpdate.Loai_QT;
            dtStartDate.Value = qtUpdate.Thoi_Gian_BD;
            dtEndDate.Value = qtUpdate.Thoi_Gian_KT;
            cbxTrangThai.SelectedValue = qtUpdate.Trang_Thai;
            if (qtUpdate.Ma_NV != null) {
                foreach (var item in cbxNhanVien.Items) {
                    ItemComboboxTemplate template = (ItemComboboxTemplate)item;
                    if (template.Id == qtUpdate.Ma_NV) {
                        cbxNhanVien.SelectedItem = item;
                    }
                }
            }
            else {
                cbxNhanVien.SelectedIndex = 0;
            }
            foreach (var item in cbxDuAn.Items) {
                ItemComboboxTemplate template = (ItemComboboxTemplate)item;
                if (template.Id == qtUpdate.Ma_DA) {
                    cbxDuAn.SelectedItem = item;
                }
            }
            Text = "Chỉnh sửa quy trình " + Define.PREFIX_QUI_TRINH + qtUpdate.Ma_QT;
        }

        private void InitCreate()
        {
            if (_id >= 0) {
                foreach (var item in cbxDuAn.Items) {
                    ItemComboboxTemplate template = (ItemComboboxTemplate)item;
                    if (template.Id == _id) {
                        cbxDuAn.SelectedItem = item;
                    }
                }
                cbxDuAn.Enabled = false;
            }
            btnLuu.Enabled = false;
            Text = "Tạo mới quy trình";
        }

        private void InitCombobox()
        {
            InitNhanVien();
            InitDuAn();
            InitLoaiQT();
            InitTrangThai();
        }

        private void InitNhanVien()
        {
            var nvs = _repository.NhanVien.FindAll().ToList();
            cbxNhanVien.Items.Add(new ItemComboboxTemplate() { Content = "None" });
            foreach (var nv in nvs) {
                cbxNhanVien.Items.Add(new ItemComboboxTemplate() { Id = nv.Ma_NV, Prefix = Define.PREFIX_NHAN_VIEN + nv.Ma_NV, Content = nv.Ten });
            }
            cbxNhanVien.SelectedIndex = 0;
        }

        private void InitDuAn()
        {
            var dAs = _repository.DuAn.FindAll().ToList();
            foreach (var da in dAs) {
                cbxDuAn.Items.Add(new ItemComboboxTemplate() { Id = da.Ma_DA, Prefix = Define.PREFIX_DU_AN + da.Ma_DA, Content = da.Ten });
            }
            cbxDuAn.SelectedIndex = 0;
        }

        private void InitLoaiQT()
        {
            cbxLoaiQT.Items.Add("Khảo sát");
            cbxLoaiQT.Items.Add("Thiết kế");
            cbxLoaiQT.SelectedIndex = 0;
        }

        private void InitTrangThai()
        {
            cbxTrangThai.Items.Add("Chưa thực hiện");
            cbxTrangThai.Items.Add("Đang thực hiện");
            cbxTrangThai.Items.Add("Đã xong");
            cbxTrangThai.SelectedIndex = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Validation()) {
                return;
            }
            if (_isCreate) {
                Model.QuyTrinh quyTrinh = new Model.QuyTrinh() {
                    Ten = txtTen.Text,
                    Loai_QT = cbxLoaiQT.SelectedItem.ToString(),
                    Ma_NV = ((ItemComboboxTemplate)cbxNhanVien.SelectedItem).Id,
                    Ma_DA = (int)((ItemComboboxTemplate)cbxDuAn.SelectedItem).Id,
                    Thoi_Gian_BD = dtStartDate.Value,
                    Thoi_Gian_KT = dtEndDate.Value,
                    Trang_Thai = cbxTrangThai.SelectedItem.ToString()
                };
                _repository.QuyTrinh.Add(quyTrinh);
                _repository.SaveChange();
                HasReloadList = true;
            }
            else {
                var quytrinh = _repository.QuyTrinh.FindByCondition(x => x.Ma_QT == _id).FirstOrDefault();
                if (quytrinh != null) {
                    quytrinh.Ten = txtTen.Text;
                    quytrinh.Loai_QT = cbxLoaiQT.SelectedItem.ToString();
                    quytrinh.Ma_NV = ((ItemComboboxTemplate)cbxNhanVien.SelectedItem).Id;
                    quytrinh.Ma_DA = (int)((ItemComboboxTemplate)cbxDuAn.SelectedItem).Id;
                    quytrinh.Thoi_Gian_BD = dtStartDate.Value;
                    quytrinh.Thoi_Gian_KT = dtEndDate.Value;
                    quytrinh.Trang_Thai = cbxTrangThai.SelectedItem.ToString();
                    _repository.SaveChange();
                    HasReloadList = true;
                }
            }
            Close();
        }

        private bool Validation()
        {
            if (txtTen.Text.Length > 50) {
                MessageBox.Show("Tên quy trình phải nhỏ hơn hoặc bằng 50 ký tự.");
                return false;
            }

            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = !string.IsNullOrEmpty(txtTen.Text);
        }
    }
}
using QLDA.Repository;
using QLDA.View.Template;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.QuanLyCongViec.CongViec
{
    public partial class TaoHoacCapNhatCV : Form
    {
        private int _id;
        private bool _isCreate;
        private RepositoryWrapper _repository;

        public bool HasReloadList { get; private set; }

        public TaoHoacCapNhatCV()
        {
            InitializeComponent();
        }

        public TaoHoacCapNhatCV(int id, bool isCreate = false)
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
            InitNV();
            if (_id >= 0) {
                var qt = _repository.QuyTrinh.FindByCondition(x => x.Ma_QT == _id).FirstOrDefault();
                if (qt == null) {
                    return;
                }
                foreach (var item in cbxDuAn.Items) {
                    int idItem = (int)((ItemComboboxTemplate)item).Id;
                    if (qt.Ma_DA == idItem) {
                        cbxDuAn.SelectedItem = item;

                        break;
                    }
                }
                foreach (var item in cbxQT.Items) {
                    int idItem = (int)((ItemComboboxTemplate)item).Id;
                    if (qt.Ma_QT == idItem) {
                        cbxQT.SelectedItem = item;
                        break;
                    }
                }
                cbxQT.Enabled = false;
                cbxDuAn.Enabled = false;
            }
            else {
                InitQT();
            }
            Text = "Tạo mới công việc";
        }

        private void InitUpdate()
        {
            InitDuAn();
            InitNV();
            var cvUpdate = _repository.CongViec.FindByCondition(x => x.Ma_QT == _id).FirstOrDefault();
            if (cvUpdate == null) {
                return;
            }
            var qt = _repository.QuyTrinh.FindByCondition(x => x.Ma_QT == cvUpdate.Ma_QT).FirstOrDefault();
            if (qt == null) {
                return;
            }
            foreach (var item in cbxDuAn.Items) {
                int idItem = (int)((ItemComboboxTemplate)item).Id;
                if (qt.Ma_DA == idItem) {
                    cbxDuAn.SelectedItem = item;
                    InitQT();
                    break;
                }
            }
            foreach (var item in cbxQT.Items) {
                int idItem = (int)((ItemComboboxTemplate)item).Id;
                if (qt.Ma_QT == idItem) {
                    cbxQT.SelectedItem = item;
                    break;
                }
            }
            if (cvUpdate.Ma_NV != null) {
                foreach (var item in cbxNhanVien.Items) {
                    int? idItem = ((ItemComboboxTemplate)item).Id;
                    if (idItem != null && idItem == cvUpdate.Ma_NV) {
                        cbxNhanVien.SelectedItem = item;
                        break;
                    }
                }
            }
            else {
                cbxNhanVien.SelectedItem = 0;
            }
            txtTen.Text = cvUpdate.Ten;
            txtTaiLieu.Text = cvUpdate.Tai_Lieu;
            cbxUuTien.SelectedItem = cvUpdate.Muc_Do_UT;
            cbxTrangThai.SelectedItem = cvUpdate.Trang_Thai;
            dtEnd.Value = cvUpdate.Thoi_Gian_HH;
            dtRealEnd.Value = cvUpdate.Thoi_Gian_Giao;

            cbxDuAn.Enabled = false;
            cbxQT.Enabled = false;
            Text = "Chỉnh sửa công việc " + Define.PREFIX_CONG_VIEC + cvUpdate.Ma_CV;
        }

        private void InitCBX()
        {
            cbxUuTien.Items.Add("1");
            cbxUuTien.Items.Add("2");
            cbxUuTien.Items.Add("3");
            cbxUuTien.Items.Add("4");
            cbxTrangThai.Items.Add("Đã hoàn thành");
            cbxTrangThai.Items.Add("Chưa hoàn thành");
            cbxUuTien.SelectedIndex = 0;
            cbxTrangThai.SelectedIndex = 0;
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

        private void InitQT()
        {
            cbxQT.Items.Clear();
            int idDuAnSelected = (int)((ItemComboboxTemplate)cbxDuAn.SelectedItem).Id;
            var qts = _repository.QuyTrinh.FindByCondition(x => x.Ma_DA == idDuAnSelected).ToList();
            if (qts == null || qts.Count < 1) {
                return;
            }
            foreach (var item in qts) {
                cbxQT.Items.Add(new ItemComboboxTemplate() { Id = item.Ma_QT, Prefix = Define.PREFIX_QUI_TRINH + item.Ma_QT, Content = item.Ten });
            }
            cbxQT.SelectedIndex = 0;
        }

        private void InitNV()
        {
            var nvs = _repository.NhanVien.FindAll().ToList();
            cbxNhanVien.Items.Add(new ItemComboboxTemplate() { Content = "None" });
            foreach (var nv in nvs) {
                cbxNhanVien.Items.Add(new ItemComboboxTemplate() { Id = nv.Ma_NV, Prefix = Define.PREFIX_NHAN_VIEN + nv.Ma_NV, Content = nv.Ten });
            }
            cbxNhanVien.SelectedIndex = 0;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!Validation()) {
                return;
            }
            if (_isCreate) {
                Model.CongViec cv = new Model.CongViec() {
                    Ten = txtTen.Text,
                    Muc_Do_UT = int.Parse(cbxUuTien.SelectedItem.ToString()),
                    Thoi_Gian_Giao = dtRealEnd.Value,
                    Thoi_Gian_HH = dtEnd.Value,
                    Tai_Lieu = txtTaiLieu.Text,
                    Trang_Thai = cbxTrangThai.SelectedItem.ToString(),
                    Ma_QT = (int)((ItemComboboxTemplate)cbxQT.SelectedItem).Id
                };
                _repository.CongViec.Add(cv);
                _repository.SaveChange();
                HasReloadList = true;
            }
            else {
                var cv = _repository.CongViec.FindByCondition(x => x.Ma_CV == _id).FirstOrDefault();
                if (cv != null) {
                    cv.Ten = txtTen.Text;
                    cv.Muc_Do_UT = int.Parse(cbxUuTien.SelectedItem.ToString());
                    cv.Thoi_Gian_Giao = dtRealEnd.Value;
                    cv.Thoi_Gian_HH = dtEnd.Value;
                    cv.Tai_Lieu = txtTaiLieu.Text;
                    cv.Trang_Thai = cbxTrangThai.SelectedItem.ToString();
                    cv.Ma_QT = (int)((ItemComboboxTemplate)cbxQT.SelectedItem).Id;
                    _repository.SaveChange();
                    HasReloadList = true;
                }
            }
            Close();
        }

        private bool Validation()
        {
            if (txtTen.Text.Length > 50) {
                MessageBox.Show("Tên công việc phải nhỏ hơn hoặc bằng 50 ký tự.");
                return false;
            }

            return true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbxDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            InitQT();
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            btnLuu.Enabled = !string.IsNullOrEmpty(txtTen.Text);
        }
    }
}
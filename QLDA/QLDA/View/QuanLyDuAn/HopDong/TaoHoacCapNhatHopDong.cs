using QLDA.Repository;
using QLDA.View.Template;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.QuanLyDuAn.HopDong
{
    public partial class TaoHoacCapNhatHopDong : Form
    {
        private RepositoryWrapper _repository;
        private bool _isCreate;
        private int _id;
        private Model.HopDong _hopDongUpdate;
        public bool HasReloadList { get; private set; }

        public TaoHoacCapNhatHopDong()
        {
            InitializeComponent();
        }

        public TaoHoacCapNhatHopDong(int id, bool isCreate = false)
        {
            InitializeComponent();
            _isCreate = isCreate;
            _id = id;
            _repository = RepositoryWrapper.Create();
            InitCombobox();
            if (isCreate) {
                InitCreate();
            }
            else {
                InitUpdate();
            }
        }

        private bool InitCombobox()
        {
            var duAns = _repository.DuAn.FindAll().ToList();
            if (duAns == null || duAns.Count == 0) {
                return false;
            }
            foreach (var duAn in duAns) {
                cbxDuAn.Items.Add(new ItemComboboxTemplate() { Id = duAn.Ma_DA, Prefix = Define.PREFIX_DU_AN + duAn.Ma_DA, Content = duAn.Ten });
            }
            cbxTrangThai.Items.Add(Define.FINISHED);
            cbxTrangThai.Items.Add(Define.PAUSE);
            cbxTrangThai.Items.Add(Define.UNFINISH);
            cbxTrangThai.SelectedIndex = 0;
            return true;
        }

        private void InitCreate()
        {
            cbxDuAn.SelectedIndex = 0;
            if (_id > 0) {
                foreach (var item in cbxDuAn.Items) {
                    ItemComboboxTemplate template = (ItemComboboxTemplate)item;
                    if (template.Id == _id) {
                        cbxDuAn.SelectedItem = item;
                        break;
                    }
                }
                cbxDuAn.Enabled = false;
            }
            dtStartDate.Value = DateTime.Now;
            dtEndDate.Value = DateTime.Now;
        }

        private void InitUpdate()
        {
            _hopDongUpdate = _repository.HopDong.FindByCondition(x => x.Ma_HD == _id).FirstOrDefault();
            if (_hopDongUpdate == null) {
                return;
            }
            txtTen.Text = _hopDongUpdate.Ten;
            dtStartDate.Value = _hopDongUpdate.Thoi_Diem_Ky;
            dtEndDate.Value = _hopDongUpdate.Thoi_Gian_KT;
            txtTongGiaTri.Text = _hopDongUpdate.Tong_Gia_Tri;
            cbxTrangThai.SelectedItem = _hopDongUpdate.Trang_Thai;
            txtDienGiai.Text = _hopDongUpdate.Dien_Giai;
            foreach (var item in cbxDuAn.Items) {
                ItemComboboxTemplate template = (ItemComboboxTemplate)item;
                if (template.Id == _hopDongUpdate.Ma_DA) {
                    cbxDuAn.SelectedItem = item;
                    break;
                }
            }
            cbxDuAn.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (_isCreate) {
                Model.HopDong hopDong = new Model.HopDong() {
                    Ten = txtTen.Text,
                    Thoi_Diem_Ky = dtStartDate.Value,
                    Thoi_Gian_KT = dtEndDate.Value,
                    Ma_DA = (int)((ItemComboboxTemplate)cbxDuAn.SelectedItem).Id,
                    Tong_Gia_Tri = txtTongGiaTri.Text,
                    Trang_Thai = cbxTrangThai.SelectedItem.ToString(),
                    Dien_Giai = txtDienGiai.Text
                };
                _repository.HopDong.Add(hopDong);
                _repository.SaveChange();
                HasReloadList = true;
            }
            else {
                _hopDongUpdate.Ten = txtTen.Text;
                _hopDongUpdate.Thoi_Diem_Ky = dtStartDate.Value;
                _hopDongUpdate.Thoi_Gian_KT = dtEndDate.Value;

                _hopDongUpdate.Tong_Gia_Tri = txtTongGiaTri.Text;
                _hopDongUpdate.Trang_Thai = cbxTrangThai.SelectedItem.ToString();
                _hopDongUpdate.Dien_Giai = txtDienGiai.Text;
                _repository.SaveChange();
                HasReloadList = true;
            }
            Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDA.Repository;
using QLDA.View.Template;

namespace QLDA.View.QuanLyDuAn.ThanhToan.CheDoXem
{
    public partial class XemThanhToanTheoDuAn : UserControl
    {
        private RepositoryWrapper _repository;
        private int? _currentIdDASelected;
        private int? _currentIdHDSelected;

        public XemThanhToanTheoDuAn()
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            InitTemplateDsTT();
            InitDsDA();
        }

        private void InitDsDA()
        {
            var dAs = _repository.DuAn.FindAll().ToList();
            if (dAs == null || dAs.Count < 1) {
                return;
            }
            foreach (var da in dAs) {
                lvDuAn.Items.Add(new ListViewItem(Define.PREFIX_DU_AN + da.Ma_DA + " " + da.Ten) { Tag = da.Ma_DA });
            }
        }

        private void InitDsTT(bool isReloadRepository = false)
        {
            if (isReloadRepository) {
                _repository = RepositoryWrapper.Create();
            }
            lvThanhToan.Items.Clear();
            var thanhToans = _repository.ThanhToan.FindByCondition(x => x.Ma_HD == _currentIdHDSelected).ToList();
            foreach (var tt in thanhToans) {
                string[] values = new string[] {
                    Define.PREFIX_THANH_TOAN+tt.Ma_TT,
                    tt.Ten,
                    tt.So_Tien,
                    tt.Loai_Tien,
                    tt.Hinh_Thuc,
                    tt.Thoi_Gian_TT.ToLongDateString()
                };
                lvThanhToan.Items.Add(new ListViewItem(values) { Tag = tt.Ma_TT });
            }
        }

        private void InitTemplateDsTT()
        {
            lvThanhToan.View = System.Windows.Forms.View.Details;
            lvThanhToan.Columns.Add(DanhSachThanhToanTemplate.Id, Convert.ToInt32(lvThanhToan.Width * 0.1), HorizontalAlignment.Center);
            lvThanhToan.Columns.Add(DanhSachThanhToanTemplate.Name, Convert.ToInt32(lvThanhToan.Width * 0.2), HorizontalAlignment.Center);
            lvThanhToan.Columns.Add(DanhSachThanhToanTemplate.Much, Convert.ToInt32(lvThanhToan.Width * 0.1), HorizontalAlignment.Center);
            lvThanhToan.Columns.Add(DanhSachThanhToanTemplate.Type, Convert.ToInt32(lvThanhToan.Width * 0.1), HorizontalAlignment.Center);
            lvThanhToan.Columns.Add(DanhSachThanhToanTemplate.Mode, Convert.ToInt32(lvThanhToan.Width * 0.3), HorizontalAlignment.Center);
            lvThanhToan.Columns.Add(DanhSachThanhToanTemplate.Date, Convert.ToInt32(lvThanhToan.Width * 0.2), HorizontalAlignment.Center);
        }

        private void InitDsHD(bool isReloadRepo = false)
        {
            if (_currentIdDASelected == null) {
                return;
            }
            if (isReloadRepo) {
                _repository = RepositoryWrapper.Create();
            }
            cbxHopDong.Items.Clear();
            var hds = _repository.HopDong.FindByCondition(h => h.Ma_DA == _currentIdDASelected).ToList();

            if (hds.Count < 1) {
                lvThanhToan.Items.Clear();
                cbxHopDong.SelectedItem = null;
                _currentIdHDSelected = null;
                Refresh();
                return;
            }
            foreach (var item in hds) {
                cbxHopDong.Items.Add(new ItemComboboxTemplate() { Id = item.Ma_HD, Prefix = Define.PREFIX_HOP_DONG + item.Ma_HD, Content = item.Ten });
            }
            cbxHopDong.SelectedIndex = 0;
            _currentIdHDSelected = hds[0].Ma_HD;
            InitDsTT();
            CalculateWorthHD();
        }

        private void CalculateWorthHD()
        {
            var hd = _repository.HopDong.FindByCondition(x => x.Ma_HD == _currentIdHDSelected).FirstOrDefault();
            if (hd == null) {
                return;
            }
            var thanhToans = _repository.ThanhToan.FindByCondition(x => x.Ma_HD == _currentIdHDSelected).ToList();
        }

        private void lvDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDuAn.SelectedItems.Count > 0) {
                _currentIdDASelected = (int)lvDuAn.SelectedItems[0].Tag;
                InitDsHD();
            }
        }

        private void cbxHopDong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentIdDASelected == null) {
                return;
            }
            _currentIdHDSelected = ((ItemComboboxTemplate)cbxHopDong.SelectedItem).Id;
            InitDsTT();
            CalculateWorthHD();
        }

        public void Create()
        {
            if (_currentIdDASelected != null && _currentIdHDSelected != null) {
                var add = new TaoHoacCapNhatTT((int)_currentIdHDSelected, true);
                add.ShowDialog();
                if (add.HasReloadList) {
                    InitDsTT(true);
                }
            }
        }

        public void Updatee()
        {
            if (lvThanhToan.SelectedItems.Count > 0) {
                int idUpdate = (int)lvThanhToan.SelectedItems[0].Tag;
                var update = new TaoHoacCapNhatTT((int)lvThanhToan.SelectedItems[0].Tag);
                update.ShowDialog();
                if (update.HasReloadList) {
                    InitDsTT(true);
                }
            }
        }

        public void Delete()
        {
            if (lvThanhToan.SelectedItems.Count > 0 && Define.ConfirmDelete()) {
                int idDelete = (int)lvThanhToan.SelectedItems[0].Tag;
                var tt = _repository.ThanhToan.FindByCondition(x => x.Ma_TT == idDelete).FirstOrDefault();
                if (tt != null) {
                    _repository.ThanhToan.Delete(tt);
                    _repository.SaveChange();
                    InitDsTT(true);
                }
            }
        }
    }
}
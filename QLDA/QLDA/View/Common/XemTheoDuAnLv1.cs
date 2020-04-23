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
using QLDA.View.QuanLyDuAn.HopDong;
using QLDA.View.QuanLyCongViec.QuyTrinh;

namespace QLDA.View.Common
{
    public partial class XemTheoDuAnLv1 : UserControl
    {
        private ViewMode _viewType;
        private RepositoryWrapper _repository;
        private int? _currentIdDASelected;

        public XemTheoDuAnLv1()
        {
            InitializeComponent();
        }

        public XemTheoDuAnLv1(ViewMode viewType)
        {
            InitializeComponent();
            _viewType = viewType;
            _repository = RepositoryWrapper.Create();
            InitDA();
            if (viewType.Equals(ViewMode.HopDong)) {
                InitTemplateHD();
            }
            else if (viewType.Equals(ViewMode.QuyTrinh)) {
                InitTemplateQT();
            }
        }

        private void InitDA(int selectedIndexDA = 0)
        {
            var dAs = _repository.DuAn.FindAll().ToList();
            if (dAs == null || dAs.Count < 1) {
                return;
            }
            foreach (var da in dAs) {
                lvDuAn.Items.Add(new ListViewItem(Define.PREFIX_DU_AN + da.Ma_DA + " " + da.Ten) { Tag = da.Ma_DA });
            }
        }

        private void InitDsHD(bool isReloadRepo = false)
        {
            if (_currentIdDASelected == null) {
                return;
            }
            if (isReloadRepo) {
                _repository = RepositoryWrapper.Create();
            }
            lvDanhSachLv1.Items.Clear();
            var hds = _repository.HopDong.FindByCondition(h => h.Ma_DA == _currentIdDASelected).ToList();

            if (hds.Count < 1) {
                return;
            }
            foreach (var item in hds) {
                string[] itemValues = new string[] { Define.PREFIX_HOP_DONG + item.Ma_DA,
                    item.Ten,
                    item.Thoi_Diem_Ky.ToShortDateString(),
                    item.Thoi_Gian_KT.ToShortDateString(),
                    item.Tong_Gia_Tri,
                    item.Trang_Thai
                    };
                lvDanhSachLv1.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_HD });
            }
        }

        private void InitDsQT(bool isReloadRepo = false)
        {
            if (_currentIdDASelected == null) {
                return;
            }
            if (isReloadRepo) {
                _repository = RepositoryWrapper.Create();
            }
            lvDanhSachLv1.Items.Clear();
            var qts = _repository.QuyTrinh.FindByCondition(h => h.Ma_DA == _currentIdDASelected).ToList();
            if (qts.Count < 1) {
                return;
            }
            foreach (var item in qts) {
                string[] itemValues = new string[] { Define.PREFIX_HOP_DONG + item.Ma_DA,
                    item.Ten,
                    item.Loai_QT,
                    item.Thoi_Gian_BD.ToShortDateString(),
                    item.Thoi_Gian_KT.ToShortDateString(),
                    item.Trang_Thai
                    };
                lvDanhSachLv1.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_QT });
            }
        }

        private void InitTemplateHD()
        {
            lvDanhSachLv1.View = System.Windows.Forms.View.Details;
            lvDanhSachLv1.Columns.Add(DanhSachHopDongTemplate.Id, Convert.ToInt32(lvDanhSachLv1.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSachLv1.Columns.Add(DanhSachHopDongTemplate.Name, Convert.ToInt32(lvDanhSachLv1.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSachLv1.Columns.Add(DanhSachHopDongTemplate.StartDate, Convert.ToInt32(lvDanhSachLv1.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSachLv1.Columns.Add(DanhSachHopDongTemplate.EndDate, Convert.ToInt32(lvDanhSachLv1.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSachLv1.Columns.Add(DanhSachHopDongTemplate.Total, Convert.ToInt32(lvDanhSachLv1.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSachLv1.Columns.Add(DanhSachHopDongTemplate.Status, Convert.ToInt32(lvDanhSachLv1.Width * 0.1), HorizontalAlignment.Center);
        }

        private void InitTemplateQT()
        {
            lvDanhSachLv1.View = System.Windows.Forms.View.Details;
            lvDanhSachLv1.Columns.Add(DanhSachQuyTrinhTemplate.Id, Convert.ToInt32(lvDanhSachLv1.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSachLv1.Columns.Add(DanhSachQuyTrinhTemplate.Name, Convert.ToInt32(lvDanhSachLv1.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSachLv1.Columns.Add(DanhSachQuyTrinhTemplate.Type, Convert.ToInt32(lvDanhSachLv1.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSachLv1.Columns.Add(DanhSachQuyTrinhTemplate.StartDate, Convert.ToInt32(lvDanhSachLv1.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSachLv1.Columns.Add(DanhSachQuyTrinhTemplate.EndDate, Convert.ToInt32(lvDanhSachLv1.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSachLv1.Columns.Add(DanhSachQuyTrinhTemplate.Status, Convert.ToInt32(lvDanhSachLv1.Width * 0.1), HorizontalAlignment.Center);
        }

        public void ViewDetail()
        {
            if (lvDanhSachLv1.SelectedItems.Count < 1) {
                MessageBox.Show(Define.PLEASE_SELECT);
                return;
            }
            if (_viewType.Equals(ViewMode.HopDong)) {
                var chiTietHD = new XemChiTietHopDong((int)lvDanhSachLv1.SelectedItems[0].Tag);
                chiTietHD.ShowDialog();
            }
            else {
                var chiTietQT = new XemChiTietQuyTrinh((int)lvDanhSachLv1.SelectedItems[0].Tag);
                chiTietQT.ShowDialog();
            }
        }

        public void Updatee()
        {
            if (lvDanhSachLv1.SelectedItems.Count < 1) {
                MessageBox.Show(Define.PLEASE_SELECT);
                return;
            }

            if (_viewType.Equals(ViewMode.HopDong)) {
                var updateHd = new TaoHoacCapNhatHopDong((int)lvDanhSachLv1.SelectedItems[0].Tag);
                updateHd.ShowDialog();
                //updateHd.ShowDialog();
                if (updateHd.HasReloadList) {
                    InitDsHD(true);
                }
            }
            else if (_viewType.Equals(ViewMode.QuyTrinh)) {
                var updateQT = new TaoHoacCapNhatQuyTrinh((int)lvDanhSachLv1.SelectedItems[0].Tag);
                updateQT.ShowDialog();
                if (updateQT.HasReloadList) {
                    InitDsQT(true);
                }
            }
        }

        public void Create()
        {
            if (lvDuAn.SelectedItems.Count < 1) {
                MessageBox.Show(Define.PLEASE_SELECT_PROJECT);
                return;
            }

            if (_viewType.Equals(ViewMode.HopDong)) {
                var createHd = new TaoHoacCapNhatHopDong((int)_currentIdDASelected, true);

                createHd.ShowDialog();
                if (createHd.HasReloadList) {
                    InitDsHD(true);
                }
            }
            else if (_viewType.Equals(ViewMode.QuyTrinh)) {
                var createdQT = new TaoHoacCapNhatQuyTrinh((int)_currentIdDASelected, true);
                createdQT.ShowDialog();
                if (createdQT.HasReloadList) {
                    InitDsQT(true);
                }
            }
        }

        public void Delete()
        {
            if (lvDanhSachLv1.SelectedItems.Count < 1) {
                MessageBox.Show(Define.PLEASE_SELECT);
                return;
            }
            if (_viewType.Equals(ViewMode.HopDong)) {
                var idHdDelete = (int)lvDanhSachLv1.SelectedItems[0].Tag;
                var hd = _repository.HopDong.FindByCondition(x => x.Ma_HD == idHdDelete).FirstOrDefault();

                if (hd != null && Define.ConfirmDelete()) {
                    _repository.HopDong.Delete(hd);
                    _repository.SaveChange();
                    InitDsHD();
                }
            }
        }

        private void lvDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDuAn.SelectedItems.Count < 1) {
                return;
            }
            _currentIdDASelected = (int)lvDuAn.SelectedItems[0].Tag;
            if (_viewType.Equals(ViewMode.HopDong)) {
                InitDsHD();
            }
            else if (_viewType.Equals(ViewMode.QuyTrinh)) {
                InitDsQT();
            }
        }

        private void lvDanhSachLv1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Define.BrushHeaderLv, e.Bounds);
            e.DrawText();
        }

        private void lvDuAn_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Define.BrushHeaderLv, e.Bounds);
            e.DrawText();
        }

        private void lvDuAn_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvDanhSachLv1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
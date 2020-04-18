﻿using QLDA.View.DanhMuc.KhachHang;
using QLDA.View.DanhMuc.NhanVien;
using QLDA.View.QuanLyDuAn.DuAn;
using QLDA.View.Template;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.Common
{
    public partial class DanhSachLv0 : UserControl
    {
        private Lv0 _lvTypeSelected;

        public DanhSachLv0()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public DanhSachLv0(Lv0 lvType)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _lvTypeSelected = lvType;
            if (lvType.Equals(Lv0.KhachHang)) {
                InitKhachHang();
            }
            else if (lvType.Equals(Lv0.NhanVien)) {
                InitNhanVien();
            }
            else if (lvType.Equals(Lv0.DuAn)) {
                InitDuAn();
            }
        }

        private void InitKhachHang()
        {
            labelDanhSach.Text = Define.DANH_SACH_KHACH_HANG_HEADER;
            lvDanhSach.View = System.Windows.Forms.View.Details;
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.Id, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.Name, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.Address, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.PhoneNumber, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.MST, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.STK, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.BankName, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);

            InitDataListViewKhachHang();
            //int i = 1;
        }

        private void InitNhanVien()
        {
            labelDanhSach.Text = Define.DANH_SACH_NHAN_VIEN_HEADER;
            btnXemChiTiet.Visible = false;
            lvDanhSach.View = System.Windows.Forms.View.Details;
            lvDanhSach.Columns.Add(DanhSachNhanVienTemplate.Id, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachNhanVienTemplate.Name, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachNhanVienTemplate.Address, Convert.ToInt32(lvDanhSach.Width * 0.3), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachNhanVienTemplate.PhoneNumber, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachNhanVienTemplate.Email, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            InitDataListViewNhanVien();
        }

        private void InitDuAn()
        {
            labelDanhSach.Text = Define.DANH_SACH_DU_AN_HEADER;
            lvDanhSach.View = System.Windows.Forms.View.Details;
            lvDanhSach.Columns.Add(DanhSachDuAnTemplate.Id, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachDuAnTemplate.Name, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachDuAnTemplate.Group, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachDuAnTemplate.Location, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachDuAnTemplate.StartDate, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachDuAnTemplate.EndDate, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachDuAnTemplate.Owner, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachDuAnTemplate.Status, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            InitDataListViewDuAn();
        }

        public void InitDataListViewKhachHang()
        {
            var items = MainForm.RepositoryWrapper.KhachHang.FindAll().ToList();
            foreach (var item in items) {
                string[] itemValues = new string[] { Define.PREFIX_KHACH_HANG + item.Ma_KH, item.Ten, item.Dia_Chi, item.SDT, item.MST, item.STK, item.Ten_NH };

                if (itemValues.Length > 0) {
                    lvDanhSach.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_KH });
                }
            }
        }

        public void InitDataListViewNhanVien()
        {
            var items = MainForm.RepositoryWrapper.NhanVien.FindAll().ToList();
            foreach (var item in items) {
                string[] itemValues = new string[] { Define.PREFIX_NHAN_VIEN + item.Ma_NV, item.Ten, item.Dia_Chi, item.SDT, item.Email };

                if (itemValues.Length > 0) {
                    lvDanhSach.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_NV });
                }
            }
        }

        public void InitDataListViewDuAn()
        {
            var items = MainForm.RepositoryWrapper.RepositoryContext.DuAns.Include("KhachHang").ToList();
            foreach (var item in items) {
                string[] itemValues = new string[] {
                    Define.PREFIX_DU_AN + item.Ma_DA,
                    item.Ten, item.Nhom,
                    item.Dia_Diem,
                    item.Thoi_Gian_BD.ToLongDateString(),
                    item.Thoi_Gian_KT.ToLongDateString(),
                    item.KhachHang.Ten,
                    item.Trang_Thai
                };

                if (itemValues.Length > 0) {
                    lvDanhSach.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_DA });
                }
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count < 1) {
                MessageBox.Show(Define.PLEASE_SELECT);
                return;
            }
            int idViewDetial = (int)lvDanhSach.SelectedItems[0].Tag;
            if (_lvTypeSelected.Equals(Lv0.KhachHang)) {
                var viewDetailKh = new XemChiTietKH(idViewDetial);
                viewDetailKh.ShowDialog();
            }
            else if (_lvTypeSelected.Equals(Lv0.DuAn)) {
                var viewDetailDuAn = new XemChiTietDuAn(idViewDetial);
                viewDetailDuAn.ShowDialog();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (_lvTypeSelected.Equals(Lv0.KhachHang)) {
                var addKh = new TaoHoacCapNhatKH();
                addKh.ShowDialog();
                if (addKh.HasReloadList) {
                    lvDanhSach.Items.Clear();
                    InitDataListViewKhachHang();
                }
            }
            else if (_lvTypeSelected.Equals(Lv0.NhanVien)) {
                var addNv = new TaoHoacCapNhatNV();
                addNv.ShowDialog();
                if (addNv.HasReloadList) {
                    lvDanhSach.Items.Clear();

                    InitDataListViewNhanVien();
                }
            }
            else if (_lvTypeSelected.Equals(Lv0.DuAn)) {
                var addDA = new TaoHoacCapNhatDuAn();
                addDA.ShowDialog();
                if (addDA.HasReloadList) {
                    lvDanhSach.Items.Clear();
                    InitDataListViewDuAn();
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count < 1) {
                MessageBox.Show(Define.PLEASE_SELECT);
                return;
            }
            int idUpdate = (int)lvDanhSach.SelectedItems[0].Tag;

            if (_lvTypeSelected.Equals(Lv0.KhachHang)) {
                var addKh = new TaoHoacCapNhatKH(idUpdate);
                addKh.ShowDialog();
                if (addKh.HasReloadList) {
                    lvDanhSach.Items.Clear();
                    InitDataListViewKhachHang();
                }
            }
            else if (_lvTypeSelected.Equals(Lv0.NhanVien)) {
                var addNv = new TaoHoacCapNhatNV(idUpdate);
                addNv.ShowDialog();
                if (addNv.HasReloadList) {
                    lvDanhSach.Items.Clear();

                    InitDataListViewNhanVien();
                }
            }
            else if (_lvTypeSelected.Equals(Lv0.DuAn)) {
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count < 1) {
                MessageBox.Show(Define.PLEASE_SELECT);
                return;
            }
            int idUpdate = (int)lvDanhSach.SelectedItems[0].Tag;

            if (_lvTypeSelected.Equals(Lv0.KhachHang)) {
                var record = MainForm.RepositoryWrapper.KhachHang.FindByCondition(x => x.Ma_KH == idUpdate).FirstOrDefault();
                if (record != null && ConfirmDelete()) {
                    MainForm.RepositoryWrapper.KhachHang.Delete(record);
                    MainForm.RepositoryWrapper.SaveChange();
                    lvDanhSach.Items.Clear();
                    InitDataListViewKhachHang();
                }
            }
            else if (_lvTypeSelected.Equals(Lv0.NhanVien)) {
                var record = MainForm.RepositoryWrapper.NhanVien.FindByCondition(x => x.Ma_NV == idUpdate).FirstOrDefault();
                if (record != null && ConfirmDelete()) {
                    MainForm.RepositoryWrapper.NhanVien.Delete(record);
                    MainForm.RepositoryWrapper.SaveChange();
                    lvDanhSach.Items.Clear();
                    InitDataListViewNhanVien();
                }
            }
            else if (_lvTypeSelected.Equals(Lv0.DuAn)) {
                var record = MainForm.RepositoryWrapper.DuAn.FindByCondition(x => x.Ma_DA == idUpdate).FirstOrDefault();
                if (record != null && ConfirmDelete()) {
                    MainForm.RepositoryWrapper.DuAn.Delete(record);
                    MainForm.RepositoryWrapper.SaveChange();
                    lvDanhSach.Items.Clear();
                    InitDataListViewDuAn();
                }
            }
        }

        private bool ConfirmDelete()
        {
            var btn = MessageBox.Show(Define.CONFIRM_DELETE, Define.TITLE_CONFIRM, MessageBoxButtons.YesNo);
            return btn.Equals(DialogResult.Yes);
        }
    }
}
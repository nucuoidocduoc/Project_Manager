using QLDA.Repository;
using QLDA.View.DanhMuc.KhachHang;
using QLDA.View.DanhMuc.NhanVien;
using QLDA.View.DanhMuc.NhomDA;
using QLDA.View.DanhMuc.TienTe;
using QLDA.View.QuanLyDuAn.DuAn;
using QLDA.View.TaiKhoan;
using QLDA.View.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.Common
{
    public partial class DanhSachLv0 : UserControl
    {
        private ViewMode _lvTypeSelected;
        private RepositoryWrapper _repository;
        private MainForm _mainForm;

        public DanhSachLv0()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _repository = RepositoryWrapper.Create();
        }

        public DanhSachLv0(MainForm mainForm)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _repository = RepositoryWrapper.Create();
            _mainForm = mainForm;
        }

        public DanhSachLv0(ViewMode lvType, MainForm mainForm = null)
        {
            InitializeComponent();
            _mainForm = mainForm;
            _repository = RepositoryWrapper.Create();
            this.Dock = DockStyle.Fill;
            _lvTypeSelected = lvType;
            if (lvType.Equals(ViewMode.KhachHang)) {
                InitKhachHang();
            }
            else if (lvType.Equals(ViewMode.NhanVien)) {
                InitNhanVien();
            }
            else if (lvType.Equals(ViewMode.DuAn)) {
                InitDuAn();
            }
            else if (lvType.Equals(ViewMode.NhomDA)) {
                InitNhomDA();
            }
            else if (lvType.Equals(ViewMode.TienTe)) {
                InitTienTe();
            }
            else if (lvType.Equals(ViewMode.TaiKhoan)) {
                InitTaiKhoan();
            }
        }

        private void InitKhachHang()
        {
            labelDanhSach.Text = Define.DANH_SACH_KHACH_HANG_HEADER;
            lvDanhSach.View = System.Windows.Forms.View.Details;
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.Id, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.Name, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.Address, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.PhoneNumber, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.MST, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.STK, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.BankName, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);

            InitDataListViewKhachHang();
            labelDanhSach.Text = "Danh sách khách hàng";
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
            labelDanhSach.Text = "Danh sách nhân viên";
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
            labelDanhSach.Text = "Danh sách dự án";
        }

        private void InitNhomDA()
        {
            labelDanhSach.Text = Define.DANH_SACH_NHOM_DA_HEADER;
            btnXemChiTiet.Visible = false;
            lvDanhSach.View = System.Windows.Forms.View.Details;
            lvDanhSach.Columns.Add(DanhSachDuAnTemplate.Id, Convert.ToInt32(lvDanhSach.Width * 0.3), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachDuAnTemplate.Name, Convert.ToInt32(lvDanhSach.Width * 0.3), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachNhomDATemplate.Description, Convert.ToInt32(lvDanhSach.Width * 0.4), HorizontalAlignment.Center);
            InitDataListViewNhomDA();
            labelDanhSach.Text = "Danh sách nhóm dự án";
        }

        private void InitTienTe()
        {
            labelDanhSach.Text = Define.DANH_SACH_TIEN_TE;
            btnXemChiTiet.Visible = false;
            lvDanhSach.View = System.Windows.Forms.View.Details;
            lvDanhSach.Columns.Add(DanhSachDuAnTemplate.Id, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachDuAnTemplate.Name, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachTienTeTemplate.Rate, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachNhomDATemplate.Description, Convert.ToInt32(lvDanhSach.Width * 0.4), HorizontalAlignment.Center);
            InitDataListViewTienTe();
            labelDanhSach.Text = "Danh sách tiền tệ";
        }

        private void InitTaiKhoan()
        {
            labelDanhSach.Text = Define.DANH_SACH_TAI_KHOAN;
            btnCapNhat.Enabled = false;
            btnXemChiTiet.Visible = false;
            lvDanhSach.View = System.Windows.Forms.View.Details;
            lvDanhSach.Columns.Add(DanhSachTaiKhoanTemplate.Id, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachTaiKhoanTemplate.Name, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachTaiKhoanTemplate.MK, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachTaiKhoanTemplate.Email, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachTaiKhoanTemplate.Role, Convert.ToInt32(lvDanhSach.Width * 0.3), HorizontalAlignment.Center);
            InitDataListViewTaiKhoan();
            labelDanhSach.Text = "Danh sách tài khoản";
        }

        public void InitDataListViewKhachHang(bool isReNewRepository = false)
        {
            var items = RepositoryWrapper.Create().KhachHang.FindAll().ToList();
            foreach (var item in items) {
                string[] itemValues = new string[] { Define.PREFIX_KHACH_HANG + item.Ma_KH, item.Ten, item.Dia_Chi, item.SDT, item.MST, item.STK, item.Ten_NH };

                if (itemValues.Length > 0) {
                    lvDanhSach.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_KH });
                }
            }
        }

        public void InitDataListViewNhanVien(bool isReNewRepository = false)
        {
            if (isReNewRepository) {
                _repository = RepositoryWrapper.Create();
            }
            var items = _repository.NhanVien.FindAll().ToList();
            foreach (var item in items) {
                string[] itemValues = new string[] { Define.PREFIX_NHAN_VIEN + item.Ma_NV, item.Ten, item.Dia_Chi, item.SDT, item.Email };

                if (itemValues.Length > 0) {
                    lvDanhSach.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_NV });
                }
            }
        }

        public void InitDataListViewDuAn(bool isReNewRepository = false)
        {
            if (isReNewRepository) {
                _repository = RepositoryWrapper.Create();
            }

            var items = _repository.RepositoryContext.DuAns.Include("KhachHang").ToList();

            foreach (var item in items) {
                //string nhom = string.Empty;
                //if (item.Ma_Nhom != null) {
                //    var nhomDA = _repository.NhomDA.FindByCondition(x => x.Ma_Nhom == item.Ma_Nhom).FirstOrDefault();
                //    if (nhomDA != null) {
                //        nhom = nhomDA.Ten;
                //    }
                //}
                _repository.RepositoryContext.Entry(item).Reference(x => x.Nhom_DA).Load();
                string[] itemValues = new string[] {
                    Define.PREFIX_DU_AN + item.Ma_DA,
                    item.Ten, (item.Nhom_DA==null)?string.Empty:item.Nhom_DA.Ten,
                    item.Dia_Diem,
                    item.Thoi_Gian_BD.ToShortDateString(),
                    item.Thoi_Gian_KT.ToShortDateString(),
                    item.KhachHang.Ten,
                    item.Trang_Thai
                };

                if (itemValues.Length > 0) {
                    lvDanhSach.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_DA });
                }
            }
        }

        public void InitDataListViewNhomDA(bool isReNewRepository = false)
        {
            if (isReNewRepository) {
                _repository = RepositoryWrapper.Create();
            }

            var items = _repository.NhomDA.FindAll().ToList();

            foreach (var item in items) {
                string[] itemValues = new string[] {
                    Define.PREFIX_NHOM_DA + item.Ma_Nhom,
                    item.Ten,
                    item.Dien_Giai
                };

                if (itemValues.Length > 0) {
                    lvDanhSach.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_Nhom });
                }
            }
        }

        public void InitDataListViewTienTe(bool isReNewRepository = false)
        {
            if (isReNewRepository) {
                _repository = RepositoryWrapper.Create();
            }

            var items = _repository.TienTe.FindAll().ToList();

            foreach (var item in items) {
                string[] itemValues = new string[] {
                    Define.PREFIX_TIEN_TE + item.Ma_Tien_Te,
                    item.Ten,
                    item.Ti_gia.ToString(),
                    item.Dien_Giai
                };

                if (itemValues.Length > 0) {
                    lvDanhSach.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_Tien_Te });
                }
            }
        }

        public void InitDataListViewTaiKhoan(bool isReNewRepository = false)
        {
            if (isReNewRepository) {
                _repository = RepositoryWrapper.Create();
            }
            var accountLogin = _repository.TaiKhoan.FindByCondition(x => x.Ma_TK == _mainForm.IdAccount).FirstOrDefault();
            List<Model.TaiKhoan> items = new List<Model.TaiKhoan>();
            if (accountLogin.Role.Equals(Define.Admin)) {
                items = _repository.TaiKhoan.FindAll().ToList();
            }
            else {
                items.Add(accountLogin);
                btnThemMoi.Enabled = false;
                btnXoa.Enabled = false;
            }
            //var items = _repository.TaiKhoan.FindAll().ToList();

            foreach (var item in items) {
                string[] itemValues = new string[] {
                    Define.PREFIX_TAI_KHOAN + item.Ma_TK,
                    item.Ten,
                    item.MK,
                    item.Email,
                    item.Role
                };

                if (itemValues.Length > 0) {
                    lvDanhSach.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_TK });
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
            if (_lvTypeSelected.Equals(ViewMode.KhachHang)) {
                var viewDetailKh = new XemChiTietKH(idViewDetial);
                viewDetailKh.ShowDialog();
            }
            else if (_lvTypeSelected.Equals(ViewMode.DuAn)) {
                var viewDetailDuAn = new XemChiTietDuAn(idViewDetial);
                viewDetailDuAn.ShowDialog();
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            if (_lvTypeSelected.Equals(ViewMode.KhachHang)) {
                var addKh = new TaoHoacCapNhatKH();
                addKh.ShowDialog();
                if (addKh.HasReloadList) {
                    lvDanhSach.Items.Clear();
                    InitDataListViewKhachHang(true);
                }
            }
            else if (_lvTypeSelected.Equals(ViewMode.NhanVien)) {
                var addNv = new TaoHoacCapNhatNV();
                addNv.ShowDialog();
                if (addNv.HasReloadList) {
                    lvDanhSach.Items.Clear();

                    InitDataListViewNhanVien(true);
                }
            }
            else if (_lvTypeSelected.Equals(ViewMode.DuAn)) {
                var addDA = new TaoHoacCapNhatDuAn();
                addDA.ShowDialog();
                if (addDA.HasReloadList) {
                    lvDanhSach.Items.Clear();
                    InitDataListViewDuAn(true);
                }
            }
            else if (_lvTypeSelected.Equals(ViewMode.NhomDA)) {
                var addNhomDA = new TaoHoacCapNhatNhomDA();
                addNhomDA.ShowDialog();
                if (addNhomDA.HasReloadList) {
                    lvDanhSach.Items.Clear();
                    InitDataListViewNhomDA(true);
                }
            }
            else if (_lvTypeSelected.Equals(ViewMode.TienTe)) {
                var addTienTe = new TaoHoacCapNhatTienTe();
                addTienTe.ShowDialog();
                if (addTienTe.HasReloadList) {
                    lvDanhSach.Items.Clear();
                    InitDataListViewTienTe(true);
                }
            }
            else if (_lvTypeSelected.Equals(ViewMode.TaiKhoan)) {
                var addTaiKhoan = new RegisterAccount();
                addTaiKhoan.ShowDialog();
                if (addTaiKhoan.HasReloadList) {
                    lvDanhSach.Items.Clear();
                    InitDataListViewTaiKhoan(true);
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

            if (_lvTypeSelected.Equals(ViewMode.KhachHang)) {
                var addKh = new TaoHoacCapNhatKH(idUpdate);
                addKh.ShowDialog();
                if (addKh.HasReloadList) {
                    lvDanhSach.Items.Clear();
                    InitDataListViewKhachHang(true);
                }
            }
            else if (_lvTypeSelected.Equals(ViewMode.NhanVien)) {
                var addNv = new TaoHoacCapNhatNV(idUpdate);
                addNv.ShowDialog();
                if (addNv.HasReloadList) {
                    lvDanhSach.Items.Clear();

                    InitDataListViewNhanVien(true);
                }
            }
            else if (_lvTypeSelected.Equals(ViewMode.DuAn)) {
                var addDA = new TaoHoacCapNhatDuAn(idUpdate);
                addDA.ShowDialog();
                if (addDA.HasReloadList) {
                    lvDanhSach.Items.Clear();
                    InitDataListViewDuAn(true);
                }
            }
            else if (_lvTypeSelected.Equals(ViewMode.NhomDA)) {
                var addNhomDA = new TaoHoacCapNhatNhomDA(idUpdate);
                addNhomDA.ShowDialog();
                if (addNhomDA.HasReloadList) {
                    lvDanhSach.Items.Clear();
                    InitDataListViewNhomDA(true);
                }
            }
            else if (_lvTypeSelected.Equals(ViewMode.TienTe)) {
                var addTienTe = new TaoHoacCapNhatTienTe(idUpdate);
                addTienTe.ShowDialog();
                if (addTienTe.HasReloadList) {
                    lvDanhSach.Items.Clear();
                    InitDataListViewTienTe(true);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvDanhSach.SelectedItems.Count < 1) {
                MessageBox.Show(Define.PLEASE_SELECT);
                return;
            }
            int idUpdate = (int)lvDanhSach.SelectedItems[0].Tag;

            if (_lvTypeSelected.Equals(ViewMode.KhachHang)) {
                var record = _repository.KhachHang.FindByCondition(x => x.Ma_KH == idUpdate).FirstOrDefault();
                if (record != null && Define.ConfirmDelete()) {
                    _repository.KhachHang.Delete(record);
                    _repository.SaveChange();

                    lvDanhSach.Items.Clear();
                    InitDataListViewKhachHang(true);
                }
            }
            else if (_lvTypeSelected.Equals(ViewMode.NhanVien)) {
                var record = _repository.NhanVien.FindByCondition(x => x.Ma_NV == idUpdate).FirstOrDefault();
                if (record != null && Define.ConfirmDelete()) {
                    _repository.NhanVien.Delete(record);
                    _repository.SaveChange();
                    lvDanhSach.Items.Clear();
                    InitDataListViewNhanVien(true);
                }
            }
            else if (_lvTypeSelected.Equals(ViewMode.DuAn)) {
                var record = _repository.DuAn.FindByCondition(x => x.Ma_DA == idUpdate).FirstOrDefault();
                if (record != null && Define.ConfirmDelete()) {
                    _repository.DuAn.Delete(record);
                    _repository.SaveChange();
                    lvDanhSach.Items.Clear();
                    InitDataListViewDuAn(true);
                }
            }
            else if (_lvTypeSelected.Equals(ViewMode.NhomDA)) {
                var count = _repository.DuAn.FindByCondition(x => x.Ma_Nhom == idUpdate).Count();
                if (count > 0) {
                    MessageBox.Show("Không thể xóa vì đang có dự án sử dụng nhóm dự án này");
                    return;
                }
                var record = _repository.NhomDA.FindByCondition(x => x.Ma_Nhom == idUpdate).FirstOrDefault();
                if (record != null && Define.ConfirmDelete()) {
                    _repository.NhomDA.Delete(record);
                    _repository.SaveChange();
                    lvDanhSach.Items.Clear();
                    InitDataListViewNhomDA(true);
                }
            }
            else if (_lvTypeSelected.Equals(ViewMode.TienTe)) {
                var count = _repository.ThanhToan.FindByCondition(x => x.Ma_Tien_Te == idUpdate).Count();
                if (count > 0) {
                    MessageBox.Show("Không thể xóa vì đang có thanh toans sử dụng đơn vị tiền tệ này");
                    return;
                }
                var record = _repository.TienTe.FindByCondition(x => x.Ma_Tien_Te == idUpdate).FirstOrDefault();
                if (record != null && Define.ConfirmDelete()) {
                    _repository.TienTe.Delete(record);
                    _repository.SaveChange();
                    lvDanhSach.Items.Clear();
                    InitDataListViewTienTe(true);
                }
            }
        }

        private void lvDanhSach_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Define.BrushHeaderLv, e.Bounds);
            e.DrawText();
        }

        private void lvDanhSach_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
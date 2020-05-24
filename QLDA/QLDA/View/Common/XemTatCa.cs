using QLDA.Repository;
using QLDA.View.QuanLyCongViec.CongViec;
using QLDA.View.QuanLyCongViec.QuyTrinh;
using QLDA.View.QuanLyDuAn.HopDong;
using QLDA.View.QuanLyDuAn.ThanhToan;
using QLDA.View.Template;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.Common
{
    public partial class XemTatCa : UserControl
    {
        private ViewMode _viewMode;
        private RepositoryWrapper _repository;

        public XemTatCa()
        {
            InitializeComponent();
        }

        public XemTatCa(ViewMode viewMode)
        {
            InitializeComponent();
            _viewMode = viewMode;
            _repository = RepositoryWrapper.Create();
            switch (viewMode) {
                case ViewMode.HopDong:
                    InitTemplateHopDong();
                    InitHopDong();
                    break;

                case ViewMode.QuyTrinh:
                    InitTemplateQuyTrinh();
                    InitQuyTrinh();
                    break;

                case ViewMode.ThanhToan:
                    InitTemplateThanhToan();
                    InitThanhToan();
                    break;

                case ViewMode.CongViec:
                    InitTemplateCongViec();
                    InitCongViec();
                    break;
            }
        }

        private void InitHopDong(bool isReloadRepository = false)
        {
            if (isReloadRepository) {
                _repository = RepositoryWrapper.Create();
            }
            lvXemTatCa.Items.Clear();
            var hds = _repository.HopDong.FindAll().OrderBy(x => x.Ma_DA).ToList();

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
                lvXemTatCa.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_HD });
            }
        }

        private void InitTemplateHopDong()
        {
            lvXemTatCa.Columns.Add(DanhSachHopDongTemplate.Id, Convert.ToInt32(lvXemTatCa.Width * 0.1), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachHopDongTemplate.Name, Convert.ToInt32(lvXemTatCa.Width * 0.2), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachHopDongTemplate.StartDate, Convert.ToInt32(lvXemTatCa.Width * 0.2), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachHopDongTemplate.EndDate, Convert.ToInt32(lvXemTatCa.Width * 0.2), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachHopDongTemplate.Total, Convert.ToInt32(lvXemTatCa.Width * 0.2), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachHopDongTemplate.Status, Convert.ToInt32(lvXemTatCa.Width * 0.1), HorizontalAlignment.Center);
        }

        private void InitQuyTrinh(bool isReloadRepository = false)
        {
            if (isReloadRepository) {
                _repository = RepositoryWrapper.Create();
            }
            lvXemTatCa.Items.Clear();
            var qts = _repository.QuyTrinh.FindAll().OrderBy(x => x.Ma_DA).ToList();
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
                lvXemTatCa.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_QT });
            }
        }

        private void InitTemplateQuyTrinh()
        {
            lvXemTatCa.Columns.Add(DanhSachQuyTrinhTemplate.Id, Convert.ToInt32(lvXemTatCa.Width * 0.1), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachQuyTrinhTemplate.Name, Convert.ToInt32(lvXemTatCa.Width * 0.2), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachQuyTrinhTemplate.Type, Convert.ToInt32(lvXemTatCa.Width * 0.2), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachQuyTrinhTemplate.StartDate, Convert.ToInt32(lvXemTatCa.Width * 0.2), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachQuyTrinhTemplate.EndDate, Convert.ToInt32(lvXemTatCa.Width * 0.2), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachQuyTrinhTemplate.Status, Convert.ToInt32(lvXemTatCa.Width * 0.1), HorizontalAlignment.Center);
        }

        private void InitThanhToan(bool isReloadRepository = false)
        {
            if (isReloadRepository) {
                _repository = RepositoryWrapper.Create();
            }
            lvXemTatCa.Items.Clear();
            var thanhToans = _repository.ThanhToan.FindAll().OrderBy(x => x.Ma_HD).ToList();

            foreach (var tt in thanhToans) {
                //string loaiTien = string.Empty;
                //if (tt.Ma_Tien_Te != null) {
                //    var maTien = _repository.TienTe.FindByCondition(x => x.Ma_Tien_Te == tt.Ma_Tien_Te).FirstOrDefault();
                //    if (maTien != null) {
                //        loaiTien = maTien.Ten;
                //    }
                //}
                _repository.RepositoryContext.Entry(tt).Reference(x => x.Loai_Tien).Load();
                string[] values = new string[] {
                    Define.PREFIX_THANH_TOAN+tt.Ma_TT,
                    tt.Ten,
                    tt.So_Tien,
                    (tt.Loai_Tien==null)?string.Empty:tt.Loai_Tien.Ten,
                    tt.Hinh_Thuc,
                    tt.Thoi_Gian_TT.ToShortDateString()
                };
                lvXemTatCa.Items.Add(new ListViewItem(values) { Tag = tt.Ma_TT });
            }
        }

        private void InitTemplateThanhToan()
        {
            lvXemTatCa.Columns.Add(DanhSachThanhToanTemplate.Id, Convert.ToInt32(lvXemTatCa.Width * 0.1), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachThanhToanTemplate.Name, Convert.ToInt32(lvXemTatCa.Width * 0.3), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachThanhToanTemplate.Much, Convert.ToInt32(lvXemTatCa.Width * 0.1), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachThanhToanTemplate.Type, Convert.ToInt32(lvXemTatCa.Width * 0.1), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachThanhToanTemplate.Mode, Convert.ToInt32(lvXemTatCa.Width * 0.2), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachThanhToanTemplate.Date, Convert.ToInt32(lvXemTatCa.Width * 0.2), HorizontalAlignment.Center);
        }

        private void InitCongViec(bool isReloadRepository = false)
        {
            if (isReloadRepository) {
                _repository = RepositoryWrapper.Create();
            }
            lvXemTatCa.Items.Clear();
            var cvs = _repository.CongViec.FindAll().OrderBy(x => x.Ma_QT).ToList();
            foreach (var cv in cvs) {
                _repository.RepositoryContext.Entry(cv).Reference(x => x.NhanVien).Load();
                string[] values = new string[] {
                    Define.PREFIX_THANH_TOAN+cv.Ma_CV,
                    cv.Ten,
                    cv.Muc_Do_UT.ToString(),
                     cv.NhanVien!=null?cv.NhanVien.Ten:string.Empty,
                    cv.Thoi_Gian_HH.ToShortDateString(),
                    cv.Thoi_Gian_Giao.ToShortDateString(),
                    cv.Trang_Thai
                    };
                lvXemTatCa.Items.Add(new ListViewItem(values) { Tag = cv.Ma_CV });
            }
        }

        private void InitTemplateCongViec()
        {
            lvXemTatCa.Columns.Add(DanhSachCongViecTemplate.Id, Convert.ToInt32(lvXemTatCa.Width * 0.2), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachCongViecTemplate.Name, Convert.ToInt32(lvXemTatCa.Width * 0.2), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachCongViecTemplate.Prior, Convert.ToInt32(lvXemTatCa.Width * 0.1), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachCongViecTemplate.Member, Convert.ToInt32(lvXemTatCa.Width * 0.2), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachCongViecTemplate.EndDate, Convert.ToInt32(lvXemTatCa.Width * 0.1), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachCongViecTemplate.RealEndDate, Convert.ToInt32(lvXemTatCa.Width * 0.1), HorizontalAlignment.Center);
            lvXemTatCa.Columns.Add(DanhSachCongViecTemplate.Status, Convert.ToInt32(lvXemTatCa.Width * 0.1), HorizontalAlignment.Center);
        }

        public void Create()
        {
            switch (_viewMode) {
                case ViewMode.HopDong:
                    var addHd = new TaoHoacCapNhatHopDong(-1, true);
                    addHd.ShowDialog();
                    if (addHd.HasReloadList) {
                        InitHopDong(true);
                    }
                    break;

                case ViewMode.ThanhToan:
                    var addThanhToan = new TaoHoacCapNhatTT(-1, true);
                    addThanhToan.ShowDialog();
                    if (addThanhToan.HasReloadList) {
                        InitThanhToan(true);
                    }
                    break;

                case ViewMode.QuyTrinh:

                    var addQuyTrinh = new TaoHoacCapNhatQuyTrinh(-1, true);
                    addQuyTrinh.ShowDialog();
                    if (addQuyTrinh.HasReloadList) {
                        InitQuyTrinh(true);
                    }
                    break;

                case ViewMode.CongViec:
                    var addCv = new TaoHoacCapNhatCV(-1, true);
                    addCv.ShowDialog();
                    if (addCv.HasReloadList) {
                        InitCongViec(true);
                    }
                    break;
            }
        }

        public void Updatee()
        {
            if (lvXemTatCa.SelectedItems.Count < 1) {
                MessageBox.Show(Define.PLEASE_SELECT);
                return;
            }
            int idUpdate = (int)lvXemTatCa.SelectedItems[0].Tag;
            switch (_viewMode) {
                case ViewMode.HopDong:
                    var addHd = new TaoHoacCapNhatHopDong(idUpdate);
                    addHd.ShowDialog();
                    if (addHd.HasReloadList) {
                        InitHopDong(true);
                    }
                    break;

                case ViewMode.ThanhToan:
                    var addThanhToan = new TaoHoacCapNhatTT(idUpdate);
                    addThanhToan.ShowDialog();
                    if (addThanhToan.HasReloadList) {
                        InitThanhToan(true);
                    }
                    break;

                case ViewMode.QuyTrinh:
                    var addQuyTrinh = new TaoHoacCapNhatQuyTrinh(idUpdate);
                    addQuyTrinh.ShowDialog();
                    if (addQuyTrinh.HasReloadList) {
                        InitQuyTrinh(true);
                    }
                    break;

                case ViewMode.CongViec:
                    var addCongViec = new TaoHoacCapNhatCV(idUpdate);
                    addCongViec.ShowDialog();
                    if (addCongViec.HasReloadList) {
                        InitCongViec(true);
                    }
                    break;
            }
        }

        public void Delete()
        {
            if (lvXemTatCa.SelectedItems.Count < 1) {
                MessageBox.Show(Define.PLEASE_SELECT);
                return;
            }
            int idDelete = (int)lvXemTatCa.SelectedItems[0].Tag;

            switch (_viewMode) {
                case ViewMode.HopDong:
                    var itemh = _repository.HopDong.FindByCondition(x => x.Ma_HD == idDelete).FirstOrDefault();
                    if (itemh != null && Define.ConfirmDelete()) {
                        _repository.HopDong.Delete(itemh);
                        _repository.SaveChange();
                        InitHopDong();
                    }
                    break;

                case ViewMode.ThanhToan:
                    var itemt = _repository.ThanhToan.FindByCondition(x => x.Ma_TT == idDelete).FirstOrDefault();
                    if (itemt != null && Define.ConfirmDelete()) {
                        _repository.ThanhToan.Delete(itemt);
                        _repository.SaveChange();
                        InitThanhToan();
                    }
                    break;

                case ViewMode.QuyTrinh:
                    var itemq = _repository.QuyTrinh.FindByCondition(x => x.Ma_QT == idDelete).FirstOrDefault();
                    if (itemq != null && Define.ConfirmDelete()) {
                        _repository.QuyTrinh.Delete(itemq);
                        _repository.SaveChange();
                        InitQuyTrinh();
                    }
                    break;

                case ViewMode.CongViec:
                    var itemc = _repository.CongViec.FindByCondition(x => x.Ma_CV == idDelete).FirstOrDefault();
                    if (itemc != null && Define.ConfirmDelete()) {
                        _repository.CongViec.Delete(itemc);
                        _repository.SaveChange();
                        InitCongViec();
                    }
                    break;
            }
        }

        public void ViewDetail()
        {
            if (lvXemTatCa.SelectedItems.Count < 1) {
                return;
            }
            int idViewDetail = (int)lvXemTatCa.SelectedItems[0].Tag;

            switch (_viewMode) {
                case ViewMode.HopDong:
                    var xemChiTietHD = new XemChiTietHopDong(idViewDetail);
                    xemChiTietHD.ShowDialog();
                    break;

                case ViewMode.QuyTrinh:
                    var xemChiTietQT = new XemChiTietQuyTrinh(idViewDetail);
                    xemChiTietQT.ShowDialog();
                    break;
            }
        }

        private void lvXemTatCa_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Define.BrushHeaderLv, e.Bounds);
            e.DrawText();
        }

        private void lvXemTatCa_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
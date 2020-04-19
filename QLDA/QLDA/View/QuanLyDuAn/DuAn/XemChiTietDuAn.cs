using QLDA.Repository;
using QLDA.View.Template;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.QuanLyDuAn.DuAn
{
    public partial class XemChiTietDuAn : Form
    {
        private int? _idViewDetial;
        private RepositoryWrapper _repository;

        public XemChiTietDuAn()
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
        }

        public XemChiTietDuAn(int idViewDetail)
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            _idViewDetial = idViewDetail;
            InitTemplateDs();
            InitData();
        }

        private void InitData()
        {
            var duAnView = _repository.DuAn.FindByCondition(d => d.Ma_DA == _idViewDetial).FirstOrDefault();
            if (duAnView == null) {
                return;
            }
            Text = Define.DETAIL_INFO_PROJECT + " " + Define.PREFIX_DU_AN + duAnView.Ma_DA;
            _repository.RepositoryContext.Entry(duAnView).Collection(d => d.Cac_Quy_Trinh).Load();
            _repository.RepositoryContext.Entry(duAnView).Collection(d => d.Cac_Hop_Dong).Load();
            _repository.RepositoryContext.Entry(duAnView).Reference(d => d.KhachHang).Load();
            _repository.RepositoryContext.Entry(duAnView).Reference(d => d.NhanVien).Load();
            InitInfoDA(duAnView);
            if (duAnView.Cac_Hop_Dong != null) {
                InitDSHD(duAnView.Cac_Hop_Dong);
            }
            if (duAnView.Cac_Quy_Trinh != null) {
                InitDSQT(duAnView.Cac_Quy_Trinh);
            }
        }

        private void InitTemplateDs()
        {
            lvDSHD.View = System.Windows.Forms.View.Details;
            lvDSHD.Columns.Add(DanhSachHopDongTemplate.Id, Convert.ToInt32(lvDSHD.Width * 0.1), HorizontalAlignment.Center);
            lvDSHD.Columns.Add(DanhSachHopDongTemplate.Name, Convert.ToInt32(lvDSHD.Width * 0.2), HorizontalAlignment.Center);
            lvDSHD.Columns.Add(DanhSachHopDongTemplate.StartDate, Convert.ToInt32(lvDSHD.Width * 0.2), HorizontalAlignment.Center);
            lvDSHD.Columns.Add(DanhSachHopDongTemplate.EndDate, Convert.ToInt32(lvDSHD.Width * 0.2), HorizontalAlignment.Center);
            lvDSHD.Columns.Add(DanhSachHopDongTemplate.Total, Convert.ToInt32(lvDSHD.Width * 0.2), HorizontalAlignment.Center);
            lvDSHD.Columns.Add(DanhSachHopDongTemplate.Status, Convert.ToInt32(lvDSHD.Width * 0.1), HorizontalAlignment.Center);

            lvDSQT.View = System.Windows.Forms.View.Details;
            lvDSQT.Columns.Add(DanhSachQuyTrinhTemplate.Id, Convert.ToInt32(lvDSQT.Width * 0.1), HorizontalAlignment.Center);
            lvDSQT.Columns.Add(DanhSachQuyTrinhTemplate.Name, Convert.ToInt32(lvDSQT.Width * 0.2), HorizontalAlignment.Center);
            lvDSQT.Columns.Add(DanhSachQuyTrinhTemplate.Type, Convert.ToInt32(lvDSQT.Width * 0.1), HorizontalAlignment.Center);
            lvDSQT.Columns.Add(DanhSachQuyTrinhTemplate.StartDate, Convert.ToInt32(lvDSQT.Width * 0.2), HorizontalAlignment.Center);
            lvDSQT.Columns.Add(DanhSachQuyTrinhTemplate.EndDate, Convert.ToInt32(lvDSQT.Width * 0.2), HorizontalAlignment.Center);
            lvDSQT.Columns.Add(DanhSachQuyTrinhTemplate.Status, Convert.ToInt32(lvDSQT.Width * 0.1), HorizontalAlignment.Center);
        }

        private void InitInfoDA(Model.DuAn duAn)
        {
            txtTen.Text = duAn.Ten;
            txtChuDauTu.Text = Define.PREFIX_KHACH_HANG + duAn.KhachHang.Ma_KH + " " + duAn.KhachHang.Ten;
            txtNhom.Text = duAn.Nhom;
            txtDiaDiem.Text = duAn.Dia_Diem;
            if (duAn.NhanVien != null) {
                txtGiamDoc.Text = Define.PREFIX_NHAN_VIEN + duAn.NhanVien.Ma_NV + " " + duAn.NhanVien.Ten;
            }
            dtThoiGianBD.Value = duAn.Thoi_Gian_BD;
            dtThoiGianKT.Value = duAn.Thoi_Gian_KT;
            dtThoiGianTT.Value = duAn.Thoi_Gian_KT_TT;
            txtDienGiai.Text = duAn.Dien_Giai;
        }

        private void InitDSHD(ICollection<Model.HopDong> hopDongs)
        {
            foreach (var item in hopDongs) {
                string[] itemValues = new string[] { Define.PREFIX_HOP_DONG + item.Ma_HD,
                    item.Ten,
                    item.Thoi_Diem_Ky.ToLongDateString(),
                    item.Thoi_Gian_KT.ToLongDateString(),
                    item.Tong_Gia_Tri,
                    item.Trang_Thai
                    };
                lvDSHD.Items.Add(new ListViewItem(itemValues));
            }
        }

        private void InitDSQT(ICollection<Model.QuyTrinh> quyTrinhs)
        {
            foreach (var item in quyTrinhs) {
                string[] itemValues = new string[] { Define.PREFIX_HOP_DONG + item.Ma_DA,
                    item.Ten,
                    item.Loai_QT,
                    item.Thoi_Gian_BD.ToLongDateString(),
                    item.Thoi_Gian_KT.ToLongDateString(),
                    item.Trang_Thai
                    };
                lvDSHD.Items.Add(new ListViewItem(itemValues));
            }
        }
    }
}
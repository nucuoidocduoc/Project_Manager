using QLDA.Repository;
using QLDA.View.Template;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA.View.QuanLyDuAn.HopDong
{
    public partial class XemChiTietHopDong : Form
    {
        private RepositoryWrapper _repository;
        private int _idHd;

        public XemChiTietHopDong()
        {
            InitializeComponent();
        }

        public XemChiTietHopDong(int idHd)
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            _idHd = idHd;
            InitTemplateLvTT();
            InitData();
        }

        private void InitTemplateLvTT()
        {
            lvThanhToan.View = System.Windows.Forms.View.Details;
            lvThanhToan.Columns.Add(DanhSachThanhToanTemplate.Id, Convert.ToInt32(lvThanhToan.Width * 0.1), HorizontalAlignment.Center);
            lvThanhToan.Columns.Add(DanhSachThanhToanTemplate.Name, Convert.ToInt32(lvThanhToan.Width * 0.2), HorizontalAlignment.Center);
            lvThanhToan.Columns.Add(DanhSachThanhToanTemplate.Much, Convert.ToInt32(lvThanhToan.Width * 0.1), HorizontalAlignment.Center);
            lvThanhToan.Columns.Add(DanhSachThanhToanTemplate.Type, Convert.ToInt32(lvThanhToan.Width * 0.1), HorizontalAlignment.Center);
            lvThanhToan.Columns.Add(DanhSachThanhToanTemplate.Mode, Convert.ToInt32(lvThanhToan.Width * 0.3), HorizontalAlignment.Center);
            lvThanhToan.Columns.Add(DanhSachThanhToanTemplate.Date, Convert.ToInt32(lvThanhToan.Width * 0.2), HorizontalAlignment.Center);
            //lvThanhToan.Columns.Add(DanhSachThanhToanTemplate.Status, Convert.ToInt32(lvDSHD.Width * 0.1), HorizontalAlignment.Center);
        }

        private void InitData()
        {
            var hd = _repository.HopDong.FindByCondition(x => x.Ma_HD == _idHd).FirstOrDefault();
            if (hd == null) {
                return;
            }
            _repository.RepositoryContext.Entry(hd).Collection(h => h.Cac_Thanh_Toan).Load();
            txtTen.Text = hd.Ten;
            txtDienGiai.Text = hd.Dien_Giai;
            txtTongGiaTri.Text = hd.Tong_Gia_Tri;
            txtTrangThai.Text = hd.Trang_Thai;
            dtNgayKy.Value = hd.Thoi_Diem_Ky;
            dtNgayThanhLy.Value = hd.Thoi_Gian_KT;
            if (hd.Cac_Thanh_Toan != null) {
                InitLvTT(hd.Cac_Thanh_Toan);
            }
            CalculateWorthHD();
        }

        private void InitLvTT(ICollection<Model.ThanhToan> thanhToans)
        {
            foreach (var tt in thanhToans) {
                _repository.RepositoryContext.Entry(tt).Reference(x => x.Loai_Tien).Load();
                string[] values = new string[] {
                    Define.PREFIX_THANH_TOAN+tt.Ma_TT,
                    tt.Ten,
                    tt.So_Tien,
                    (tt.Loai_Tien==null)?string.Empty:tt.Loai_Tien.Ten,
                    tt.Hinh_Thuc,
                    tt.Thoi_Gian_TT.ToShortDateString()
                };
                lvThanhToan.Items.Add(new ListViewItem(values));
            }
        }

        private void lvThanhToan_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Define.BrushHeaderLv, e.Bounds);
            e.DrawText();
        }

        private void lvThanhToan_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void CalculateWorthHD(bool isReloadRepository = false)
        {
            if (isReloadRepository) {
                _repository = RepositoryWrapper.Create();
            }
            var hd = _repository.HopDong.FindByCondition(x => x.Ma_HD == _idHd).FirstOrDefault();
            if (hd == null) {
                return;
            }
            var thanhToans = _repository.ThanhToan.FindByCondition(x => x.Ma_HD == _idHd).ToList();
            double value = 0;
            foreach (var tt in thanhToans) {
                _repository.RepositoryContext.Entry(tt).Reference(x => x.Loai_Tien).Load();
                value += Define.GetMoney(tt);
            }
            if (double.TryParse(hd.Tong_Gia_Tri, out double toTal)) {
                txtTongGiaTri.Text = toTal.ToString();
                txtDaThanhToan.Text = value.ToString();
                txtChuaThanhToan.Text = (toTal - value).ToString();
            }
        }
    }
}
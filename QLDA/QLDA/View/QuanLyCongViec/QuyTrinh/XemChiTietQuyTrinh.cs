using QLDA.Repository;
using QLDA.View.Template;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.QuanLyCongViec.QuyTrinh
{
    public partial class XemChiTietQuyTrinh : Form
    {
        private RepositoryWrapper _repository;
        private int _id;

        public XemChiTietQuyTrinh()
        {
            InitializeComponent();
        }

        public XemChiTietQuyTrinh(int id)
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            _id = id;
            Init();
        }

        private void Init()
        {
            InitTemplateCv();
            var qt = _repository.QuyTrinh.FindByCondition(x => x.Ma_QT == _id).FirstOrDefault();
            if (qt == null) {
                return;
            }
            Text = Define.PREFIX_QUI_TRINH + qt.Ma_QT;
            _repository.RepositoryContext.Entry(qt).Collection(x => x.Cac_Cong_Viec).Load();
            _repository.RepositoryContext.Entry(qt).Reference(x => x.DuAn).Load();
            _repository.RepositoryContext.Entry(qt).Reference(x => x.NhanVien).Load();
            txtTen.Text = qt.Ten;
            txtDuAn.Text = Define.PREFIX_DU_AN + qt.Ma_DA + " " + qt.DuAn.Ten;
            txtLoaiQT.Text = qt.Loai_QT;
            if (qt.NhanVien != null) {
                txtNV.Text = Define.PREFIX_NHAN_VIEN + qt.Ma_NV + " " + qt.NhanVien.Ten;
            }
            txtStatus.Text = qt.Trang_Thai;
            dtStartDate.Value = qt.Thoi_Gian_BD;
            dtEndDate.Value = qt.Thoi_Gian_KT;

            if (qt.Cac_Cong_Viec != null) {
                foreach (var cv in qt.Cac_Cong_Viec) {
                    string[] values = new string[] {
                    Define.PREFIX_THANH_TOAN+cv.Ma_CV,
                    cv.Ten,
                    cv.Muc_Do_UT.ToString(),
                    cv.Thoi_Gian_HH.ToLongDateString(),
                    cv.Thoi_Gian_Giao.ToLongDateString(),
                    cv.Trang_Thai
                    };
                    lvCv.Items.Add(new ListViewItem(values));
                }
            }
        }

        private void InitTemplateCv()
        {
            lvCv.View = System.Windows.Forms.View.Details;
            lvCv.Columns.Add(DanhSachCongViecTemplate.Id, Convert.ToInt32(lvCv.Width * 0.1), HorizontalAlignment.Center);
            lvCv.Columns.Add(DanhSachCongViecTemplate.Name, Convert.ToInt32(lvCv.Width * 0.2), HorizontalAlignment.Center);
            lvCv.Columns.Add(DanhSachCongViecTemplate.Prior, Convert.ToInt32(lvCv.Width * 0.1), HorizontalAlignment.Center);
            lvCv.Columns.Add(DanhSachCongViecTemplate.EndDate, Convert.ToInt32(lvCv.Width * 0.1), HorizontalAlignment.Center);
            lvCv.Columns.Add(DanhSachCongViecTemplate.RealEndDate, Convert.ToInt32(lvCv.Width * 0.1), HorizontalAlignment.Center);
            //lvCv.Columns.Add(DanhSachCongViecTemplate.Member, Convert.ToInt32(lvCv.Width * 0.1), HorizontalAlignment.Center);
            lvCv.Columns.Add(DanhSachCongViecTemplate.Status, Convert.ToInt32(lvCv.Width * 0.1), HorizontalAlignment.Center);
        }
    }
}
using LiveCharts;
using LiveCharts.Wpf;
using QLDA.Context;
using QLDA.Processing;
using QLDA.Repository;
using QLDA.View.TaiKhoan;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace QLDA
{
    public partial class MainForm : Form
    {
        //public static RepositoryWrapper RepositoryWrapper;
        //private ViewMode _viewSelected;
        public int IdAccount { get; set; }

        public bool IsLogOut { get; private set; }
        private DanhMucProcessing _danhMucProcess;
        private QLDAProcessing _quanLyDuAnProcess;
        private QLCVProcessing _quanLyCongViecProcessing;
        private OtherProcessing _otherProcessing;
        private RepositoryWrapper _repository;

        public MainForm()
        {
            InitializeComponent();
            VisiblePanel();
            //InitConnectDatabase();
            InitProcessing();
        }

        public MainForm(int idAccount)
        {
            InitializeComponent();
            IdAccount = idAccount;
            VisiblePanel();
            //InitConnectDatabase();
            InitProcessing();
            btnTrangChu_Click(null, null);
        }

        #region init

        private void InitProcessing()
        {
            _danhMucProcess = new DanhMucProcessing(this);
            _quanLyDuAnProcess = new QLDAProcessing(this);
            _quanLyCongViecProcessing = new QLCVProcessing(this);
            _otherProcessing = new OtherProcessing(this);
        }

        private void VisiblePanel()
        {
            panelDanhMuc.Visible = false;
            panelQLDA.Visible = false;
            panelQLCV.Visible = false;
            panelTK.Visible = false;
            panelHelp.Visible = false;
        }

        #endregion init

        #region main panel

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if (panelDanhMuc.Visible)
            {
                panelDanhMuc.Visible = false;
                return;
            }
            VisiblePanel();

            panelDanhMuc.Visible = true;

            //_danhMucProcess.Show(ViewMode.DanhMucKhachHang);
        }

        private void btnQLDA_Click(object sender, EventArgs e)
        {
            if (panelQLDA.Visible)
            {
                panelQLDA.Visible = false;
                return;
            }
            VisiblePanel();
            panelQLDA.Visible = true;
        }

        private void btnQLCV_Click(object sender, EventArgs e)
        {
            if (panelQLCV.Visible)
            {
                panelQLCV.Visible = false;
                return;
            }
            VisiblePanel();
            panelQLCV.Visible = true;
        }

        #endregion main panel

        #region danh muc

        private void btnDanhMucKH_Click(object sender, EventArgs e)
        {
            _danhMucProcess.Show(ViewMode.KhachHang);
        }

        private void btnDanhMucNV_Click(object sender, EventArgs e)
        {
            _danhMucProcess.Show(ViewMode.NhanVien);
        }

        private void btnNhomDA_Click(object sender, EventArgs e)
        {
            _danhMucProcess.Show(ViewMode.NhomDA);
        }

        private void btnTienTe_Click(object sender, EventArgs e)
        {
            _danhMucProcess.Show(ViewMode.TienTe);
        }

        #endregion danh muc

        #region quan ly du an

        private void btnDuAn_Click(object sender, EventArgs e)
        {
            _quanLyDuAnProcess.Show(ViewMode.DuAn);
        }

        private void btnHopDong_Click(object sender, EventArgs e)
        {
            _quanLyDuAnProcess.Show(ViewMode.HopDong);
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            _quanLyDuAnProcess.Show(ViewMode.ThanhToan);
        }

        #endregion quan ly du an

        #region quan ly cong viec

        private void btnQuyTrinh_Click(object sender, EventArgs e)
        {
            _quanLyCongViecProcessing.Show(ViewMode.QuyTrinh);
        }

        private void btnCongViec_Click(object sender, EventArgs e)
        {
            _quanLyCongViecProcessing.Show(ViewMode.CongViec);
        }

        #endregion quan ly cong viec

        #region other

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
            panelMainContent.Controls.Clear();
            var report = new View.BaoCao.Report();
            panelMainContent.Controls.Add(report);
            report.Dock = DockStyle.Fill;
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
        }

        #endregion other

        private void btnTaiKhoan_Click_1(object sender, EventArgs e)
        {
            if (panelTK.Visible)
            {
                panelTK.Visible = false;
                return;
            }
            VisiblePanel();

            panelTK.Visible = true;
        }

        private void btnTroGiup_Click_1(object sender, EventArgs e)
        {

        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            VisiblePanel();
            _otherProcessing.Show(ViewMode.Chart);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            IsLogOut = true;
            Close();
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            _danhMucProcess.Show(ViewMode.TaiKhoan);
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            if (panelHelp.Visible)
            {
                panelHelp.Visible = false;
                return;
            }
            VisiblePanel();

            panelHelp.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath, "Introduce.chm"));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, System.IO.Path.Combine(Application.StartupPath, "Help.chm"));
        }
    }
}
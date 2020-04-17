using QLDA.Context;
using QLDA.Model;
using QLDA.Processing;
using QLDA.Repository;
using QLDA.View.DanhMuc.KhachHang;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA
{
    public partial class MainForm : Form
    {
        public static RepositoryWrapper RepositoryWrapper;
        private ViewMode _viewSelected;

        private DanhMucProcessing _danhMucProcess;

        public MainForm()
        {
            InitializeComponent();
            VisiblePanel();
            InitConnectDatabase();
            _viewSelected = ViewMode.DanhMucKhachHang;
            InitProcessing();
        }

        private void InitProcessing()
        {
            _danhMucProcess = new DanhMucProcessing(this);
        }

        private void InitConnectDatabase()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            RepositoryContext repositoryContext = new RepositoryContext(connection, false);
            //MessageBox.Show(repositoryContext.KhachHangs.FirstOrDefault().Ten_NH);
            RepositoryWrapper = new RepositoryWrapper(repositoryContext);
        }

        private void VisiblePanel()
        {
            panelDanhMuc.Visible = false;
            panelQLDA.Visible = false;
            panelQLCV.Visible = false;
        }

        private void btnDanhMuc_Click(object sender, EventArgs e)
        {
            if (panelDanhMuc.Visible) {
                panelDanhMuc.Visible = false;
                return;
            }
            VisiblePanel();

            panelDanhMuc.Visible = true;

            _danhMucProcess.Show(ViewMode.DanhMucKhachHang);
        }

        private void btnQLDA_Click(object sender, EventArgs e)
        {
            if (panelQLDA.Visible) {
                panelQLDA.Visible = false;
                return;
            }
            VisiblePanel();
            panelQLDA.Visible = true;
        }

        private void btnQLCV_Click(object sender, EventArgs e)
        {
            if (panelQLCV.Visible) {
                panelQLCV.Visible = false;
                return;
            }
            VisiblePanel();
            panelQLCV.Visible = true;
        }

        private void btnBaoCao_Click(object sender, EventArgs e)
        {
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
        }
    }
}
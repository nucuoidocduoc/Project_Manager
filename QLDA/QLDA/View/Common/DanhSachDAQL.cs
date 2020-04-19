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
using QLDA.View.QuanLyDuAn.ThanhToan.CheDoXem;
using QLDA.View.QuanLyCongViec.CongViec.CheDoXem;

namespace QLDA.View.Common
{
    public partial class DanhSachDAQL : UserControl
    {
        private ViewMode _viewMode;
        private RepositoryWrapper _repositoryWrapper;
        public Action ViewDetail { get; set; }
        public Action Create { get; set; }
        public Action Updatee { get; set; }
        public Action Delete { get; set; }

        public DanhSachDAQL()
        {
            InitializeComponent();
        }

        public DanhSachDAQL(ViewMode viewMode)
        {
            InitializeComponent();
            _viewMode = viewMode;
            _repositoryWrapper = RepositoryWrapper.Create();
            switch (viewMode) {
                case ViewMode.HopDong:
                    InitHopDong();
                    break;

                case ViewMode.ThanhToan:
                    InitThanhToan();
                    break;

                case ViewMode.QuyTrinh:
                    InitQuyTrinh();
                    break;

                case ViewMode.CongViec:
                    InitCongViec();
                    break;
            }
        }

        private void InitHopDong()
        {
            if (rbtnXemTheoDuAn.Checked) {
                XemTheoDuAnLv1 control = new XemTheoDuAnLv1(ViewMode.HopDong);
                control.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(control);
                ViewDetail = control.ViewDetail;
                Create = control.Create;
                Updatee = control.Updatee;
                Delete = control.Delete;
            }
            else {
            }
        }

        private void InitThanhToan()
        {
            if (rbtnXemTheoDuAn.Checked) {
                Control control = new XemThanhToanTheoDuAn();
                control.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(control);
            }
            else {
            }
        }

        private void InitQuyTrinh()
        {
            if (rbtnXemTheoDuAn.Checked) {
                Control control = new XemTheoDuAnLv1(ViewMode.QuyTrinh);
                control.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(control);
            }
            else {
            }
        }

        private void InitCongViec()
        {
            if (rbtnXemTheoDuAn.Checked) {
                Control control = new XemCongViecTheoDuAn();
                control.Dock = DockStyle.Fill;
                panelContent.Controls.Clear();
                panelContent.Controls.Add(control);
            }
            else {
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            ViewDetail.Invoke();
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Create.Invoke();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Updatee.Invoke();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Delete.Invoke();
        }
    }
}
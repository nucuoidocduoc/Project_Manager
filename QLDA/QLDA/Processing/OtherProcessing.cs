using LiveCharts;
using LiveCharts.Wpf;
using QLDA.View.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA.Processing
{
    public class OtherProcessing
    {
        private MainForm _mainForm;

        public OtherProcessing(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void Show(ViewMode viewMode)
        {
            Control controlSelected = null;
            _mainForm.PanelMainContent.Controls.Clear();
            switch (viewMode) {
                case ViewMode.Chart:
                    controlSelected = new View.Charts.Chart();
                    break;

                //case ViewMode.NhanVien:
                //    controlSelected = new DanhSachLv0(ViewMode.NhanVien);
                //    break;

                //case ViewMode.NhomDA:
                //    controlSelected = new DanhSachLv0(ViewMode.NhomDA);
                //    break;

                //case ViewMode.TienTe:
                //    controlSelected = new DanhSachLv0(ViewMode.TienTe);
                //    break;

                //case ViewMode.TaiKhoan:
                //    controlSelected = new DanhSachLv0(ViewMode.TaiKhoan);
                //    break;

                default:
                    return;
            }
            _mainForm.PanelMainContent.Controls.Add(controlSelected);
            controlSelected.Dock = System.Windows.Forms.DockStyle.Fill;
            //controlSelected.InitDataListView();
        }
    }
}
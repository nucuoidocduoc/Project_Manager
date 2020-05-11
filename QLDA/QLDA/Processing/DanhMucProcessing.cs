using QLDA.View.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA.Processing
{
    public class DanhMucProcessing
    {
        private MainForm _mainForm;

        public DanhMucProcessing(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void Show(ViewMode viewMode)
        {
            DanhSachLv0 controlSelected = null;
            _mainForm.PanelMainContent.Controls.Clear();
            switch (viewMode) {
                case ViewMode.KhachHang:
                    controlSelected = new DanhSachLv0(ViewMode.KhachHang);
                    break;

                case ViewMode.NhanVien:
                    controlSelected = new DanhSachLv0(ViewMode.NhanVien);
                    break;

                case ViewMode.NhomDA:
                    controlSelected = new DanhSachLv0(ViewMode.NhomDA);
                    break;

                case ViewMode.TienTe:
                    controlSelected = new DanhSachLv0(ViewMode.TienTe);
                    break;

                case ViewMode.TaiKhoan:
                    controlSelected = new DanhSachLv0(ViewMode.TaiKhoan, _mainForm);
                    break;

                default:
                    return;
            }
            _mainForm.PanelMainContent.Controls.Add(controlSelected);
            //controlSelected.InitDataListView();
        }
    }
}
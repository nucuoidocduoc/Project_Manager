using QLDA.View.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA.Processing
{
    public class QLDAProcessing
    {
        private MainForm _mainForm;

        public QLDAProcessing(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void Show(ViewMode viewMode)
        {
            Control controlSelected = null;
            _mainForm.PanelMainContent.Controls.Clear();
            switch (viewMode) {
                case ViewMode.DuAn:
                    controlSelected = new DanhSachLv0(ViewMode.DuAn);
                    break;

                case ViewMode.HopDong:
                    controlSelected = new DanhSachDAQL(ViewMode.HopDong);
                    break;

                case ViewMode.ThanhToan:
                    controlSelected = new DanhSachDAQL(ViewMode.ThanhToan);
                    break;

                default:
                    return;
            }
            _mainForm.PanelMainContent.Controls.Add(controlSelected);
            //controlSelected.InitDataListView();
        }
    }
}
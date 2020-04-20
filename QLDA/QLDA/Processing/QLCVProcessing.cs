using QLDA.View.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA.Processing
{
    public class QLCVProcessing
    {
        private MainForm _mainForm;

        public QLCVProcessing(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void Show(ViewMode viewMode)
        {
            Control controlSelected = null;
            _mainForm.PanelMainContent.Controls.Clear();
            switch (viewMode) {
                case ViewMode.QuyTrinh:
                    controlSelected = new DanhSachDAQL(ViewMode.QuyTrinh);
                    break;

                case ViewMode.CongViec:
                    controlSelected = new DanhSachDAQL(ViewMode.CongViec);
                    break;

                default:
                    return;
            }
            _mainForm.PanelMainContent.Controls.Add(controlSelected);
            //controlSelected.InitDataListView();
        }
    }
}
using QLDA.View.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Processing
{
    public class TKProcessing
    {
        private MainForm _mainForm;

        public TKProcessing(MainForm mainForm)
        {
            _mainForm = mainForm;
        }

        public void Show(int idAccount)
        {
            DanhSachLv0 controlSelected = null;
            _mainForm.PanelMainContent.Controls.Clear();

            controlSelected = new DanhSachLv0(ViewMode.TaiKhoan);

            _mainForm.PanelMainContent.Controls.Add(controlSelected);
            //controlSelected.InitDataListView();
        }
    }
}
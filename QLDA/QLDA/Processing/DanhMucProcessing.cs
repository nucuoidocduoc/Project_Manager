﻿using QLDA.View.Common;
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
                case ViewMode.DanhMucKhachHang:
                    controlSelected = new DanhSachLv0(Lv0.KhachHang);
                    break;

                case ViewMode.DanhMucNhanVien:
                    controlSelected = new DanhSachLv0(Lv0.NhanVien);
                    break;

                default:
                    return;
            }
            _mainForm.PanelMainContent.Controls.Add(controlSelected);
            //controlSelected.InitDataListView();
        }
    }
}
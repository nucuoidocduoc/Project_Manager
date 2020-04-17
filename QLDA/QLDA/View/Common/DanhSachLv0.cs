using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDA.View.Template;
using QLDA.View.DanhMuc.KhachHang;

namespace QLDA.View.Common
{
    public partial class DanhSachLv0 : UserControl
    {
        private Lv0 _lvTypeSelected;

        public DanhSachLv0()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
        }

        public DanhSachLv0(Lv0 lvType)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            _lvTypeSelected = lvType;
            if (lvType.Equals(Lv0.KhachHang)) {
                InitKhachHang();
            }
        }

        private void InitKhachHang()
        {
            labelDanhSach.Text = Define.DANH_SACH_KHACH_HANG_HEADER;
            lvDanhSach.View = System.Windows.Forms.View.Details;
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.Index, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.Name, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.Address, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.PhoneNumber, Convert.ToInt32(lvDanhSach.Width * 0.2), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.MST, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.STK, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);
            lvDanhSach.Columns.Add(DanhSachKhachHangTemplate.BankName, Convert.ToInt32(lvDanhSach.Width * 0.1), HorizontalAlignment.Center);

            InitDataListView();
            int i = 1;
        }

        private void InitDataListView()
        {
            var items = MainForm.RepositoryWrapper.KhachHang.FindAll().ToList();
            foreach (var item in items) {
                string[] itemValues = new string[] { "KH-" + item.Ma_KH, item.Ten, item.Dia_Chi, item.SDT, item.MST, item.STK, item.Ten_NH };

                if (itemValues.Length > 0) {
                    lvDanhSach.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_KH });
                }
            }
        }

        private void btnXemChiTiet_Click(object sender, EventArgs e)
        {
            if (_lvTypeSelected.Equals(Lv0.KhachHang)) {
                var addKh = new TaoHoacCapNhatKH();
                addKh.ShowDialog();
            }
        }

        private void lvDanhSach_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
        }
    }
}
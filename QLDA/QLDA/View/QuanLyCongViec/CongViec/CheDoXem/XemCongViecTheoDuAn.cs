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
using QLDA.View.Template;

namespace QLDA.View.QuanLyCongViec.CongViec.CheDoXem
{
    public partial class XemCongViecTheoDuAn : UserControl
    {
        private RepositoryWrapper _repository;
        private int? _currentIdDASelected;
        private int? _currentIdQTSelected;

        public XemCongViecTheoDuAn()
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            InitTemplateDsCv();
            InitDsDA();
        }

        private void InitDsDA()
        {
            var dAs = _repository.DuAn.FindAll().ToList();
            if (dAs == null || dAs.Count < 1) {
                return;
            }
            foreach (var da in dAs) {
                lvDuAn.Items.Add(new ListViewItem(Define.PREFIX_DU_AN + da.Ma_DA + " " + da.Ten) { Tag = da.Ma_DA });
            }
        }

        private void InitDsCV(bool isReloadRepository = false)
        {
            if (isReloadRepository) {
                _repository = RepositoryWrapper.Create();
            }
            lvCv.Items.Clear();
            var cvs = _repository.CongViec.FindByCondition(x => x.Ma_QT == _currentIdQTSelected).ToList();

            foreach (var cv in cvs) {
                _repository.RepositoryContext.Entry(cv).Reference(x => x.NhanVien).Load();
                string[] values = new string[] {
                    Define.PREFIX_THANH_TOAN+cv.Ma_CV,
                    cv.Ten,
                    cv.Muc_Do_UT.ToString(),
                    cv.NhanVien!=null?cv.NhanVien.Ten:string.Empty,
                    cv.Thoi_Gian_HH.ToShortDateString(),
                    cv.Thoi_Gian_Giao.ToShortDateString(),
                    cv.Tai_Lieu,
                    cv.Trang_Thai
                    };
                lvCv.Items.Add(new ListViewItem(values) { Tag = cv.Ma_CV });
            }
        }

        private void InitTemplateDsCv()
        {
            lvCv.View = System.Windows.Forms.View.Details;
            lvCv.Columns.Add(DanhSachCongViecTemplate.Id, Convert.ToInt32(lvCv.Width * 0.1), HorizontalAlignment.Center);
            lvCv.Columns.Add(DanhSachCongViecTemplate.Name, Convert.ToInt32(lvCv.Width * 0.2), HorizontalAlignment.Center);
            lvCv.Columns.Add(DanhSachCongViecTemplate.Prior, Convert.ToInt32(lvCv.Width * 0.1), HorizontalAlignment.Center);
            lvCv.Columns.Add(DanhSachCongViecTemplate.Member, Convert.ToInt32(lvCv.Width * 0.2), HorizontalAlignment.Center);
            lvCv.Columns.Add(DanhSachCongViecTemplate.EndDate, Convert.ToInt32(lvCv.Width * 0.1), HorizontalAlignment.Center);
            lvCv.Columns.Add(DanhSachCongViecTemplate.RealEndDate, Convert.ToInt32(lvCv.Width * 0.1), HorizontalAlignment.Center);
            lvCv.Columns.Add(DanhSachCongViecTemplate.Storage, Convert.ToInt32(lvCv.Width * 0.1), HorizontalAlignment.Center);
            lvCv.Columns.Add(DanhSachCongViecTemplate.Status, Convert.ToInt32(lvCv.Width * 0.1), HorizontalAlignment.Center);
        }

        private void InitDsQT(bool isReloadRepo = false)
        {
            if (_currentIdDASelected == null) {
                return;
            }
            if (isReloadRepo) {
                _repository = RepositoryWrapper.Create();
            }
            cbxQT.Items.Clear();
            var hds = _repository.QuyTrinh.FindByCondition(h => h.Ma_DA == _currentIdDASelected).ToList();

            if (hds.Count < 1) {
                lvCv.Items.Clear();
                cbxQT.SelectedItem = null;
                _currentIdQTSelected = null;
                Refresh();
                return;
            }
            foreach (var item in hds) {
                cbxQT.Items.Add(new ItemComboboxTemplate() { Id = item.Ma_QT, Prefix = Define.PREFIX_HOP_DONG + item.Ma_QT, Content = item.Ten });
            }
            cbxQT.SelectedIndex = 0;
            _currentIdQTSelected = hds[0].Ma_QT;
            InitDsCV();
        }

        public void Create()
        {
            if (_currentIdDASelected != null && _currentIdQTSelected != null) {
                var add = new TaoHoacCapNhatCV((int)_currentIdQTSelected, true);
                add.ShowDialog();
                if (add.HasReloadList) {
                    InitDsCV(true);
                }
            }
            else {
                MessageBox.Show(Define.PLEASE_SELECT);
            }
        }

        public void Updatee()
        {
            if (lvCv.SelectedItems.Count > 0) {
                int idUpdate = (int)lvCv.SelectedItems[0].Tag;
                var update = new TaoHoacCapNhatCV((int)lvCv.SelectedItems[0].Tag);
                update.ShowDialog();
                if (update.HasReloadList) {
                    InitDsCV(true);
                }
            }
            else {
                MessageBox.Show(Define.PLEASE_SELECT);
            }
        }

        public void Delete()
        {
            if (lvCv.SelectedItems.Count > 0 && Define.ConfirmDelete()) {
                int idDelete = (int)lvCv.SelectedItems[0].Tag;
                var cv = _repository.CongViec.FindByCondition(x => x.Ma_CV == idDelete).FirstOrDefault();
                if (cv != null) {
                    _repository.CongViec.Delete(cv);
                    _repository.SaveChange();
                    InitDsCV(true);
                }
            }
            else {
                MessageBox.Show(Define.PLEASE_SELECT);
            }
        }

        private void lvDuAn_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvDuAn.SelectedItems.Count > 0) {
                _currentIdDASelected = (int)lvDuAn.SelectedItems[0].Tag;
                InitDsQT();
            }
        }

        private void cbxQT_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_currentIdDASelected == null) {
                return;
            }
            _currentIdQTSelected = ((ItemComboboxTemplate)cbxQT.SelectedItem).Id;
            InitDsCV();
        }

        private void lvCv_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Define.BrushHeaderLv, e.Bounds);
            e.DrawText();
        }

        private void lvDuAn_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            e.Graphics.FillRectangle(Define.BrushHeaderLv, e.Bounds);
            e.DrawText();
        }

        private void lvCv_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }

        private void lvDuAn_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            e.DrawDefault = true;
        }
    }
}
﻿using QLDA.Model;
using QLDA.View.Template;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA.View.DanhMuc.KhachHang
{
    public partial class XemChiTietKH : Form
    {
        private int? _idViewDetail;

        public XemChiTietKH()
        {
            InitializeComponent();
        }

        public XemChiTietKH(int idViewDetail)
        {
            InitializeComponent();
            _idViewDetail = idViewDetail;
            InitDuAn();
            var kh = MainForm.RepositoryWrapper.KhachHang.FindByCondition(x => x.Ma_KH == _idViewDetail).FirstOrDefault();
            if (kh == null) {
                return;
            }

            MainForm.RepositoryWrapper.RepositoryContext.Entry(kh).Collection(x => x.Cac_Du_An).Load();
            txtMaKH.Text = kh.Ma_KH.ToString();
            txtTenKH.Text = kh.Ten;
            txtDC.Text = kh.Dia_Chi;
            txtMST.Text = kh.MST;
            txtSDT.Text = kh.SDT;
            txtTKNH.Text = kh.STK;
            txtTenNH.Text = kh.Ten_NH;
            if (kh.Cac_Du_An != null && kh.Cac_Du_An.Count > 0) {
                InitDataListViewDuAn(kh.Cac_Du_An);
            }
        }

        private void InitDuAn()
        {
            lvDSDA.View = System.Windows.Forms.View.Details;
            lvDSDA.Columns.Add(DanhSachDuAnTemplate.Id, Convert.ToInt32(lvDSDA.Width * 0.1), HorizontalAlignment.Center);
            lvDSDA.Columns.Add(DanhSachDuAnTemplate.Name, Convert.ToInt32(lvDSDA.Width * 0.2), HorizontalAlignment.Center);
            lvDSDA.Columns.Add(DanhSachDuAnTemplate.Group, Convert.ToInt32(lvDSDA.Width * 0.1), HorizontalAlignment.Center);
            lvDSDA.Columns.Add(DanhSachDuAnTemplate.Location, Convert.ToInt32(lvDSDA.Width * 0.2), HorizontalAlignment.Center);
            lvDSDA.Columns.Add(DanhSachDuAnTemplate.StartDate, Convert.ToInt32(lvDSDA.Width * 0.1), HorizontalAlignment.Center);
            lvDSDA.Columns.Add(DanhSachDuAnTemplate.EndDate, Convert.ToInt32(lvDSDA.Width * 0.1), HorizontalAlignment.Center);
            lvDSDA.Columns.Add(DanhSachDuAnTemplate.RealEndDate, Convert.ToInt32(lvDSDA.Width * 0.1), HorizontalAlignment.Center);
            lvDSDA.Columns.Add(DanhSachDuAnTemplate.Status, Convert.ToInt32(lvDSDA.Width * 0.1), HorizontalAlignment.Center);
        }

        public void InitDataListViewDuAn(ICollection<DuAn> items)
        {
            foreach (var item in items) {
                string[] itemValues = new string[] {
                    Define.PREFIX_DU_AN + item.Ma_DA,
                    item.Ten, item.Nhom,
                    item.Dia_Diem,item.Thoi_Gian_BD.ToString(),
                    item.Thoi_Gian_KT.ToString(),
                    item.Thoi_Gian_KT_TT.ToString(),
                    item.Trang_Thai
                };

                if (itemValues.Length > 0) {
                    lvDSDA.Items.Add(new ListViewItem(itemValues) { Tag = item.Ma_DA });
                }
            }
        }
    }
}
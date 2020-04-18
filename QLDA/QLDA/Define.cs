﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA
{
    public static class Define
    {
        public const string DANH_SACH_KHACH_HANG_HEADER = "Danh sách khách hàng";
        public const string DANH_SACH_NHAN_VIEN_HEADER = "Danh sách nhân viên";
        public const string DANH_SACH_DU_AN_HEADER = "Danh sách dự án";

        public const string THEM_MOI_NHAN_VIEN = "Thêm mới nhân viên";
        public const string THEM_MOI_KHACH_HANG = "Thêm mới khách hàng";
        public const string THEM_MOI_DU_AN = "Thêm mới dự án";

        public const string CHINH_SUA_NHAN_VIEN = "Chỉnh sửa nhân viên";
        public const string CHINH_SUA_KHACH_HANG = "Chỉnh sửa khách hàng";
        public const string CHINH_SUA_DU_AN = "Chỉnh sửa dự án";

        public const string PREFIX_DU_AN = "DA-";
        public const string PREFIX_NHAN_VIEN = "NV-";
        public const string PREFIX_KHACH_HANG = "KH-";
        public const string PREFIX_HOP_DONG = "HD-";
        public const string PREFIX_QUA_TRINH = "QT-";
        public const string PREFIX_CONG_VIEC = "CV-";
        public const string PREFIX_THANH_TOAN = "TT-";

        #region message

        public const string CONFIRM_DELETE = "Bạn có thực sự muốn xóa";
        public const string TITLE_CONFIRM = "Xác nhận";
        public const string PLEASE_SELECT = "Hãy lựa chọn một đối tượng để thực hiện tính năng này";

        #endregion message
    }

    public enum ViewMode
    {
        DanhMucKhachHang,
        DanhMucNhanVien,
        DuAn,
        HopDong,
        ThanhToan,
        QuyTrinh,
        CongViec
    }

    public enum Lv0
    {
        KhachHang,
        NhanVien,
        DuAn
    }

    public enum Lv1
    {
        HopDong,
        QuyTrinh
    }
}
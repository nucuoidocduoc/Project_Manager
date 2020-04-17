using System;
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
}
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA
{
    public static class Define
    {
        public const string DANH_SACH_KHACH_HANG_HEADER = "Danh sách khách hàng";
        public const string DANH_SACH_NHAN_VIEN_HEADER = "Danh sách nhân viên";
        public const string DANH_SACH_DU_AN_HEADER = "Danh sách dự án";
        public const string DANH_SACH_NHOM_DA_HEADER = "Danh sách nhóm dự án";
        public const string DANH_SACH_TIEN_TE = "Danh sách đơn vị tiền tệ";
        public const string DANH_SACH_TAI_KHOAN = "Danh sách tài khoản";
        public const string DETAIL_INFO_PROJECT = "Thông tin chi tiết dự án";

        public const string THEM_MOI_NHAN_VIEN = "Thêm mới nhân viên";
        public const string THEM_MOI_KHACH_HANG = "Thêm mới khách hàng";
        public const string THEM_MOI_DU_AN = "Thêm mới dự án";

        public const string CHINH_SUA_NHAN_VIEN = "Chỉnh sửa nhân viên";
        public const string CHINH_SUA_KHACH_HANG = "Chỉnh sửa khách hàng";
        public const string CHINH_SUA_DU_AN = "Chỉnh sửa dự án";

        public const string PREFIX_DU_AN = "DA-";
        public const string PREFIX_NHAN_VIEN = "NV-";
        public const string PREFIX_KHACH_HANG = "CDT-";
        public const string PREFIX_HOP_DONG = "HD-";
        public const string PREFIX_QUI_TRINH = "QT-";
        public const string PREFIX_CONG_VIEC = "CV-";
        public const string PREFIX_THANH_TOAN = "TT-";
        public const string PREFIX_NHOM_DA = "NDA-";
        public const string PREFIX_TIEN_TE = "TIT-";
        public const string PREFIX_TAI_KHOAN = "TK-";

        #region message

        public const string CONFIRM_DELETE = "Bạn có thực sự muốn xóa";
        public const string TITLE_CONFIRM = "Xác nhận";
        public const string PLEASE_SELECT = "Hãy lựa chọn một đối tượng để thực hiện tính năng này";
        public const string PLEASE_SELECT_PROJECT = "Hãy lựa chọn một dự án để thực hiện tính năng này";

        #endregion message

        #region status du an

        public const string FINISHED = "Đã hoàn thành";
        public const string PENDING = "Đang đấu thầu";
        public const string UNFINISH = "Đang thực hiện";
        public const string PAUSE = "Đang tạm hoãn";

        #endregion status du an

        public const string Admin = "Admin";

        public const string User = "User";

        public const double ConvertMoneyUSDToVND = 23000;

        public static Brush BrushHeaderLv = Brushes.DarkGray;

        public static bool ConfirmDelete()
        {
            var btn = MessageBox.Show(Define.CONFIRM_DELETE, Define.TITLE_CONFIRM, MessageBoxButtons.YesNo);
            return btn.Equals(DialogResult.Yes);
        }

        public static double GetMoney(Model.ThanhToan thanhToan)
        {
            if (double.TryParse(thanhToan.So_Tien, out double value)) {
                //if (thanhToan.Loai_Tien.Equals(Define.VND)) {
                //    return value;
                //}
                //else if (thanhToan.Loai_Tien.Equals(Define.USD)) {
                //    return value * Define.ConvertMoneyUSDToVND;
                //}
                return value * thanhToan.Loai_Tien.Ti_gia;
            }
            else {
                return 0;
            }
        }
    }

    public enum ViewMode
    {
        KhachHang,
        NhanVien,
        DuAn,
        HopDong,
        ThanhToan,
        QuyTrinh,
        CongViec,
        TienTe,
        NhomDA,
        TaiKhoan,
        Chart
    }

    //public enum Lv0
    //{
    //    KhachHang,
    //    NhanVien,
    //    DuAn
    //}

    //public enum Lv1
    //{
    //    HopDong,
    //    QuyTrinh
    //}
}
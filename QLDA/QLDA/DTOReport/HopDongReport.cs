using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.DTOReport
{
    public class HopDongReport
    {
        public int Index { get; set; }
        public string Ma_HD { get; set; }
        public string Ten { get; set; }
        public string Thoi_Diem_Ky { get; set; }
        public double Tong_Gia_Tri { get; set; }
        public string Chu_Dau_Tu { get; set; }
        public double DaThanhToan { get; set; }
        public double ChuaThanhToan { get => Tong_Gia_Tri - DaThanhToan; }

        public static HopDongReport Create(Model.HopDong hopDong, double daThanhToan, string cdt)
        {
            HopDongReport hopDongReport = new HopDongReport();
            hopDongReport.Ma_HD = Define.PREFIX_HOP_DONG + hopDong.Ma_HD;
            hopDongReport.Ten = hopDong.Ten;
            hopDongReport.Thoi_Diem_Ky = hopDong.Thoi_Diem_Ky.ToShortDateString();
            if (double.TryParse(hopDong.Tong_Gia_Tri, out double value)) {
                hopDongReport.Tong_Gia_Tri = value;
            }
            hopDongReport.Chu_Dau_Tu = cdt;
            hopDongReport.DaThanhToan = daThanhToan;
            return hopDongReport;
        }
    }
}
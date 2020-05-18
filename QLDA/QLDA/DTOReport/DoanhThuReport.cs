using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.DTOReport
{
    public class DoanhThuReport
    {
        public int Index { get; set; }
        public string NguonThu { get; set; }
        public double GiaTri { get; set; }

        public static DoanhThuReport Create(Model.KhachHang khachHang, double giaTri)
        {
            DoanhThuReport doanhThuReport = new DoanhThuReport();
            doanhThuReport.NguonThu = khachHang.Ten;
            doanhThuReport.GiaTri = giaTri;
            return doanhThuReport;
        }
    }
}
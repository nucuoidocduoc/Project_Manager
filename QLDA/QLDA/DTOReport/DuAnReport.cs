using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.DTOReport
{
    public class DuAnReport
    {
        public int Index { get; set; }
        public string Ma_DA { get; set; }
        public string Chu_Dau_Tu { get; set; }
        public string Ten { get; set; }
        public string Dia_Diem { get; set; }
        public string Thoi_Gian_BD { get; set; }
        public string Thoi_Gian_KT { get; set; }

        public static DuAnReport Create(Model.DuAn da)
        {
            DuAnReport duAnReport = new DuAnReport();
            duAnReport.Ma_DA = Define.PREFIX_DU_AN + da.Ma_DA.ToString();
            if (da.KhachHang != null) {
                duAnReport.Chu_Dau_Tu = da.KhachHang.Ten;
            }
            duAnReport.Ten = da.Ten;
            duAnReport.Dia_Diem = da.Dia_Diem;
            duAnReport.Thoi_Gian_BD = da.Thoi_Gian_BD.ToShortDateString();
            duAnReport.Thoi_Gian_KT = da.Thoi_Gian_KT.ToShortDateString();
            return duAnReport;
        }
    }
}
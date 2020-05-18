using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.DTOReport
{
    public class CongViecReport
    {
        public int Index { get; set; }
        public string Ma_CV { get; set; }
        public string Ma_DA { get; set; }
        public string Ten { get; set; }
        public string NguoiLam { get; set; }
        public string Thoi_Gian_Giao { get; set; }
        public string Thoi_Gian_HH { get; set; }

        public static CongViecReport Create(Model.CongViec congViec)
        {
            CongViecReport congViecReport = new CongViecReport();

            congViecReport.Ma_CV = Define.PREFIX_CONG_VIEC + congViec.Ma_CV;
            congViecReport.Ma_DA = Define.PREFIX_DU_AN + congViec.QuyTrinh.Ma_DA.ToString();
            congViecReport.Ten = congViec.Ten;
            congViecReport.NguoiLam = congViec.NhanVien.Ten;
            congViecReport.Thoi_Gian_Giao = congViec.Thoi_Gian_Giao.ToShortDateString();
            congViecReport.Thoi_Gian_HH = congViec.Thoi_Gian_HH.ToShortDateString();

            return congViecReport;
        }
    }
}
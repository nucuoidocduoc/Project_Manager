using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Model
{
    [Table("Cong_Viec")]
    public class CongViec
    {
        [Key]
        public int Ma_CV { get; set; }

        public string Ten { get; set; }
        public int Muc_Do_UT { get; set; }
        public DateTime Thoi_Gian_Giao { get; set; }
        public DateTime Thoi_Gian_HH { get; set; }
        public string Trang_Thai { get; set; }
        public string Tai_Lieu { get; set; }
        public int? Ma_NV { get; set; }

        [ForeignKey(nameof(Ma_NV))]
        public NhanVien NhanVien { get; set; }

        public int Ma_QT { get; set; }

        [ForeignKey(nameof(Ma_QT))]
        public QuyTrinh QuyTrinh { get; set; }
    }
}
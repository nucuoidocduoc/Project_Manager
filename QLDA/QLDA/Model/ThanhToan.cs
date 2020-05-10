using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLDA.Model
{
    [Table("TT_Thanh_Toan")]
    public class ThanhToan
    {
        [Key]
        public int Ma_TT { get; set; }

        public string Ten { get; set; }
        public DateTime Thoi_Gian_TT { get; set; }
        public string So_Tien { get; set; }

        public string Hinh_Thuc { get; set; }
        public string Dien_Giai { get; set; }
        public int Ma_HD { get; set; }

        [ForeignKey(nameof(Ma_HD))]
        public HopDong HopDong { get; set; }

        public int? Ma_Tien_Te { get; set; }

        [ForeignKey(nameof(Ma_Tien_Te))]
        public TienTe Loai_Tien { get; set; }
    }
}
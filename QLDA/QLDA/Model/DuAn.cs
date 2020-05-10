using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLDA.Model
{
    [Table("Du_An")]
    public class DuAn
    {
        [Key]
        public int Ma_DA { get; set; }

        public string Ten { get; set; }
        public string Dia_Diem { get; set; }
        public DateTime Thoi_Gian_BD { get; set; }
        public DateTime Thoi_Gian_KT { get; set; }
        public DateTime Thoi_Gian_KT_TT { get; set; }
        public string Trang_Thai { get; set; }
        public string Dien_Giai { get; set; }
        public int? Ma_NV { get; set; }

        [ForeignKey(nameof(Ma_NV))]
        public NhanVien NhanVien { get; set; }

        public int? Ma_KH { get; set; }

        [ForeignKey(nameof(Ma_KH))]
        public KhachHang KhachHang { get; set; }

        public int? Ma_Nhom { get; set; }

        [ForeignKey(nameof(Ma_Nhom))]
        public NhomDA Nhom_DA { get; set; }

        public virtual ICollection<QuyTrinh> Cac_Quy_Trinh { get; set; }
        public virtual ICollection<HopDong> Cac_Hop_Dong { get; set; }
    }
}
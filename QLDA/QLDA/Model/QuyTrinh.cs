using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Model
{
    [Table("Quy_Trinh")]
    public class QuyTrinh
    {
        [Key]
        public int Ma_QT { get; set; }

        public string Ten { get; set; }
        public string Loai_QT { get; set; }
        public DateTime Thoi_Gian_BD { get; set; }
        public DateTime Thoi_Gian_KT { get; set; }
        public string Trang_Thai { get; set; }
        public int Ma_DA { get; set; }

        [ForeignKey(nameof(Ma_DA))]
        public DuAn DuAn { get; set; }

        public int? Ma_NV { get; set; }

        [ForeignKey(nameof(Ma_NV))]
        public NhanVien NhanVien { get; set; }

        public virtual ICollection<CongViec> Cac_Cong_Viec { get; set; }
    }
}
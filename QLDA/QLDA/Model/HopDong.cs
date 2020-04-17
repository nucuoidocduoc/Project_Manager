using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Model
{
    [Table("Hop_Dong")]
    public class HopDong
    {
        [Key]
        public int Ma_HD { get; set; }

        public string Ten { get; set; }
        public DateTime Thoi_Diem_Ky { get; set; }
        public DateTime Thoi_Gian_KT { get; set; }
        public string Tong_Gia_Tri { get; set; }
        public string Trang_Thai { get; set; }
        public string Dien_Giai { get; set; }
        public int Ma_DA { get; set; }

        [ForeignKey(nameof(Ma_DA))]
        public DuAn DuAn { get; set; }

        public virtual ICollection<ThanhToan> Cac_Thanh_Toan { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string Loai_Tien { get; set; }
        public string Hinh_Thuc { get; set; }
        public string Dien_Giai { get; set; }
        public int Ma_HD { get; set; }

        [ForeignKey(nameof(Ma_HD))]
        public HopDong HopDong { get; set; }
    }
}
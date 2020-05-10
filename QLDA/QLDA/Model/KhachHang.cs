using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLDA.Model
{
    [Table("Khach_Hang")]
    public class KhachHang
    {
        [Key]
        [Column("Ma_KH")]
        public int Ma_KH { get; set; }

        public string Ten { get; set; }
        public string Dia_Chi { get; set; }
        public string SDT { get; set; }
        public string MST { get; set; }
        public string STK { get; set; }
        public string Ten_NH { get; set; }

        public virtual ICollection<DuAn> Cac_Du_An { get; set; }
    }
}
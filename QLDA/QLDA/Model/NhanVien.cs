using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLDA.Model
{
    [Table("Nhan_Vien")]
    public class NhanVien
    {
        [Key]
        public int Ma_NV { get; set; }

        public string Ten { get; set; }
        public string Dia_Chi { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }

        public virtual ICollection<DuAn> Cac_Du_An { get; set; }
        public virtual ICollection<QuyTrinh> Cac_Quy_Trinh { get; set; }
        public virtual ICollection<CongViec> CongViecs { get; set; }
    }
}
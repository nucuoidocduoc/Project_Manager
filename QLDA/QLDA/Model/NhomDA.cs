using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLDA.Model
{
    [Table("Nhom_DA")]
    public class NhomDA
    {
        [Key]
        public int Ma_Nhom { get; set; }

        public string Ten { get; set; }
        public string Dien_Giai { get; set; }

        public virtual ICollection<DuAn> Cac_Du_An { get; set; }
    }
}
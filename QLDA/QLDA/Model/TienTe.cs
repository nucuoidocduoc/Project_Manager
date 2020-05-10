using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLDA.Model
{
    [Table("DV_Tien_Te")]
    public class TienTe
    {
        [Key]
        public int Ma_Tien_Te { get; set; }

        public string Ten { get; set; }

        public double Ti_gia { get; set; }
        public string Dien_Giai { get; set; }

        public virtual ICollection<ThanhToan> Cac_Thanh_Toan { get; set; }
    }
}
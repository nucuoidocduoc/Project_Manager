using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLDA.Model
{
    [Table("Tai_Khoan")]
    public class TaiKhoan
    {
        [Key]
        public int Ma_TK { get; set; }

        public string Ten { get; set; }
        public string MK { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
    }
}
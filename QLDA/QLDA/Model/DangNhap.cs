using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Model
{
    [Table("Dang_Nhap")]
    public class DangNhap
    {
        [Key]
        public int Ma_DN { get; set; }

        public string Ten { get; set; }
        public string MK { get; set; }
    }
}
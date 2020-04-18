using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.View.Template
{
    public class ItemComboboxTemplate
    {
        public int? Id { get; set; }
        public string Prefix { get; set; } = string.Empty;
        public string Content { get; set; }
        public string Subfix { get; set; } = string.Empty;

        public override string ToString()
        {
            return Prefix + " " + Content + " " + Subfix;
        }
    }
}
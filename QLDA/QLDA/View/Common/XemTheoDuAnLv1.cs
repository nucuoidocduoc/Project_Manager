using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA.View.Common
{
    public partial class XemTheoDuAnLv1 : UserControl
    {
        private Lv1 _lv1Type;

        public XemTheoDuAnLv1()
        {
            InitializeComponent();
        }

        public XemTheoDuAnLv1(Lv1 lv1Type)
        {
            InitializeComponent();
            _lv1Type = lv1Type;
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH2019
{
    public partial class frmPreviewReport : Form
    {
        public frmPreviewReport(CrystalReport1 rpt)
        {
            InitializeComponent();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void frmPreviewReport_Load(object sender, EventArgs e)
        {
            this.crystalReportViewer1.RefreshReport();
           
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}

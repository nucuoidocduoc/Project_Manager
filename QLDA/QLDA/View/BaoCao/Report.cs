using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLDA.View.Template;
using QLDA.Repository;

namespace QLDA.View.BaoCao
{
    public partial class Report : UserControl
    {
        private string _selectedReport = string.Empty;

        public Report()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (dtFrom.Value > dtTo.Value) {
                MessageBox.Show("Thời gian bắt đầu không thể lớn hơn thời gian kết thúc");
                return;
            }
            PrintReportForm printReportForm = new PrintReportForm(dtFrom.Value, dtTo.Value, _selectedReport);
            printReportForm.ShowDialog();
        }

        private void panel2DT_Click(object sender, EventArgs e)
        {
            ClearBorder();
            _selectedReport = "DT";
            panel2DT.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panelDA_Click(object sender, EventArgs e)
        {
            ClearBorder();
            _selectedReport = "DA";
            panelDA.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panelHD_Click(object sender, EventArgs e)
        {
            ClearBorder();
            _selectedReport = "HD";
            panelHD.BorderStyle = BorderStyle.Fixed3D;
        }

        private void panelCV_Click(object sender, EventArgs e)
        {
            ClearBorder();
            _selectedReport = "CV";
            panelCV.BorderStyle = BorderStyle.Fixed3D; ;
        }

        private void panelCDT_Click(object sender, EventArgs e)
        {
            ClearBorder();
            _selectedReport = "CDT";
            panelCDT.BorderStyle = BorderStyle.Fixed3D;
        }

        private void ClearBorder()
        {
            panel2DT.BorderStyle = BorderStyle.None;
            panelDA.BorderStyle = BorderStyle.None;
            panelHD.BorderStyle = BorderStyle.None;
            panelCV.BorderStyle = BorderStyle.None; ;
            panelCDT.BorderStyle = BorderStyle.None;
        }

        private void label3_Click(object sender, EventArgs e)
        {
            panel2DT_Click(null, null);
        }

        private void label4_Click(object sender, EventArgs e)
        {
            panelDA_Click(null, null);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            panelHD_Click(null, null);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            panelCV_Click(null, null);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            panelCDT_Click(null, null);
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (dtFrom.Value > dtTo.Value) {
                MessageBox.Show("Thời gian bắt đầu không thể lớn hơn thời gian kết thúc");
                return;
            }
            PrintReportForm printReportForm = new PrintReportForm(dtFrom.Value, dtTo.Value, _selectedReport);
            printReportForm.ShowDialog();
        }
    }
}
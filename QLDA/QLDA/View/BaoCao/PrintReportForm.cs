using QLDA.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLDA.View.BaoCao
{
    public partial class PrintReportForm : Form
    {
        private DateTime _from;
        private DateTime _to;
        private string _reportType;
        private RepositoryWrapper _repositoryWrapper;

        public PrintReportForm(DateTime from, DateTime to, string reportType)
        {
            InitializeComponent();
            _from = from;
            _to = to;
            _reportType = reportType;
            _repositoryWrapper = RepositoryWrapper.Create();
            InitReport();
        }

        private void InitReport()
        {
            if (_reportType.Equals("DT"))
            {
                InitDT();
            }
            else if (_reportType.Equals("DA"))
            {
                InitDA();
            }
            else if (_reportType.Equals("HD"))
            {
                InitHD();
            }
            else if (_reportType.Equals("CV"))
            {
                InitCV();
            }
            else if (_reportType.Equals("CDT"))
            {
            }
        }

        private bool IsSatisfyDate(DateTime from, DateTime to)
        {
            if (from >= _from && from < _to)
            {
                return true;
            }
            else if (from < _from && to > _from)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void InitDT()
        {
            List<DTOReport.DoanhThuReport> doanhThuReports = new List<DTOReport.DoanhThuReport>();
            var dictionary = new Dictionary<int, double>();

            var dAs = _repositoryWrapper.DuAn.FindByCondition(x => !x.Trang_Thai.Equals(Define.PENDING)).ToList();
            foreach (var da in dAs)
            {
                _repositoryWrapper.RepositoryContext.Entry(da).Collection(x => x.Cac_Hop_Dong).Load();
                if (da.Cac_Hop_Dong.Count > 0)
                {
                    if (dictionary.ContainsKey((int)da.Ma_KH))
                    {
                        dictionary[(int)da.Ma_KH] = dictionary[(int)da.Ma_KH] + da.Cac_Hop_Dong.Sum(x => double.Parse(x.Tong_Gia_Tri));
                    }
                    else
                    {
                        dictionary.Add((int)da.Ma_KH, da.Cac_Hop_Dong.Sum(x => double.Parse(x.Tong_Gia_Tri)));
                    }
                }
            }

            foreach (var key in dictionary.Keys)
            {
                var kh = _repositoryWrapper.KhachHang.FindByCondition(x => x.Ma_KH == key).FirstOrDefault();
                if (kh != null)
                {
                    doanhThuReports.Add(DTOReport.DoanhThuReport.Create(kh, dictionary[key]));
                }
            }
            var report = new DTReport();
            report.SetDataSource(doanhThuReports);
            //report.SetParameterValue("fromDate", _from.ToShortDateString());
            //report.SetParameterValue("toDate", _to.ToShortDateString());
            reportView.ReportSource = report;
            reportView.Refresh();
        }

        private void InitDA()
        {
            List<DTOReport.DuAnReport> duAnReports = new List<DTOReport.DuAnReport>();
            var duAns = _repositoryWrapper.DuAn.FindByCondition(x => (x.Thoi_Gian_BD > _from && x.Thoi_Gian_BD < _to) || (x.Thoi_Gian_BD < _from && x.Thoi_Gian_KT > _from)).ToList();
            if (duAns.Count > 0)
            {
                foreach (var da in duAns)
                {
                    _repositoryWrapper.RepositoryContext.Entry(da).Reference(x => x.KhachHang).Load();
                    var rp = DTOReport.DuAnReport.Create(da);
                    duAnReports.Add(rp);
                }
            }
            var report = new DADangThucHienReport();
            report.SetDataSource(duAnReports);
            report.SetParameterValue("fromDate", _from.ToShortDateString());
            report.SetParameterValue("toDate", _to.ToShortDateString());

            reportView.ReportSource = report;
            reportView.Refresh();
        }

        private void InitHD()
        {
            List<DTOReport.HopDongReport> hopDongReports = new List<DTOReport.HopDongReport>();
            var hds = _repositoryWrapper.HopDong.FindByCondition(x => (x.Thoi_Diem_Ky > _from && x.Thoi_Diem_Ky < _to) || (x.Thoi_Diem_Ky < _from && x.Thoi_Gian_KT > _from)).ToList();

            if (hds.Count > 0)
            {
                foreach (var hd in hds)
                {
                    _repositoryWrapper.RepositoryContext.Entry(hd).Collection(x => x.Cac_Thanh_Toan).Load();
                    _repositoryWrapper.RepositoryContext.Entry(hd).Reference(x => x.DuAn).Load();
                    _repositoryWrapper.RepositoryContext.Entry(hd.DuAn).Reference(x => x.KhachHang).Load();
                    double value = 0;
                    foreach (var tt in hd.Cac_Thanh_Toan)
                    {
                        _repositoryWrapper.RepositoryContext.Entry(tt).Reference(x => x.Loai_Tien).Load();
                        value += Define.GetMoney(tt);
                    }
                    hopDongReports.Add(DTOReport.HopDongReport.Create(hd, value, hd.DuAn.KhachHang.Ten));
                }
            }
            var report = new HDDangThucHienReport();
            report.SetDataSource(hopDongReports);
            report.SetParameterValue("fromDate", _from.ToShortDateString());
            report.SetParameterValue("toDate", _to.ToShortDateString());
            reportView.ReportSource = report;
            reportView.Refresh();
        }

        private void InitCV()
        {
            List<DTOReport.CongViecReport> congViecReports = new List<DTOReport.CongViecReport>();
            var cvs = _repositoryWrapper.CongViec.FindByCondition(x => (x.Thoi_Gian_Giao > _from && x.Thoi_Gian_Giao < _to) || (x.Thoi_Gian_Giao < _from && x.Thoi_Gian_HH > _from)).ToList();
            if (cvs.Count > 0)
            {
                foreach (var cv in cvs)
                {
                    _repositoryWrapper.RepositoryContext.Entry(cv).Reference(x => x.NhanVien).Load();
                    _repositoryWrapper.RepositoryContext.Entry(cv).Reference(x => x.QuyTrinh).Load();
                    congViecReports.Add(DTOReport.CongViecReport.Create(cv));
                }
            }
            var report = new CVReport();
            report.SetDataSource(congViecReports);
            report.SetParameterValue("fromDate", _from.ToShortDateString());
            report.SetParameterValue("toDate", _to.ToShortDateString());
            reportView.ReportSource = report;
            reportView.Refresh();
        }
    }
}
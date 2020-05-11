using LiveCharts;
using LiveCharts.Wpf;
using QLDA.Repository;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLDA.View.Charts
{
    public partial class Chart : UserControl
    {
        private RepositoryWrapper _repository;

        public Chart()
        {
            InitializeComponent();
            _repository = RepositoryWrapper.Create();
            InitChartDA();
            //InitChartCV();
        }

        private void InitChartDA()
        {
            int countFinish = _repository.DuAn.FindByCondition(x => x.Trang_Thai.Equals(Define.FINISHED)).Count();
            int countPending = _repository.DuAn.FindByCondition(x => x.Trang_Thai.Equals(Define.PENDING)).Count();
            int countInprogress = _repository.DuAn.FindByCondition(x => x.Trang_Thai.Equals(Define.UNFINISH)).Count();
            int countDelay = _repository.DuAn.FindByCondition(x => x.Trang_Thai.Equals(Define.PAUSE)).Count();
            Func<ChartPoint, string> labelPoint = chartPoint =>
                string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

            pieChart1.Series = new SeriesCollection
            {
                new PieSeries
                {
                    Title = Define.FINISHED,
                    Values = new ChartValues<double> {countFinish},
                    PushOut = 15,
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = Define.UNFINISH,
                    Values = new ChartValues<double> {countInprogress},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
                ,
                new PieSeries
                {
                    Title = Define.PENDING,
                    Values = new ChartValues<double> {countPending},
                    DataLabels = true,
                    LabelPoint = labelPoint
                },
                new PieSeries
                {
                    Title = Define.PAUSE,
                    Values = new ChartValues<double> {countDelay},
                    DataLabels = true,
                    LabelPoint = labelPoint
                }
            };

            pieChart1.LegendLocation = LegendLocation.Bottom;
            //pieChartDA.BackColor = Color.Wheat;
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            pieChart1.Visible = true;
        }

        //private void InitChartCV()
        //{
        //    int countFinish = _repository.CongViec.FindByCondition(x => x.Trang_Thai.Equals(Define.FINISHED)).Count();
        //    //int countPending = _repository.CongViec.FindByCondition(x => x.Trang_Thai.Equals(Define.PENDING)).Count();
        //    int countInprogress = _repository.CongViec.FindByCondition(x => x.Trang_Thai.Equals(Define.UNFINISH)).Count();
        //    //int countDelay = _repository.CongViec.FindByCondition(x => x.Trang_Thai.Equals(Define.PAUSE)).Count();
        //    Func<ChartPoint, string> labelPoint = chartPoint =>
        //        string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

        //    pieChartCV.Series = new SeriesCollection
        //    {
        //        new PieSeries
        //        {
        //            Title = Define.FINISHED,
        //            Values = new ChartValues<double> {countFinish},
        //            PushOut = 15,
        //            DataLabels = true,
        //            LabelPoint = labelPoint
        //        },
        //        new PieSeries
        //        {
        //            Title = Define.UNFINISH,
        //            Values = new ChartValues<double> {countInprogress},
        //            DataLabels = true,
        //            LabelPoint = labelPoint
        //        }
        //    };

        //    pieChartCV.LegendLocation = LegendLocation.Bottom;
        //}
    }
}
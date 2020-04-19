using QLDA.Context;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Repository
{
    public class RepositoryWrapper
    {
        protected RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public static RepositoryWrapper Create()
        {
            string connectionString = System.Configuration.ConfigurationManager.ConnectionStrings["sqlConnection"].ConnectionString;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            RepositoryContext repositoryContext = new RepositoryContext(connection, false);

            //MessageBox.Show(repositoryContext.KhachHangs.FirstOrDefault().Ten_NH);
            return new RepositoryWrapper(repositoryContext);
        }

        public RepositoryContext RepositoryContext { get => _repositoryContext; }
        private RepositoryContext _repositoryContext;
        private KhachHangRepository _khachHangRepository;
        private NhanVienRepository _nhanVienRepository;
        private DuAnRepository _duAnRepository;
        private HopDongRepository _hopDongRepository;
        private ThanhToanRepository _thanhToanRepository;
        private QuyTrinhRepository _quyTrinhRepository;
        private CongViecRepository _congViecRepository;

        public KhachHangRepository KhachHang
        {
            get
            {
                if (_khachHangRepository == null) {
                    _khachHangRepository = new KhachHangRepository(_repositoryContext);
                }
                return _khachHangRepository;
            }
        }

        public NhanVienRepository NhanVien
        {
            get
            {
                if (_nhanVienRepository == null) {
                    _nhanVienRepository = new NhanVienRepository(_repositoryContext);
                }
                return _nhanVienRepository;
            }
        }

        public DuAnRepository DuAn
        {
            get
            {
                if (_duAnRepository == null) {
                    _duAnRepository = new DuAnRepository(_repositoryContext);
                }
                return _duAnRepository;
            }
        }

        public HopDongRepository HopDong
        {
            get
            {
                if (_hopDongRepository == null) {
                    _hopDongRepository = new HopDongRepository(_repositoryContext);
                }
                return _hopDongRepository;
            }
        }

        public ThanhToanRepository ThanhToan
        {
            get
            {
                if (_thanhToanRepository == null) {
                    _thanhToanRepository = new ThanhToanRepository(_repositoryContext);
                }
                return _thanhToanRepository;
            }
        }

        public QuyTrinhRepository QuyTrinh
        {
            get
            {
                if (_quyTrinhRepository == null) {
                    _quyTrinhRepository = new QuyTrinhRepository(_repositoryContext);
                }
                return _quyTrinhRepository;
            }
        }

        public CongViecRepository CongViec
        {
            get
            {
                if (_congViecRepository == null) {
                    _congViecRepository = new CongViecRepository(_repositoryContext);
                }
                return _congViecRepository;
            }
        }

        public async Task SaveChangeAsync()
        {
            await _repositoryContext.SaveChangesAsync();
        }

        public void SaveChange()
        {
            _repositoryContext.SaveChanges();
        }

        public void StartTransaction()
        {
            _repositoryContext.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            _repositoryContext.Database.CurrentTransaction.Commit();
        }

        public void RollbackTransaction()
        {
            _repositoryContext.Database.CurrentTransaction.Rollback();
        }
    }
}
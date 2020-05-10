using QLDA.Model;
using System.Data.Common;
using System.Data.Entity;

namespace QLDA.Context
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
        }

        public DbSet<KhachHang> KhachHangs { get; set; }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<DuAn> DuAns { get; set; }
        public DbSet<HopDong> HopDongs { get; set; }
        public DbSet<ThanhToan> Thanh_Toans { get; set; }
        public DbSet<QuyTrinh> QuyTrinhs { get; set; }
        public DbSet<CongViec> CongViecs { get; set; }
        public DbSet<TienTe> TienTes { get; set; }
        public DbSet<NhomDA> NhomDAs { get; set; }
        public DbSet<TaiKhoan> TaiKhoans { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer<RepositoryContext>(null);
        }
    }
}
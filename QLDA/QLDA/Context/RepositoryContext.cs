using QLDA.Model;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            Database.SetInitializer<RepositoryContext>(null);
        }
    }
}
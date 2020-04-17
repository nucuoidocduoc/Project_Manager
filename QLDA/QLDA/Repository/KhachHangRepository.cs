using QLDA.Context;
using QLDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Repository
{
    public class KhachHangRepository : RepositoryBase<KhachHang>
    {
        public KhachHangRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public override void Update(KhachHang entity)
        {
            throw new NotImplementedException();
        }
    }
}
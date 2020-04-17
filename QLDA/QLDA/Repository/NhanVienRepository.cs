using QLDA.Context;
using QLDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Repository
{
    public class NhanVienRepository : RepositoryBase<NhanVien>
    {
        public NhanVienRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public override void Update(NhanVien entity)
        {
            throw new NotImplementedException();
        }
    }
}
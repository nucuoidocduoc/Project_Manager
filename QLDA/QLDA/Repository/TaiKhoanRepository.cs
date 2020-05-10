using QLDA.Context;
using QLDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Repository
{
    public class TaiKhoanRepository : RepositoryBase<TaiKhoan>
    {
        public TaiKhoanRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public override void Update(TaiKhoan entity)
        {
            throw new NotImplementedException();
        }
    }
}
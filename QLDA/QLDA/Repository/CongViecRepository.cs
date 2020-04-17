using QLDA.Context;
using QLDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Repository
{
    public class CongViecRepository : RepositoryBase<CongViec>
    {
        public CongViecRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public override void Update(CongViec entity)
        {
            throw new NotImplementedException();
        }
    }
}
using QLDA.Context;
using QLDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Repository
{
    public class NhomDARepository : RepositoryBase<NhomDA>
    {
        public NhomDARepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public override void Update(NhomDA entity)
        {
            throw new NotImplementedException();
        }
    }
}
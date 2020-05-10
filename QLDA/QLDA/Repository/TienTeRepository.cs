using QLDA.Context;
using QLDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Repository
{
    public class TienTeRepository : RepositoryBase<TienTe>
    {
        public TienTeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public override void Update(TienTe entity)
        {
            throw new NotImplementedException();
        }
    }
}
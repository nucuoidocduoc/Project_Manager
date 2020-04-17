using QLDA.Context;
using QLDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Repository
{
    public class DuAnRepository : RepositoryBase<DuAn>
    {
        public DuAnRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public override void Update(DuAn entity)
        {
            throw new NotImplementedException();
        }
    }
}
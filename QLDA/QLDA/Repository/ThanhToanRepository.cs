using QLDA.Context;
using QLDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Repository
{
    public class ThanhToanRepository : RepositoryBase<ThanhToan>
    {
        public ThanhToanRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public override void Update(ThanhToan entity)
        {
            throw new NotImplementedException();
        }
    }
}
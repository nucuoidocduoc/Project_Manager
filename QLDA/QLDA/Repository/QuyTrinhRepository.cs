using QLDA.Context;
using QLDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Repository
{
    public class QuyTrinhRepository : RepositoryBase<QuyTrinh>
    {
        public QuyTrinhRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public override void Update(QuyTrinh entity)
        {
            throw new NotImplementedException();
        }
    }
}
﻿using QLDA.Context;
using QLDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Repository
{
    public class DangNhapRepository : RepositoryBase<DangNhap>
    {
        public DangNhapRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public override void Update(DangNhap entity)
        {
            throw new NotImplementedException();
        }
    }
}
﻿using QLDA.Context;
using QLDA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLDA.Repository
{
    public class HopDongRepository : RepositoryBase<HopDong>
    {
        public HopDongRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public override void Update(HopDong entity)
        {
            throw new NotImplementedException();
        }
    }
}
﻿//------------------------------------------------------------------------------
// This is auto-generated code.
//------------------------------------------------------------------------------
// This code was generated by Entity Developer tool using the template for generating Repositories and a Unit of Work for EF Core model.
// 4.4.0
//
// Changes to this file may cause incorrect behavior and will be lost if
// the code is regenerated.
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using System.Threading.Tasks;

namespace FS.Customers
{
    public partial class EfCorePersonRepository : 
        EfCoreRepository<FS.EntityFrameworkCore.IFSDbContext,FS.Customers.Person,Guid>,
        IPersonRepository
    {
        public EfCorePersonRepository(IDbContextProvider<FS.EntityFrameworkCore.IFSDbContext> dbContextProvider)
            : base(dbContextProvider) { }
    }
}

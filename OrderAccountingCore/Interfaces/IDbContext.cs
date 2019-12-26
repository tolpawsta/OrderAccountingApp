using System;
using System.Collections.Generic;
using System.Text;

namespace OrderAccountingCore.Interfaces
{
   public interface IDbContext
    {
        IGenericRepository<TEntity> Set<TEntity>();
    }
}

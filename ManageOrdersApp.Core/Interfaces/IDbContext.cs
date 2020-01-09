using ManageOrdersApp.Core.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ManageOrdersApp.Core.Interfaces
{
    public interface IDbContext<TEntity> where TEntity:Entity
    {
        DbSet<TEntity> Entities { get; set; }
    }
}

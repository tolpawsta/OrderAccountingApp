namespace ManageOrdersApp.Core.Interfaces
{
    public interface IDbContext
    {
        IGenericRepository<TEntity> Set<TEntity>();
    }
}

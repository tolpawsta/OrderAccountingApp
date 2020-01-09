using System.Collections.Generic;

namespace ManageOrdersApp.Core.Interfaces
{
    public interface IService<TTarget, TSource> where TSource : class
    where TTarget : class
    {
        TTarget Get(TSource Entity);
        IEnumerable<TTarget> Get(IEnumerable<TSource> Entities);
        IEnumerable<TTarget> GetAll();
        void Remove(TSource Entity);
        void Remove(IEnumerable<TSource> Entity);
        void Update(TSource Entity);
        void Add(TSource Entity);
        void Add(IEnumerable<TSource> Entity);
        void Delete(TSource Entity);
        void Delete(IEnumerable<TSource> Entity);
        void SaveChange();
        TSource Find(int id);

    }
}

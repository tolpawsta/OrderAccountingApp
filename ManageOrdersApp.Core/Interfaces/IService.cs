using System;
using System.Collections.Generic;

namespace ManageOrdersApp.Core.Interfaces
{
    public interface IService<TSource> where TSource : class
    {
        
        IEnumerable<TSource> GetAll();
        void Remove(TSource Entity);
       
        void Update(TSource Entity);
        void Create(TSource Entity);

        TSource GetById(int id);
        
        void SaveChange();
        

    }
}

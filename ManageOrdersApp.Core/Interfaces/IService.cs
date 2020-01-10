using System;
using System.Collections.Generic;

namespace ManageOrdersApp.Core.Interfaces
{
    public interface IService<TSource> where TSource : class
    {
        
        IEnumerable<TSource> GetAll();
        void Remove(TSource entity);
       
        void Update(TSource entity);
        void Create(TSource entity);
        bool Check(TSource entity);
        TSource GetById(int id);
        
        void SaveChange();
        

    }
}

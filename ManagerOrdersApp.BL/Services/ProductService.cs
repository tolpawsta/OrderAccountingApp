using AutoMapper;
using ManageOrdersApp.BLL.Models;
using ManageOrdersApp.Core.Interfaces;
using ManageOrdersApp.Entities;
using ManageOrdersApp.Repositories;
using System;
using System.Collections.Generic;

namespace ManagerOrdersApp.BLL.Services
{
    public class ProductService// : IService<ProductBL>
    {
        private ProductRepository _repo;
        private readonly IMapper _mapper;

        public ProductService(ProductRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }
        
        //public void SaveChange()
        //{
        //    _repo.SaveChanges();
        //}

       
        //public IEnumerable<ProductBL> GetAll()
        //{
        //    return _mapper.Map<IEnumerable<Product>,IEnumerable<ProductBL>>(_repo.All);
        //}

        //public void Remove(ProductBL productBl)
        //{
        //    Product product = _mapper.Map<Product>(productBl);
        //    _repo.Delete(product.Id);
        //}

        //public void Update(ProductBL productBl)
        //{
        //    _repo.Update(_mapper.Map<Product>(productBl));
        //}

        public void Create(ProductBL productBl)
        {
            _repo.Create(_mapper.Map<Product>(productBl));
        }

        //public ProductBL GetById(int id)
        //{
        //    return _mapper.Map<ProductBL>(_repo.Find(p=>p.Id==id));
        //}

        //public bool Check(ProductBL productBL)
        //{
        //    Product product = _mapper.Map<Product>(productBL);
        //    IEnumerable<Product> products = _repo.All;
           
        //    return true;
        //}
    }
}

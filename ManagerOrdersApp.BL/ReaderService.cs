using AutoMapper;
using ManageOrdersApp.BLL.Models;
using ManageOrdersApp.Core.Interfaces;
using ManageOrdersApp.Entities;
using ManageOrdersApp.Repositories;
using ManagerOrdersApp.BL.Impl;
using ManagerOrdersApp.BLL.MappingProfile;
using ManagerOrdersApp.BLL.Services;
using System.IO;

namespace ManagerOrdersApp.BLL
{
    public class ReaderService:IReaderService
    {
        private IFileReader _reader;
        private MapperConfiguration config;
        private IMapper _mapper;

        public ReaderService()
        {
            config = new MapperConfiguration(cfg => cfg.AddProfile(new ManagerMappingProfile()));
            _mapper = new Mapper(config);
        }

        public void Begin(string pathFile)
        {
            using (var reader =new StreamReader(pathFile))
            {
                ProductService productService = new ProductService(new ProductRepository(new ManagerContext()),_mapper);
                //IService<OrderBL> orderService = new ProductService(new Repository<Order>(new ManagerContext()),_mapper);
                //IService<ManagerBL> managerService = new ProductService(new Repository<Manager>(new ManagerContext()),_mapper);
                //IService<ReportBL> reportService = new ProductService(new Repository<Report>(new ManagerContext()),_mapper);
                //IService<CustomerBL> customService = new ProductService(new Repository<Customer>(new ManagerContext()),_mapper);
                CsvFileReader csvFileReader = new CsvFileReader(pathFile);
                csvFileReader.Dilimiter = ';';
                
                string record = string.Empty;
                while ((record=reader.ReadLine())!=null)
                {
                    csvFileReader.GetObject(record);
                   ProductBL product=csvFileReader.GetProduct();
                   
                        productService.Create(product);
                    
                }
            }
            

        }
    }
}

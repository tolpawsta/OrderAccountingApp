using AutoMapper;
using ManageOrdersApp.BLL.Models;
using ManageOrdersApp.DAL.Entities;


namespace ManagerOrdersApp.BLL.MappingProfile
{
    public class ManagerMappingProfile : Profile
    {
        public ManagerMappingProfile()
        {
            CreateMap<Product, ProductBL>();
            CreateMap<ProductBL, Product>();
            CreateMap<Manager, ManagerBL>();
            CreateMap<Customer, CustomerBL>();
            CreateMap<Order, OrderBL>();
            CreateMap<Report, ReportBL>();
        }

    }
}

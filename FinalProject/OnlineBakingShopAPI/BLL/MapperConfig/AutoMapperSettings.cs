using AutoMapper;
using BEL;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BLL.MapperConfig
{
    public class AutoMapperSettings : Profile
    {
        public AutoMapperSettings()
        {
            CreateMap<AdminModel, Admin>();
            CreateMap<Admin, AdminModel>();
            CreateMap<Courier, CourierDetail>();
            CreateMap<CourierModel, Courier>().ForMember(e => e.Details, sm => sm.Ignore());
            CreateMap<Courier, CourierModel>();
            CreateMap<CustomerModel, Customer>();
            CreateMap<Customer, CustomerModel>();
            CreateMap<DetailModel, Detail>().ForMember(e => e.Courier, sm => sm.Ignore())
                .ForMember(e => e.Transaction, sm => sm.Ignore());
            CreateMap<Detail, DetailModel>();
            CreateMap<LoginModel, Login>();
            CreateMap<Login, LoginModel>();
            CreateMap<Menu, MenuDetail>();
            CreateMap<MenuModel, Menu>().ForMember(e => e.Products, sm => sm.Ignore());
            CreateMap<Menu, MenuModel>();
            CreateMap<Product, ProductDetails>();
            CreateMap<ProductModel, Product>().ForMember(e => e.Type, sm => sm.Ignore())
                .ForMember(e => e.Menu, sm => sm.Ignore())
                .ForMember(e => e.Transactions, sm => sm.Ignore());
            CreateMap<Product, ProductModel>();
            CreateMap<Transaction, TransactionDetail>();
            CreateMap<TransactionModel, Transaction>().ForMember(e => e.Details, sm => sm.Ignore())
                .ForMember(e => e.Product, sm => sm.Ignore());
            CreateMap<Transaction, TransactionModel>();
            CreateMap<DAL.Type, TypeDetail>();
            CreateMap<TypeModel, DAL.Type>().ForMember(e => e.Products, sm => sm.Ignore());
            CreateMap<DAL.Type, TypeModel>();
        }
    }
}
using AutoMapper;
using CaseProject.DtoLayer.Dtos.Customer;
using CaseProject.DtoLayer.Dtos.Order;
using CaseProject.DtoLayer.Dtos.Supplier;
using CaseProject.EntityLayer.Concrete;

namespace CaseProject.API.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CreateCustomerDto,Customer>().ReverseMap();
            CreateMap<UpdateCustomerDto,Customer>().ReverseMap();
            CreateMap<ResultCustomerDto,Customer>().ReverseMap();

            CreateMap<CreateSupplierDto, Supplier>().ReverseMap();
            CreateMap<UpdateSupplierDto, Supplier>().ReverseMap();
            CreateMap<ResultSupplierDto, Supplier>().ReverseMap();

            CreateMap<CreateOrderDto, Order>().ReverseMap();
            CreateMap<UpdateOrderDto, Order>().ReverseMap();
            CreateMap<ResultOrderDto, Order>().ReverseMap();
        }
    }
}

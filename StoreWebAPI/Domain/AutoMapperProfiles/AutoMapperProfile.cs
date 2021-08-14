using AutoMapper;
using DataAccesLayer.Entities;
using Domain.Dtos;
using System.Collections.Generic;

namespace Domain.AutoMapperProfiles
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Order, OrderReadDto>();
            CreateMap<OrderCreateDto, Order>();
            CreateMap<OrderUpdateDto, Order>();
            CreateMap<Product, ProductReadDto>();
            CreateMap<Product, IEnumerable<ProductReadDto>>();
        }
    }
}

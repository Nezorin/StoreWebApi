using AutoMapper;
using DataAccesLayer;
using DataAccesLayer.Entities;
using Domain.Dtos;
using System.Collections.Generic;

namespace Domain.Services
{
    public class ProductService : IProductService
    {
        private readonly IDbRepository _dbRepository;
        private readonly IMapper _mapper;

        public ProductService(IDbRepository dbRepository, IMapper mapper)
        {
            _dbRepository = dbRepository;
            _mapper = mapper;
        }

        public IEnumerable<ProductReadDto> Get()
        {
            var products = _dbRepository.Get<Product>();
            var result = _mapper.Map<IEnumerable<ProductReadDto>>(products);
            return result;
        }
    }
}

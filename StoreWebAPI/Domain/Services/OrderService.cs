using AutoMapper;
using DataAccesLayer;
using DataAccesLayer.Entities;
using Domain.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class OrderService : IOrderService
    {
        private readonly IDbRepository _dbRepository;
        private readonly IMapper _mapper;

        public OrderService(IDbRepository context, IMapper mapper)
        {
            _dbRepository = context;
            _mapper = mapper;
        }

        public async Task<OrderReadDto> Create(OrderCreateDto orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);
            order.DateCreated = DateTime.Now;

            await _dbRepository.Add(order);
            await _dbRepository.SaveChangesAsync();

            var orderReadDto = _mapper.Map<OrderReadDto>(order);
            return orderReadDto;
        }
        public IEnumerable<OrderReadDto> Get()
        {
            var orders = _dbRepository.Get<Order>().Include(order => order.Product);
            var result = _mapper.Map<IEnumerable<OrderReadDto>>(orders);
            return result;
        }
        public async Task<Guid> Update(OrderUpdateDto orderDto)
        {
            var order = _mapper.Map<Order>(orderDto);
            order.DateUpdated = DateTime.Now;

            await _dbRepository.Update(order);
            await _dbRepository.SaveChangesAsync();
            return order.Id;
        }
        public async Task Delete(Guid orderId)
        {
            var entity = _dbRepository.Get<Order>().FirstOrDefault(order => order.Id == orderId);
            await _dbRepository.Delete(entity);
            await _dbRepository.SaveChangesAsync();
        }
    }
}


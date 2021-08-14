using Domain.Dtos;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Services
{
    public interface IOrderService
    {
        Task<OrderReadDto> Create(OrderCreateDto order);
        IEnumerable<OrderReadDto> Get();
        Task<Guid> Update(OrderUpdateDto order);
        Task Delete(Guid orderId);
    }
}

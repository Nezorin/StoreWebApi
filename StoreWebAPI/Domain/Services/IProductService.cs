using Domain.Dtos;
using System.Collections.Generic;

namespace Domain.Services
{
    public interface IProductService
    {
        IEnumerable<ProductReadDto> Get();
    }
}

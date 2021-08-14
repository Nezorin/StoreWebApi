using System;

namespace Domain.Dtos
{
    public class OrderUpdateDto
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
    }
}

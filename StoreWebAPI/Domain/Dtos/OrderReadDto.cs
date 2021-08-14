using DataAccesLayer.Entities;
using System;

namespace Domain.Dtos
{
    public class OrderReadDto
    {
        public Guid Id { get; set; }
        public Product Product { get; set; }
        public DateTime DateCreated { get; set; }
    }
}

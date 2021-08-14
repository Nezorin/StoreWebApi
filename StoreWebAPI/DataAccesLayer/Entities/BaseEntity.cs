using System;
using System.ComponentModel.DataAnnotations;

namespace DataAccesLayer.Entities
{
    public class BaseEntity : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.Now;
        public DateTime? DateUpdated { get; set; }
    }
}

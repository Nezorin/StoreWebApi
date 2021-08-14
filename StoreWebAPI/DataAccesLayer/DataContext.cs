using DataAccesLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccesLayer
{
    public class DataContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DataContext()
        {

        }
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Product>().HasData(new Product[]{
                new Product
                {
                    Id = System.Guid.NewGuid(),
                    Name = "Шахматная доска",
                    Price = 2000
                },
                new Product
                {
                    Id = System.Guid.NewGuid(),
                    Name = "Набор шахматных фигур",
                    Price = 750

                },new Product
                {
                    Id = System.Guid.NewGuid(),
                    Name = "Часы",
                    Price = 500
                },
            });
        }
    }
}

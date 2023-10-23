using Microsoft.EntityFrameworkCore;
using OnionApp.Domain.Entities;

namespace OnionApp.Persistence.Context
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Product> Products { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "Ps 5",
                    Value = 25000,
                    Quantity = 5
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "X Box Series X",
                    Value = 20000,
                    Quantity = 5
                },
                new Product()
                {
                    Id = Guid.NewGuid(),
                    Name = "X Box Series S",
                    Value = 15000,
                    Quantity = 5
                }
                );
            base.OnModelCreating(modelBuilder);
        }
    }
}

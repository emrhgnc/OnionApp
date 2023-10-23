using OnionApp.Application.Interfaces.Repository;
using OnionApp.Domain.Entities;
using OnionApp.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionApp.Persistence.Repostories
{
    public class ProductRepository:GenericRepository<Product>, IProductRepository
    {
        public ProductRepository(ApplicationDbContext dbContext):base(dbContext)
        {
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Abstractions;
using Domain.Entities;

namespace Persistence.Concretes
{
    public class ProductService : IProductService
    {
        public List<Product> GetProducts() 
            => new List<Product>
            {
                new Product { Id = Guid.NewGuid(), Name = "Product 1", Stock = 10, Price = 100, CreatedDate = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Product 2", Stock = 5, Price = 200, CreatedDate = DateTime.UtcNow },
                new Product { Id = Guid.NewGuid(), Name = "Product 3", Stock = 8, Price = 150, CreatedDate = DateTime.UtcNow }
            };
        
    }
}
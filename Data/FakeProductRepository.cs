using System.Collections.Generic;
using System.Linq;
using WebShop.Models;

namespace WebShop.Data
{
    public class FakeProductRepository : IProductRepository
    {
        public IQueryable<Product> Products => new List<Product>{
            new Product { Name = "Mountain Bike", Price = 1000 },
            new Product { Name = "Wakeboard", Price = 999},
            new Product { Name = "Volleyball ball", Price = 50}
        }.AsQueryable<Product>();
    }
}
using System.Linq;
using WebShop.Models;

namespace WebShop.Data
{
    public class EFProductRepository : IProductRepository
    {
        private AppDbContext _context;

        public EFProductRepository(AppDbContext context) =>
            _context = context;
        public IQueryable<Product> Products => 
            _context.Products;

    }
}
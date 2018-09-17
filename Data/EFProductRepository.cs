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

        public Product DeleteProduct(int Id)
        {
            Product dbEntry = _context.Products.FirstOrDefault(p => p.Id == Id);
            if(dbEntry != null){
                _context.Products.Remove(dbEntry);
                _context.SaveChanges();
            }
            return dbEntry;
        }

        public void SaveProduct(Product product)
        {
            if(product.Id == 0){
                _context.Products.Add(product);
            } else {
                Product dbEntry = _context.Products.FirstOrDefault(p => p.Id == product.Id);
                if(dbEntry != null)
                {
                    dbEntry.Name = product.Name;
                    dbEntry.Description = product.Description;
                    dbEntry.Price = product.Price;
                    dbEntry.Category = product.Category;
                }
            }
            _context.SaveChanges();
        }
    }
}
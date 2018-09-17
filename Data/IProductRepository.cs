using System.Linq;
using WebShop.Models;

namespace WebShop.Data
{
    public interface IProductRepository
    {
        IQueryable<Product> Products { get; }
        void SaveProduct(Product product);
        Product DeleteProduct(int Id);
    }
}
using Microsoft.AspNetCore.Mvc;
using WebShop.Data;

namespace WebShop.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public ProductController(IProductRepository repo) => 
            repository = repo;

        public ViewResult ProductsList() =>
            View(repository.Products);

        public string Message() => "Witaj swiecie";
    }
}
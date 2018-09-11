using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebShop.Data;
using WebShop.Models.ViewModels;

namespace WebShop.Controllers
{
    public class ProductController : Controller
    {
        private IProductRepository repository;
        public ProductController(IProductRepository repo) => 
            repository = repo;

        int pageSize = 4;

        public ViewResult ProductsList(int page = 1) =>
            View(new ProductsListViewModel 
            {
                Products = repository.Products
                    .OrderBy(p => p.Id)
                    .Skip((page-1)*pageSize)
                    .Take(pageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = page,
                    ItemsPerPage = pageSize,
                    TotalItems = repository.Products.Count()
                }
            });
        public string Message() => "Witaj swiecie";
    }
}
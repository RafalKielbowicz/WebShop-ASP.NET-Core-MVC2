using System.Linq;
using Microsoft.AspNetCore.Mvc;
using WebShop.Data;
using WebShop.Models;

namespace WebShop.Controllers
{
    public class AdminController : Controller
    {
        private IProductRepository repository;
        public AdminController(IProductRepository repo)
        {
            repository = repo;    
        }

        public ViewResult Index() => 
            View(repository.Products);

        public ViewResult Edit(int Id) =>
            View(repository.Products.FirstOrDefault(p => p.Id == Id));

        [HttpPost]
        public IActionResult Edit(Product product)
        {
            if(ModelState.IsValid)
            {
                repository.SaveProduct(product);
                TempData["message"] = $"Zapisano {product.Name}";
                return RedirectToAction("Index");
            } else {
                return View(product);
            }
        }

        public ViewResult Create()
        {
             return View("Edit", new Product());
        }

        [HttpPost]
        public IActionResult Delete(int Id)
        {
            Product delProduct = repository.DeleteProduct(Id);
            if(delProduct != null)
            {
                TempData["message"] = $"Usunięto {delProduct.Name}.";
            }
            return RedirectToAction("Index");
        }
    }
}
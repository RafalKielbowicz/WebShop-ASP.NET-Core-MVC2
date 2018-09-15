using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebShop.Data;
using WebShop.Infrastructure;
using WebShop.Models;
using WebShop.Models.ViewModels;

namespace WebShop.Controllers
{
    public class CartController : Controller
    {
        private IProductRepository repository;
        private Cart cart;

        public CartController(IProductRepository repo, Cart cartService)
        {
            repository = repo;
            cart = cartService;
        }

        public RedirectToActionResult AddToCart(int Id, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(p => p.Id == Id);

            if(product != null)
            {
                cart.AddItem(product,1);    
            }

            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int Id, string returnUrl)
        {
            Product product = repository.Products.FirstOrDefault(p => p.Id == Id);

            if(product != null)
            {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }
    }
}
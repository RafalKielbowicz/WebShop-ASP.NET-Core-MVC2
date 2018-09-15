using Microsoft.AspNetCore.Mvc;

namespace WebShop.Controllers
{
    public class HomeController : Controller
    {
        public string Index() =>
            "Hello World";
    }
}
using System;
using trefle888.Models;

namespace trefle888.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Shop()
        {
            var products = new List<Product>
            {
                new Product(1,"REGULAR FIT TRAVELER BLAZER", 6599, "/resources/suit1.jpg"),
                new Product(2,"REGULAR FIT PREMIUM WOOL DOUBLE BREASTED BLAZER", 9740, "/resources/suit2.jpg"),
                new Product(3,"REGULAR FIT PREMIUM WOOL BLAZER", 8250, "/resources/suit3.jpg")
            };


            return View(products);
        }
    }
}


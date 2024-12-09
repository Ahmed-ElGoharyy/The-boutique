using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using trefle888.Data;
using trefle888.Models;

namespace trefle888.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductContext _context;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ProductContext context, ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

       

      

        public IActionResult Index()
        {
            return View();
        }

       
        public IActionResult AboutUs()
        {
            return View();
        }

        public async Task<IActionResult> Shop()
        {
            var products = await _context.Product.ToListAsync();
            return View(products);
        }

        public IActionResult MyAccount()
        {
            return View();
        }

        public IActionResult Cart()
        {
            return View();    

        }

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult admin()
        {
            return RedirectToAction("admin");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

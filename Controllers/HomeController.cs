using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using trefle888.Data;
using trefle888.Migrations.User;
using trefle888.Models;

namespace trefle888.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductContext _context;
        private readonly UserContext _Ucontext;

        private readonly ILogger<HomeController> _logger;

        public HomeController(ProductContext context, ILogger<HomeController> logger, UserContext ucontext)
        {
            _context = context;
            _logger = logger;
            _Ucontext = ucontext;
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
        


        [HttpPost]
        public async Task<IActionResult> LoginLogic(string Username, string Password)
        {
            var user = await _Ucontext.Users
             .FirstOrDefaultAsync(u => u.username == Username && u.password == Password);

            if (user != null)
            {
                // Successful login
                TempData["SuccessMessage"] = user.username;

                TempData.Keep();

                return RedirectToAction("Index", "Home");
            }
            else

            {
                // Login failed
                TempData["ErrorMessage"] = "Invalid username or password !";
                return RedirectToAction("Login", "Home"); // Redirect to login page
            }

        }



        [HttpPost]
        public async Task<IActionResult> SignUpLogic(string Username, string Password)
        {
            var userr = await _Ucontext.Users
             .FirstOrDefaultAsync(u => u.username == Username );

            if (userr != null)
            {
                // SignUp failed
                TempData["SignUpFailed"] = "Username already exists!";

                TempData.Keep();
                return RedirectToAction("Login", "Home"); // Redirect to login page
            }
            else

            {
                // SignUp success
                TempData["SignUpSuccess"] = "Sign Up Successful!, Please Login";

                var newUser = new Users(Username, Password);
               

                _Ucontext.Users.Add(newUser);
                _Ucontext.SaveChanges();
                return RedirectToAction("Login", "Home"); // Redirect to login page
            }

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

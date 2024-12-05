using trefle888.Data;
using trefle888.Models;

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using trefle888.Data;
using trefle888.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace trefle888.Pages
{
    public class ProductsModel : PageModel
    {
        private readonly ProductContext _context;

        public ProductsModel(ProductContext context)
        {
            _context = context;
        }

        public List<Product> Product { get; set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}


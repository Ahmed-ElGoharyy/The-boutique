using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using trefle888.Data;
using trefle888.Models;

namespace trefle888
{
    public class IndexModel : PageModel
    {
        private readonly trefle888.Data.ProductContext _context;

        public IndexModel(trefle888.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Product = await _context.Product.ToListAsync();
        }
    }
}

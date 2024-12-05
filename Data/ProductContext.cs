using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using trefle888.Models;

namespace trefle888.Data
{
    public class ProductContext : DbContext
    {
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { id = 1, Name = "REGULAR FIT TRAVELER BLAZER", Price = 6599, Image = "resources/suit1.jpg" },
                new Product { id = 2, Name = "REGULAR FIT PREMIUM WOOL DOUBLE BREASTED BLAZER", Price = 9740, Image = "resources/suit2.jpg" },
                new Product { id = 3, Name = "REGULAR FIT PREMIUM WOOL BLAZER", Price = 8250, Image = "resources/suit3.jpg" },
                new Product { id = 4, Name = "SLIM FIT TRAVELER BlAZER", Price = 5250, Image = "~/resources/suit4.jpg" },
                new Product { id = 5, Name = "CEREMONIAL SMART FIT SUIT", Price = 9722, Image = "~/reources/suit5.jpg"},
                new Product { id = 6, Name = "SLIM FIT 100% PREMIUM WOOL BLAZER", Price = 10000, Image = "~/reources/suit6.jpg" }
            );
        }

        public DbSet<trefle888.Models.Product> Product { get; set; } = default!;

    }
}

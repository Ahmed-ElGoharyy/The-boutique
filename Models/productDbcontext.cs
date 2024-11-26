using System;
namespace trefle888.Models
{
    public class ProductDbcontext : Dbcontext
    {
        public ProductDbcontext() : base("productConnectionString")
        {

        }
        public Dbset<Product> products { get; set; }

    }
}


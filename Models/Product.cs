using System;
namespace trefle888.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.identity)]
        public int id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

    }
} 



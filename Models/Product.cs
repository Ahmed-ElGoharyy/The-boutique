using System;
namespace trefle888.Models
{
    public class Product
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }

        public string Category { get; set; }

        public int[] sizes { get; set; }



    }
} 



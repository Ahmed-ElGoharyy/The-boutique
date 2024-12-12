namespace trefle888.Models
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public int Size { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public double ProductPrice { get; set; }
        public int Quantity { get; set; }
    }
}
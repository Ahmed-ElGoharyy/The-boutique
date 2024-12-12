using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using trefle888.Data;
using trefle888.Models;
using trefle888.Extensions;

namespace trefle888.Controllers
{
    public class CartController : Controller
    {
        private readonly ProductContext _context;
        public CartController(ProductContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? productId, int? size)
        {
            // If productId and size are provided in query parameters, add to cart first
            if (productId.HasValue && size.HasValue)
            {
                var product = _context.Product?.Find(productId.Value);
                if (product != null)
                {
                    List<CartItem> cartItems = GetCartItems();
                    var existingItem = cartItems.FirstOrDefault(item =>
                        item.ProductId == productId.Value && item.Size == size.Value);

                    if (existingItem != null)
                    {
                        existingItem.Quantity++;
                    }
                    else
                    {
                        cartItems.Add(new CartItem
                        {
                            ProductId = productId.Value,
                            Size = size.Value,
                            ProductName = product.Name ?? "Unknown",
                            ProductPrice = product.Price,
                            Quantity = 1
                        });
                    }
                    SetCartItems(cartItems);
                }
            }

            List<CartItem> items = GetCartItems();
            return View("~/Views/Home/Cart.cshtml", items);
        }

        [HttpPost]
        public IActionResult AddToCart(int productId, int size)
        {
            var product = _context.Product?.Find(productId);
            if (product == null)
            {
                return NotFound("Product not found.");
            }

            List<CartItem> cartItems = GetCartItems();
            var existingItem = cartItems.FirstOrDefault(item =>
                item.ProductId == productId && item.Size == size);

            if (existingItem != null)
            {
                existingItem.Quantity++;
            }
            else
            {
                cartItems.Add(new CartItem
                {
                    ProductId = productId,
                    Size = size,
                    ProductName = product.Name ?? "Unknown",
                    ProductPrice = product.Price,
                    Quantity = 1
                });
            }

            SetCartItems(cartItems);
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult UpdateQuantity(int productId, int size, int quantity)
        {
            var cartItems = GetCartItems();
            var item = cartItems.FirstOrDefault(x => x.ProductId == productId && x.Size == size);
            if (item != null)
            {
                item.Quantity = quantity;
            }
            SetCartItems(cartItems);
            return Json(new { success = true });
        }

        [HttpPost]
        public IActionResult RemoveFromCart(int productId, int size)
        {
            var cartItems = GetCartItems();
            cartItems.RemoveAll(x => x.ProductId == productId && x.Size == size);
            SetCartItems(cartItems);
            return Json(new { success = true });
        }

        private List<CartItem> GetCartItems()
        {
            var cartItems = HttpContext.Session.GetObjectFromJson<List<CartItem>>("CartItems");
            return cartItems ?? new List<CartItem>();
        }

        private void SetCartItems(List<CartItem> cartItems)
        {
            HttpContext.Session.SetObjectAsJson("CartItems", cartItems);
        }
    }
}
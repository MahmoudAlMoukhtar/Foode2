using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BethanysPieShop.Models
{
    public class CartItemsRepository : ICartItemsRepository
    {
        private readonly ProductsShopDbContext _productsShopDbContext;

        public string? CartId { get; set; }

        public List<CartItem> AllCartItems { get; set; } = default!;

        private CartItemsRepository(ProductsShopDbContext productsShopDbContext)
        {
            _productsShopDbContext = productsShopDbContext;
        }

        public static CartItemsRepository GetCart(IServiceProvider services)
        {
            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;

            ProductsShopDbContext context = services.GetService<ProductsShopDbContext>() ?? throw new Exception("Error initializing");

            string cartId = session?.GetString("CartId") ?? Guid.NewGuid().ToString();

            session?.SetString("CartId", cartId);

            return new CartItemsRepository(context) { CartId = cartId };
        }

        public void AddToCart(Product product)
        {
            var shoppingCartItem =
                    _productsShopDbContext.CartItems.SingleOrDefault(
                        s => s.Product.PieId == product.PieId && s.CartId == CartId);

            if (shoppingCartItem == null)
            {
                shoppingCartItem = new CartItem
                {
                    CartId = CartId,
                    Product = product,
                    Quantity = 1
                };

                _productsShopDbContext.CartItems.Add(shoppingCartItem);
            }
            else
            {
                shoppingCartItem.Quantity++;
            }
            _productsShopDbContext.SaveChanges();
        }

        public int RemoveFromCart(Product pie)
        {
            var shoppingCartItem =
                    _productsShopDbContext.CartItems.SingleOrDefault(
                        s => s.Product.PieId == pie.PieId && s.CartId == CartId);

            var localAmount = 0;

            if (shoppingCartItem != null)
            {
                if (shoppingCartItem.Quantity > 1)
                {
                    shoppingCartItem.Quantity--;
                    localAmount = shoppingCartItem.Quantity;
                }
                else
                {
                    _productsShopDbContext.CartItems.Remove(shoppingCartItem);
                }
            }

            _productsShopDbContext.SaveChanges();

            return localAmount;
        }

        public List<CartItem> GetCartItems()
        {
            return AllCartItems ??=
                       _productsShopDbContext.CartItems.Where(c => c.CartId == CartId)
                           .Include(s => s.Product)
                           .ToList();
        }

        public void ClearCart()
        {
            var cartItems = _productsShopDbContext
                .CartItems
                .Where(cart => cart.CartId == CartId);

            _productsShopDbContext.CartItems.RemoveRange(cartItems);

            _productsShopDbContext.SaveChanges();
        }

        public decimal GetCartTotal()
        {
            var total = _productsShopDbContext.CartItems.Where(c => c.CartId == CartId)
                .Select(c => c.Product.Price * c.Quantity).Sum();
            return total;
        }
    }
}

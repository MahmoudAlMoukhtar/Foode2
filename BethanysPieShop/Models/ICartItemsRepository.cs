using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BethanysPieShop.Models
{
    public interface ICartItemsRepository
    {
        
        void AddToCart(Product product);
        int RemoveFromCart(Product product);
        List<CartItem> GetCartItems();
        void ClearCart();
        decimal GetCartTotal();
        List<CartItem> AllCartItems { get; set; }

    }
}

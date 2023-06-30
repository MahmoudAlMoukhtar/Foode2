using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BethanysPieShop.ViewModels
{
    public class CartViewModel
    {
        public CartViewModel(ICartItemsRepository cartItems, decimal cartTotal)
        {
            CartItemsRepository = cartItems;
            CartTotal = cartTotal;
        }

        public ICartItemsRepository CartItemsRepository { get; }
        public decimal CartTotal { get; }

    }
}
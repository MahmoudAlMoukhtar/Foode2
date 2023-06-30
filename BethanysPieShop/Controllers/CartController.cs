using System;
using System.Linq;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers
{
    public class CartController : Controller
    {
        private readonly ICartItemsRepository _cartItemsRepository;
        private readonly IProductRepository _productRepository;

        public CartController(ICartItemsRepository cartItemsRepository, IProductRepository productRepository)
        {
            _cartItemsRepository = cartItemsRepository;
            _productRepository = productRepository;
        }

        public IActionResult Index()
        {
            var items = _cartItemsRepository.GetCartItems();
            _cartItemsRepository.AllCartItems= items;
            var CartViewModel = new CartViewModel(_cartItemsRepository, _cartItemsRepository.GetCartTotal());
            //var cartItems = _cartItemsRepository.AllCartItems;
            return View(CartViewModel);
        }

        public IActionResult AddToCart(int id)
        {
            var selectedProduct = _productRepository.AllProducts.FirstOrDefault(p => p.PieId == id);
            if (selectedProduct != null)
            {
                _cartItemsRepository.AddToCart(selectedProduct);
                TempData["Message"] = $"{selectedProduct.Name} has been added to the cart.";
            }

            return RedirectToAction("Index");
        }
        public IActionResult RemoveFromCart(int id)
        {
            var selectedProduct = _productRepository.AllProducts.FirstOrDefault(p => p.PieId == id);
            if (selectedProduct != null)
            {
                _cartItemsRepository.RemoveFromCart(selectedProduct);
                TempData["Message"] = $"{selectedProduct.Name} has been remove from the cart.";
            }

            return RedirectToAction("Index");
        }

        public IActionResult Checkout()
        {
            
              _cartItemsRepository.ClearCart();


            return RedirectToAction("", "thanks", new { area = "" });
        }
    }
}
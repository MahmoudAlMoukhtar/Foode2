using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace BethanysPieShop.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly IProductRepository _pieRepository;

        public CheckoutController(IProductRepository productRepository)
        {
            _pieRepository = productRepository;
        }
        public IActionResult Index()
        {
            PieListViewModel piesListViewModel = new PieListViewModel(_pieRepository.AllProducts, "Cheese cakes");
            return View(piesListViewModel);

        }

    }
}
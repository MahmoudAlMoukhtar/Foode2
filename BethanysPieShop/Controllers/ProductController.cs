using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace BethanysPieShop.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;

        public ProductController(IProductRepository pieRepository,ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;
        }

        public IActionResult List()
        {
            //return View(_pieRepository.AllPies);
            PieListViewModel piesListViewModel = new PieListViewModel (_pieRepository.AllProducts, "Cheese cakes");
            return View(piesListViewModel);

        }

        public IActionResult Detail(int id)
        {
            var product = _pieRepository.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }
    }
}
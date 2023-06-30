using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
namespace BethanysPieShop.Controllers
{
    public class ThanksController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

    }
}
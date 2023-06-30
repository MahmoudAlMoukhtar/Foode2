using BethanysPieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace BethanysPieShop.ViewModels
{
    public class PieListViewModel 
    {
       public IEnumerable<Product> Pies { get; }
        public string? CurrentCategory { get; }
        public PieListViewModel(IEnumerable<Product> pies, string? currentCategory)
        {
            Pies = pies;
            CurrentCategory = currentCategory;
        }

    }
}
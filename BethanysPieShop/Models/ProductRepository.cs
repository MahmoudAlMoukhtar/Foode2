using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BethanysPieShop.Models
{
    public class ProductRepository : IProductRepository
    {
        private readonly ProductsShopDbContext _productsShopDbContext;

        public ProductRepository(ProductsShopDbContext productsShopDbContext)
        {
            _productsShopDbContext = productsShopDbContext;
        }

        public IEnumerable<Product> AllProducts
        { 
            get 
            {
                return _productsShopDbContext.Products.Include(c => c.Category);
            } 
        }
        public IEnumerable<Product> ProductsOfTheWeek
        { get {
                return _productsShopDbContext.Products.Include(c => c.Category).Where(p=>p.IsPieOfTheWeek);
            } }
        public Product? GetProductById(int pieId)
        {
            return _productsShopDbContext.Products.FirstOrDefault(p => p.PieId == pieId);
        }
        
    }
}

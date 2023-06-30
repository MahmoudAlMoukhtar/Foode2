using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BethanysPieShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ProductsShopDbContext _productsShopDbContext;

        public CategoryRepository(ProductsShopDbContext productsPieShopDbContext)
        {
            _productsShopDbContext = productsPieShopDbContext;
        }

        public IEnumerable<Category> AllCategories =>
            _productsShopDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}

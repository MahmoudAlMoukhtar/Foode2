using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BethanysPieShop.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }
    }
}

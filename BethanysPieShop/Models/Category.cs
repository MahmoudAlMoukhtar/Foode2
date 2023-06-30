﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BethanysPieShop.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public string? Description { get; set; }
        public List<Product>? Pies { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Data;
using Test1.Models;

namespace Test1.Services
{
    public class ProductCategoryService
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ProductCategory> GetSelectList()
        {
            return _context.ProductCategories.ToList();
        }
    }
}


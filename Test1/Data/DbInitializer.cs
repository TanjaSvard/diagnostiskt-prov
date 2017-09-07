using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Test1.Models;

namespace Test1.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {


            if (!context.Products.Any())
            {
                var tv = new ProductCategory { Name = "TV"};
                var dvd = new ProductCategory { Name = "DVD"};
                var vhs = new ProductCategory { Name = "VHS"};

                context.ProductCategories.AddRange(tv, dvd, vhs);
                context.SaveChanges();
            }
            }
        }
}

using Shopping.Domain.Abstracts;
using Shopping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Concetre
{
    public class MainRepository : IMainRepository
    {
        private DemoContext context = new DemoContext();
        public IQueryable<Category> Categories => context.Categories;
        public IQueryable<Product> Products => context.Products;
    }
}

using Shopping.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Domain.Abstracts
{
    public interface IMainRepository
    {
        IQueryable<Product> Products { get; }
        IQueryable<Category> Categories { get; }
    }
}

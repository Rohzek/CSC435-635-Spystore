using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    public interface ICategoryRepository : IRepository<Cateogry>
    {
        IEnumerable<Category> GetAllWithProducts();
        Category GetOneWithProducts(int? id);
    }
}

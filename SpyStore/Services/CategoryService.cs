using System;

namespace Services
{
    public class CategoryService
    {
        private IRepository<Category> _Repository;

        public CategoryService()
        {
            _Repository = new CategoryRepository(new DbContetOptions<StoreContext>());
        }
    }
}

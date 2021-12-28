using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UseCases.DataStorePluginInterfaces
{
    public abstract class ICategoryRepository
    {
        public abstract IEnumerable<Category> GetCategories();
        public abstract void AddCategory(Category category);
        public abstract void UpdateCategory(Category category);
        public abstract Category GetCategoryById(int categoryId);
        public abstract void DeleteCategory(int categoryId);
    }
}

using CoreBusiness;
using System;
using System.Collections.Generic;
using System.Linq;
using UseCases.DataStorePluginInterfaces;

namespace Plugins.DataStore.InMemory
{
    public class CategoryInMemoryRepository : ICategoryRepository
    {
        private List<Category> categories;
        public CategoryInMemoryRepository()
        {
            // Add some new categories

            this.categories = new List<Category>()
            {
                new Category { CategoryId = 1, Name = "Beverage", Description = "Beverage"},
                new Category { CategoryId = 2, Name = "Bakery", Description = "Bakery"},
                new Category { CategoryId = 3, Name = "Meat", Description = "Meat" },

            };
        }

        public override void AddCategory(Category category)
        {
            if(this.categories.Any(x => x.Name.Equals(category.Name, StringComparison.OrdinalIgnoreCase)))
            {
                return;
            }
            else if(categories != null && categories.Count > 0)
            {
                var maxId = categories.Max(x => x.CategoryId);
                category.CategoryId = maxId + 1;
            }
            else
            {
                category.CategoryId = 1;
            }
            this.categories.Add(category);
        }

        public override void DeleteCategory(int categoryId)
        {
            categories.Remove(GetCategoryById(categoryId));
        }

        public override IEnumerable<Category> GetCategories()
        {
            return categories;
        }

        public override Category GetCategoryById(int categoryId)
        {
            return categories.FirstOrDefault(x => x.CategoryId == categoryId);
        }

        public override void UpdateCategory(Category category)
        {
            var categoryToUpdate = categories.FirstOrDefault(x => x.CategoryId == category.CategoryId);
            if(categoryToUpdate != null)
            {
                categoryToUpdate = category;
            }
        }
    }
}

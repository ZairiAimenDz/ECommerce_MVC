using ECommerce_MVC.Dtos.Category;
using ECommerce_MVC.Wrappers;
using Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce_MVC.Interfaces
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<Category>> GetCategoryList();
        Task<Category> GetCategoryAsync(Guid categid);
        Category GetCategory(Guid categid);
        void AddCategory(Category category);
        Task AddCategoryAsync(Category category);
        void UpdateCategory(Category category);
        void DeleteCategory(Category category);
        bool Save();
        Task<bool> SaveAsync();
    }
}

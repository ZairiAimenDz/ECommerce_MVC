using ECommerce_MVC.Dtos.Brand;
using ECommerce_MVC.Dtos.Category;
using ECommerce_MVC.Interfaces;
using ECommerce_MVC.Wrappers;
using Models;
using ECommerce_MVC.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_MVC.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddCategory(Category category)
        {
            _context.Categories.Add(category);
        }

        public async Task AddCategoryAsync(Category category)
        {
            await _context.Categories.AddAsync(category);
        }

        public void DeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
        }

        public Category GetCategory(Guid categid)
        {
            return _context.Categories.FirstOrDefault(c => c.Id == categid);
        }

        public Task<Category> GetCategoryAsync(Guid categid)
        {
            return _context.Categories.FirstOrDefaultAsync(c => c.Id == categid);
        }

        public async Task<IEnumerable<Category>> GetCategoryList()
        {
            var collection = _context.Categories.OrderBy(c => c.Name) as IQueryable<Category>;

            return await collection.ToListAsync();
        }

        public bool Save()
        {
            return _context.SaveChanges() > 0;
        }

        public async Task<bool> SaveAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }

        public void UpdateCategory(Category category)
        {
            _context.Categories.Update(category);
        }
    }
}
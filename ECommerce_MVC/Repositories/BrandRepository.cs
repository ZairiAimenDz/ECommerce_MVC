using ECommerce_MVC.Dtos.Brand;
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
    public class BrandRepository : IBrandRepository
    {
        private readonly ApplicationDbContext _context;

        public BrandRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public void AddBrand(Brand brand)
        {
            _context.Brands.Add(brand);
        }

        public async Task AddBrandAsync(Brand brand)
        {
            await _context.Brands.AddAsync(brand);
        }

        public void DeleteBrand(Brand brand)
        {
            _context.Brands.Remove(brand);
        }

        public Brand GetBrand(Guid? brandid)
        {
            return _context.Brands.FirstOrDefault(b=>b.Id == brandid);
        }

        public Task<Brand> GetBrandAsync(Guid? brandid)
        {
            return _context.Brands.FirstOrDefaultAsync(b=>b.Id == brandid);
        }

        public async Task<IEnumerable<Brand>> GetBrandsList()
        {
            var collection = _context.Brands.OrderBy(b=>b.Name) as IQueryable<Brand>;
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

        public void UpdateBrand(Brand brand)
        {
            _context.Brands.Update(brand);
        }
    }
}

using ECommerce_MVC.Dtos.Brand;
using ECommerce_MVC.Wrappers;
using Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ECommerce_MVC.Interfaces
{
    public interface IBrandRepository
    {
        Task<IEnumerable<Brand>> GetBrandsList();
        Task<Brand> GetBrandAsync(Guid? brandid);
        Brand GetBrand(Guid? brandid);
        void AddBrand(Brand brand);
        Task AddBrandAsync(Brand brand);
        void UpdateBrand(Brand brand);
        void DeleteBrand(Brand brand);
        bool Save();
        Task<bool> SaveAsync();
    }
}

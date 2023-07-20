using ECommerce_MVC.Dtos.Product;
using ECommerce_MVC.Wrappers;
using Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_MVC.Interfaces
{
    public interface IProductRepository
    {
        Task<PagedList<Product>> GetProductsList(ProductParameters parameters);
        Task<IEnumerable<Product>> GetLatestProductsList();
        Task<IEnumerable<Product>> GetRandomProductsList();
        Task<Product> GetProductAsync(Guid Productid);
        Product GetProduct(Guid Productid);
        void AddProduct(Product product);
        Task AddProductAsync(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(Product product);
        bool Save();
        Task<bool> SaveAsync();
    }
}

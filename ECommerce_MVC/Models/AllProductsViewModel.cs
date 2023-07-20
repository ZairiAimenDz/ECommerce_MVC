using ECommerce_MVC.Dtos.Product;
using ECommerce_MVC.Wrappers;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_MVC.Models
{
    public class AllProductsViewModel
    {
        public PagedList<Product> Products{ get; set; }
        public ProductParameters Parameters{ get; set; }
    }
}

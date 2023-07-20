using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_MVC.Models
{
    public class ProductDetailsViewModel
    {
        public Product ProdDetails{ get; set; }
        public IEnumerable<Product> OtherProducts { get; set; }
        // TODO : Comments And Ratings
    }
}

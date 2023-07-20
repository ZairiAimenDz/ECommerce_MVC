using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce_MVC.Dtos.Product
{
    public class ProductEditDto
    {
        public double NewPrice { get; set; }
        public bool isVisible { get; set; }
        public ProductCondition Condition{ get; set; }
        public int NumberInStock { get; set; }
    }
}

using ECommerce_MVC.Dtos.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace ECommerce_MVC.Dtos.Brand
{
    public class BrandParameters : BasePaginationParameters
    {
        public string BrandName { get; set; }
    }
}

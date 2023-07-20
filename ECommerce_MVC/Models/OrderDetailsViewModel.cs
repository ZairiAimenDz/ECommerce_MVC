﻿using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ECommerce_MVC.Models
{
    public class OrderDetailsViewModel
    {
        public Order Order { get; set; }
        public List<Product> OrderedProduct { get; set; }
        public BuyerDetails Buyer { get; set; }
    }
}

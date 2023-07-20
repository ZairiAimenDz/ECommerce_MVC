﻿using System;

namespace Models
{
    public class OrderedProduct
    {
        public Product Product { get; set; }
        public Guid ProductId { get; set; }

        public Order Order { get; set; }
        public Guid OrderId { get; set; }
    }
}
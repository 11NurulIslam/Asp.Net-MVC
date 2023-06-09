﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mvc20.Models
{
    public class Order
    {
        public System.Guid OrderId { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public System.Guid CustomerId { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
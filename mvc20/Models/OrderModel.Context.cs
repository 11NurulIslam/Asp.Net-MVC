using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace mvc20.Models
{
    public partial class OnlineShopEntities : DbContext
    {
        public OnlineShopEntities()
            : base("name=OnlineShopEntities")
        {
        }



        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Order> Orders { get; set; }

    }
}
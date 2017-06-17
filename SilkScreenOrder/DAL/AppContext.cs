using SilkScreenOrder.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SilkScreenOrder.DAL
{
    public class AppContext : DbContext
    {
        public AppContext() : base("SilkScreenFun") { }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Design> Designs { get; set; }

        public DbSet<Apparel> Apparel { get; set; }

        public DbSet<OrderForm> OrderForms { get; set; }
    }
}
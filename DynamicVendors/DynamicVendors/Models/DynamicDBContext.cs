using DynamicVendors.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DynamicVendors.Repository
{
    public class DynamicDBContext : DbContext
    {
        public DbSet<Admin> admin { get; set; }
        public DbSet<Vendor> vendors { get; set; }
    }
}
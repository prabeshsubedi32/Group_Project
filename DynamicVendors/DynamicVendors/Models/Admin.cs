using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicVendors.Models
{
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public List <Vendor> vendors { get; set; }
    }
}
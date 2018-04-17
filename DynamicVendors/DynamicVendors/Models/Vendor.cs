using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicVendors.Models
{
    [Table("Vendors")]
    public class Vendor
    {
        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        //public int Id { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DynamicVendors.Models
{
    [Table("Admin")]
    public class Admin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        public string UserPassword { get; set; }

       // List<Vendor> vendors { get; set; }
    }
}
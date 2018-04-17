using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicVendors.Models
{
    public class MenuList
    {
        public int Id { get; set; }
        public string ManuName { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public string LinkName { get; set; }

        
    }
}
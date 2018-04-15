﻿using DynamicVendors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicVendors.Repository
{
   public  interface IDynamicVendor
    {
        void Add(Admin admin);
        List<Admin> GetAdmin();
        Admin GetAdmin(int Id);
        void Remove(int id);
        void Update(int id);

        void AddVendor(Vendor vendor);
        List<Vendor> GetList();
        Vendor GetVendor(int VendorId);
        void RemoveVendor(int id);
        void UpdateVendor(int id);






    }
}

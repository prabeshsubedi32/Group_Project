using DynamicVendors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicVendors.Repository
{
    public class DynamicVendor:IDynamicVendor
    {
        public void Add(Admin admin)
        {
            DynamicDBContext data = new DynamicDBContext();
            data.admin.Add(admin);
            data.SaveChanges();

        }

        public List<Admin> GetAdmin()
        {
            DynamicDBContext data = new DynamicDBContext();
            return data.admin.ToList();
        }

        public Admin GetAdmin(int Id)
        {
            DynamicDBContext data = new DynamicDBContext();
            return data.admin.ToList().Find(x => x.Id == Id);
        }

        public void Remove(int id)
        {
            try
            {
             DynamicDBContext data = new DynamicDBContext();
            Admin user = data.admin.ToList().Find(x => x.Id == id);
            data.admin.Remove(user);
            data.SaveChanges();

            }
            catch (Exception )
            {
               // throw;
            }
        }

        public void Update(int id)
        {
            DynamicDBContext data = new DynamicDBContext();
            Admin user = data.admin.ToList().Find(x => x.Id == id);
            data.admin.Add(user);
            data.SaveChanges();
        }

    }
}
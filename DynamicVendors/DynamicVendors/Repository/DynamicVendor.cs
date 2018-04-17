using DynamicVendors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DynamicVendors.Repository
{
    public class DynamicVendor : IDynamicVendor
    {
        public void Add(Admin admin)
        {
            try
            {
                DynamicDBContext data = new DynamicDBContext();
                data.admin.Add(admin);
                data.SaveChanges();
            }
            catch (Exception)
            {
                // throw;
            }


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
            catch (Exception)
            {
                // throw;
            }
        }

        public void Update(Admin admin)
        {

            //  Admin user = data.admin.ToList().Find(x => x.Id == id);
            try
            {
                DynamicDBContext data = new DynamicDBContext();
                data.Entry(admin).State = System.Data.Entity.EntityState.Modified;
                //data.admin.Add(user);
                data.SaveChanges();
            }
            catch (Exception)
            {
                // throw;
            }

        }



        public void AddVendor(Vendor vendor)
        {
            try
            {
                DynamicDBContext data = new DynamicDBContext();
                data.vendors.Add(vendor);
                data.SaveChanges();
            }
            catch (Exception)
            {
                // throw;
            }

        }

        public Vendor GetVendor(int Id)
        {
            DynamicDBContext data = new DynamicDBContext();
            return data.vendors.ToList().Find(x => x.VendorId == Id);
        }

        public void RemoveVendor(int id)
        {
            try
            {
                DynamicDBContext data = new DynamicDBContext();
                Vendor user = data.vendors.ToList().Find(x => x.VendorId == id);
                data.vendors.Remove(user);
                data.SaveChanges();

            }
            catch (Exception)
            {
                // throw;
            }
        }

        public void UpdateVendor(Vendor user)
        {
            try
            {
                DynamicDBContext data = new DynamicDBContext();
                data.Entry(user).State = System.Data.Entity.EntityState.Modified;
               // data.vendors.Add(user);
                data.SaveChanges();
            }
            catch (Exception)
            {
                // throw;
            }
        }

        public List<Vendor> GetVendor()
        {
            DynamicDBContext data = new DynamicDBContext();
            return data.vendors.ToList();

           // throw new NotImplementedException();
        }
    }
}
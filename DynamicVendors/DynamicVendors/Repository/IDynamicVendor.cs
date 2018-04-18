using DynamicVendors.Models;
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
        void Update(Admin id);

        void AddVendor(Vendor vendor);
        List<Vendor> GetVendor();
        Vendor GetVendor(int id);
        void RemoveVendor(int id);
        void UpdateVendor(Vendor vendor);

        void AddUser(User users);
        List<User> GetUser();
        User GetUser(int id);
        void RemoveUser(int id);
        void UpdateUser(User users);
    }
}

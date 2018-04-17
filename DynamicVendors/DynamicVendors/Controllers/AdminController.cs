using DynamicVendors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicVendors.Repository;

namespace DynamicVendors.Controllers
{
    public class AdminController : Controller
    {
        private IDynamicVendor _data;
        public AdminController(IDynamicVendor dynamicVendor )
        {
            _data = dynamicVendor;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult createAdmin()
        {

            return View();
        }

        public ActionResult AddAdmin(Admin admin)
        {

            _data.Add(admin);
            
            return View("createAdmin");
        }


        public ActionResult Display()
        {
           var data =  _data.GetAdmin();

            return View(data);
        }

        public ActionResult displayAdmin(int id)
        {
            var data = _data.GetAdmin(id);
            return View(data);

        }

        public ActionResult updateAdmin(int id)
        {
            Admin tobeupaded = _data.GetAdmin().Where(x => x.Id == id).FirstOrDefault();
            return View(tobeupaded);

        }

        public ActionResult update(Admin admin)
        {
            _data.Update(admin);

            return View("Display", _data.GetAdmin());
        }

        public ActionResult Remove(int id)
        {
            _data.Remove(id);

            return View();
        }
    }
}
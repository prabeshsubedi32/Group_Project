using DynamicVendors.Models;
using DynamicVendors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicVendors.Controllers
{
    public class VendorController : Controller
    {
        private IDynamicVendor _data;
        public VendorController(IDynamicVendor dynamicVendor)
        {
            _data = dynamicVendor;
        }
        // GET: Vendor
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult createVendor()
        {

            return View();
        }
        public ActionResult AddVendor(Vendor vendor)
        {
            _data.AddVendor(vendor);

            return View("createVendor");
        }

        public ActionResult updateVendor(int id)
        {
            _data.UpdateVendor(id);
            return View();
        }

        //public ActionResult Display()
        //{
        //    var data = _data.GetVendor();

        //    return View(data);
        //}

        public ActionResult displayVendor(int id)
        {
            var data = _data.GetVendor(id);
            return View(data);

        }

        public ActionResult RemoveVendor(int id)
        {
            _data.Remove(id);

            return View();
        }
    }
}
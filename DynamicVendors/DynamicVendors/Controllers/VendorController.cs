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
            Vendor tobeupaded = _data.GetVendor().Where(x => x.VendorId == id).FirstOrDefault();
            return View(tobeupaded);

        }

        public ActionResult update(Vendor vendor)
        {
            _data.UpdateVendor(vendor);

            return View("Display", _data.GetVendor());
        }

        public ActionResult Display()
        {
            var data = _data.GetVendor();

            return View(data);
        }

        public ActionResult displayVendor(int id)
        {
            var data = _data.GetVendor(id);
            return View(data);

        }

        public ActionResult RemoveVendor(int id)
        {
            _data.RemoveVendor(id);

            return View();
        }
    }
}
using DynamicVendors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicVendors.Controllers
{
    public class LoginController : Controller
    {

        private IDynamicVendor _data;
        public LoginController(IDynamicVendor dynamicVendor)
        {
            _data = dynamicVendor;
        }
        // GET: Login
        public ActionResult Signin()
        {
            Session["Menus"] = null;
            return View();
        }
        public ActionResult Validate(string txtUsername, string txtUserpassword)
        {
            if (_data.GetAdmin().ToList().Where(x => x.UserName == txtUsername && x.UserPassword == txtUserpassword).Any())
            {
                Session["UserType"] = 1;
              //  return View("Home", "Index");
              return  RedirectToAction("Index", "Home");
            }
            else if (_data.GetVendor().ToList().Where(x => x.UserName == txtUsername && x.UserPassword == txtUserpassword).Any())
            {
                Session["UserType"] = 2;
                return RedirectToAction("Index", "Home");
            }
            else if (_data.GetUser().ToList().Where(x => x.UserName == txtUsername && x.UserPassword == txtUserpassword).Any())
            {
                Session["UserType"] = 3;
                return RedirectToAction("Index", "Home");
            }
            return RedirectToAction("Index", "Invalid");
        //   return View();
        }
    }
}
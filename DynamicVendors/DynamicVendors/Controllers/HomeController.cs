using DynamicVendors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DynamicVendors.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<MenuList> menuLists = new List<MenuList>();


            if ( Convert.ToString(Session["userType"]) == Convert.ToString(1))
            {
                menuLists.Add(new MenuList
                {
                    Id = 1,
                    LinkName = "CreateAdmin",
                    ActionName = "CreateAdmin",
                    ControllerName = "Admin"

                });

                menuLists.Add(new MenuList
                {
                    Id = 2,
                    LinkName = "CreateVendor",
                    ActionName = "CreateVendor",
                    ControllerName = "Vendor"

                });

                menuLists.Add(new MenuList
                {
                    Id = 3,
                    LinkName = "Display Vendor",
                    ActionName = "Display",
                    ControllerName = "Vendor"
                });
            }
            if (Convert.ToString(Session["userType"]) == Convert.ToString(2))
            {
                menuLists.Add(new MenuList
                {
                    Id = 1,
                    LinkName = "CreateVendor",
                    ActionName = "CreateVendor",
                    ControllerName = "Vendor"

                });

                menuLists.Add(new MenuList
                {
                    Id = 2,
                    LinkName = "Display Vendor",
                    ActionName = "Display",
                    ControllerName = "Vendor"
                });

                menuLists.Add(new MenuList
                {
                    Id = 3,
                    LinkName = "Display User",
                    ActionName = "Display",
                    ControllerName = "Vendor"
                });
            }

            if (Convert.ToString(Session["userType"]) == Convert.ToString(3))
            {
                menuLists.Add(new MenuList
                {
                    Id = 1,
                    LinkName = "CreateUser",
                    ActionName = "createUser",
                    ControllerName = "User"

                });


            }
            Session["Menus"] = menuLists;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
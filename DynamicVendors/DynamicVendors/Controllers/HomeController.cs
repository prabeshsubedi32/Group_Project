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

            int roleid = 2;
            if (roleid == 1)
            {
                menuLists.Add(new MenuList
                {
                    Id = 1,
                    LinkName = "Home",
                    ActionName = "Index",
                    ControllerName = "Home"

                });

                menuLists.Add(new MenuList
                {
                    Id = 1,
                    LinkName = "Admin",
                    ActionName = "Index",
                    ControllerName = "Admin"

                });
            }

            else if (roleid == 2)
            {
                menuLists.Add(new MenuList
                {
                    Id = 1,
                    LinkName = "Home",
                    ActionName = "Index",
                    ControllerName = "Home"

                });

                menuLists.Add(new MenuList
                {
                    Id = 1,
                    LinkName = "Xyz",
                    ActionName = "Index",
                    ControllerName = "Admin"

                });
                menuLists.Add(new MenuList
                {
                    Id = 1,
                    LinkName = "Abc",
                    ActionName = "Index",
                    ControllerName = "Admin"

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
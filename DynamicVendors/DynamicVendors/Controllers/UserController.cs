using DynamicVendors.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DynamicVendors.Repository;

namespace DynamicVendors.Controllers
{
    public class UserController : Controller
    {
        private IDynamicVendor _data;
        public UserController(IDynamicVendor dynamicVendor)
        {
            _data = dynamicVendor;
        }
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult createUser()
        {
            
            return View();
        }

        public ActionResult AddUser(User user)
        {

            _data.AddUser(user);

            return View("createUser");
        }


        public ActionResult Display()
        {
            var data = _data.GetUser();

            return View(data);
        }

        public ActionResult displayUser(int id)
        {
            var data = _data.GetUser(id);
            return View(data);

        }

        public ActionResult updateUser(int id)
        {
            User tobeupaded = _data.GetUser().Where(x => x.UserID == id).FirstOrDefault();
            return View(tobeupaded);

        }

        public ActionResult update(User users)
        {
            _data.UpdateUser(users);

            return View("Display", _data.GetUser());
        }

        public ActionResult Remove(int id)
        {
            _data.RemoveUser(id);

            return View();
        }
    }
}
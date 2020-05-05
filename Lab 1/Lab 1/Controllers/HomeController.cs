using Lab_1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration(User user)
        {
            ViewBag.Name = user.Name;
            ViewBag.Email = user.Email;
            if(ViewBag.Name != null && ViewBag.Email != null)
            {
                return View("Welcome");
            }
            else return View("Registration");
        }
    }
}
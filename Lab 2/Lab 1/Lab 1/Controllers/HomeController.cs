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
        ModelContext context = new ModelContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration(User user)
        {
            
            if(ModelState.IsValid)
            {
                context.Users.Add(user);
                context.SaveChanges();
                return View("Welcome", user);
            }
            else return View("Registration");
        }
    }
}
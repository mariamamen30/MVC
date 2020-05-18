using Lab_3.DAL;
using Lab_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_3.Controllers
{
    public class HomeController : Controller
    {
        ModelContext context = new ModelContext();
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Registration(Employee employee)
        {

            if (ModelState.IsValid)
            {
                context.Employees.Add(employee);
                context.SaveChanges();
                return View("Welcome", employee);
            }
            else return View("Registration");
        }
    }
}
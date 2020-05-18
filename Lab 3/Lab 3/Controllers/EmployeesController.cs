using Lab_3.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_3.Controllers
{
    public class EmployeesController : Controller
    {
        ModelContext context = new ModelContext();
        // GET: Employees
        public ActionResult Index()
        {
            return View(context.Employees.ToList());
        }
    }
}
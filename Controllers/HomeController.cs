using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC5Employees.Models;

namespace MVC5Employees.Controllers
{
    public class HomeController : Controller
    {
        // Main Menu
        public ActionResult Index()
        {
            return View();
        }

        // About Page
        public ActionResult About()
        {
            return View();
        }

        // Contact Page
        public ActionResult Contact()
        {
            return View();
        }

        // Form Confirm
        [HttpPost]
        public ActionResult AddEmp (int empID, string empName, int empSal)
        {
            Employee e = new Employee()
            {
                Id = empID,
                Name = empName,
                Salary = empSal
            };
          
            return View("EmpConfirm", e);
        }

        // New Employee Form
        public ActionResult AddEmp()
        {
            return View("NewEmpForm");
        }

        // Dynamic Page Action Method
        public ActionResult GrossPayCalculator()
        {
            return View();
        }
    
        // View with Arrays and Looping
        public ActionResult MainOfficeEmployees()
        {
            return View();
        }
    }
}
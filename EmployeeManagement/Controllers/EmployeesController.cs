using EmployeeManagement.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Mvc;

namespace EmployeeManagement.Controllers
{
    public class EmployeesController : Controller
    {
        private ApplicationDbContext _context;

        public EmployeesController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Language(string language)
        {
            if (!string.IsNullOrEmpty(language))
            {
                Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
                Thread.CurrentThread.CurrentUICulture = new CultureInfo(language);
            }
            HttpCookie cookie = new HttpCookie("Language");
            cookie.Value = language;
            Response.Cookies.Add(cookie);

            return RedirectToAction("index");
        }

        public ActionResult Index()
        {
            return View(_context.Employees.ToList());
        }

        public ActionResult Details(int id)
        {
            var employee = _context.Employees.SingleOrDefault(m => m.Id == id);

            if (employee == null)
                return HttpNotFound();

            return View(employee);
        }

        public ActionResult Create(int? id)
        {
            var employee = _context.Employees.SingleOrDefault(m => m.Id == id);
            ViewBag.Update = false;

            //update
            if (employee != null)
            {
                ViewBag.Update = true;
                return View(employee);
            }
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken()]
        public ActionResult Create(Employee employee)
        {
            if (!ModelState.IsValid)
               return View("Create", employee);

            if (employee.Id == 0)
                _context.Employees.Add(employee);

            else
            {
                var customerInDb = _context.Employees.Single(c => c.Id == employee.Id);

                customerInDb.FirstName = employee.FirstName;
                customerInDb.LastName = employee.LastName;
                customerInDb.FullName = employee.FullName;
                customerInDb.Salary = employee.Salary;
                customerInDb.Email = employee.Email;
                customerInDb.Password = employee.Password;
                customerInDb.BirthDate = employee.BirthDate;
                customerInDb.City = employee.City;
                customerInDb.JobTitle = employee.JobTitle;
                customerInDb.Department = employee.Department;
                customerInDb.Branch = employee.Branch;
            }

            _context.SaveChanges();
            return RedirectToAction("index");
        }

        public ActionResult Delete(int id)
        {
            var employee = _context.Employees.SingleOrDefault(m => m.Id == id);

            if (employee == null)
                return HttpNotFound();

            _context.Employees.Remove(employee);
            _context.SaveChanges();

            return RedirectToAction("index");
        }
    }
}
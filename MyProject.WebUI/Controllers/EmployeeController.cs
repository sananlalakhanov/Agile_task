using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyProject.Business.Abstract;
using MyProject.DataAccess.Concrete.EntityFramework.Contexts;
using MyProject.Entity.Concrete;
using MyProject.WebUI.Models;

namespace MyProject.WebUI.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService;
        private IDepartmentService _departmentService;
        public EmployeeController(IEmployeeService employeeService,IDepartmentService departmentService)
        {
            _employeeService = employeeService;
            _departmentService = departmentService;
        }
        
        public IActionResult Index()
        {
            var model = new EmployeeListViewModel
            {
                Employees = _employeeService.GetAll()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            List<SelectListItem> departments = (from d in _departmentService.GetAll()
                                                select new SelectListItem
                                                {
                                                    Text = d.DepartmentName,
                                                    Value = d.DepId.ToString()
                                                }).ToList();

            ViewBag.department = departments;
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            
            if (ModelState.IsValid)
            {
                _employeeService.Add(employee);
                return RedirectToAction("Index");
            }
            else
            {
                return RedirectToAction("Index");
            } 
        }

        public IActionResult DeleteEmployee(int id)
        {
            var employee = _employeeService.Get(id);
            _employeeService.Delete(employee);
            return RedirectToAction("Index");
        }

        public IActionResult LoadEmployee(int id)
        {
            List<SelectListItem> departments = (from d in _departmentService.GetAll()
                                                select new SelectListItem
                                                {
                                                    Text = d.DepartmentName,
                                                    Value = d.DepId.ToString()
                                                }).ToList();

            ViewBag.department = departments;
            var selectedEmployee = _employeeService.Get(id);
            return View("LoadEmployee", selectedEmployee);
        }

        public IActionResult UpdateEmployee(Employee employee)
        {
            _employeeService.Update(employee);
            return RedirectToAction("Index");
        }
    }
}

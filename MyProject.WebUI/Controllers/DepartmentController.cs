using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyProject.Business.Abstract;
using MyProject.Entity.Concrete;
using MyProject.WebUI.Models;

namespace MyProject.WebUI.Controllers
{
    public class DepartmentController : Controller
    {
        private IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }
        public IActionResult Index()
        {
            var model = new DepartmentListViewModel
            {
                Departments = _departmentService.GetAll()
            };
            return View(model);
        }

        [HttpGet]
        public IActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDepartment(Department department)
        {
            if (ModelState.IsValid)
            {
                _departmentService.Add(department);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public IActionResult DeleteDepartment(int id)
        {
            var department = _departmentService.Get(id);
            _departmentService.Delete(department);
            return RedirectToAction("Index");
        }

        public IActionResult UpdateDepartment(Department department)
        {
            _departmentService.Update(department);
            return RedirectToAction("Index");
        }
        
        public IActionResult LoadDepartment(int id)
        {
            var selectedDepartment = _departmentService.Get(id);
            return View("LoadDepartment", selectedDepartment);
        }
    }
}

using MyProject.Business.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {
        private IEmployeeRepository _employeeRepository;
        public EmployeeManager(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        public void Add(Employee employee)
        {
            _employeeRepository.Add(employee);
        }

        public void Delete(Employee employee)
        {
            _employeeRepository.Delete(employee);
        }

        public Employee Get(int EmployeeId)
        {
            return _employeeRepository.Get(p => p.Id == EmployeeId);
        }

        public List<Employee> GetAll()
        {
            return _employeeRepository.GetAll();
        }

        public void Update(Employee employee)
        {
            _employeeRepository.Update(employee);
        }
    }
}

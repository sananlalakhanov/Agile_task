using MyProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Business.Abstract
{
    public interface IEmployeeService
    {
        List<Employee> GetAll();
        Employee Get(int EmployeeId);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(Employee employee);
    }
}

using MyProject.Business.Abstract;
using MyProject.DataAccess.Abstract;
using MyProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Business.Concrete
{
    public class DepartmentManager : IDepartmentService
    {
        private IDepartmentRepository _departmentRepository;
        public DepartmentManager(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public void Add(Department department)
        {
            _departmentRepository.Add(department);
        }

        public void Delete(Department department)
        {
            _departmentRepository.Delete(department);
        }

        public Department Get(int depId)
        {
            return _departmentRepository.Get(p => p.DepId == depId);
        }

        public List<Department> GetAll()
        {
            return _departmentRepository.GetAll();
        }

        public void Update(Department department)
        {
            _departmentRepository.Update(department);
        }
    }
}

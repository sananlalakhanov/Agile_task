using MyProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Business.Abstract
{
    public interface IDepartmentService
    {
        List<Department> GetAll();
        Department Get(int depId);
        void Add(Department department);
        void Update(Department department);
        void Delete(Department department);
    }
}

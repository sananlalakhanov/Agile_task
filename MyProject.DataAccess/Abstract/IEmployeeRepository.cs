using MyProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Abstract
{
    public interface IEmployeeRepository:IEntityRepository<Employee>
    {
    }
}

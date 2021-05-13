using MyProject.DataAccess.Abstract;
using MyProject.DataAccess.Concrete.EntityFramework.Contexts;
using MyProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework
{
    public class EfEmployeeRepository : EfEntityRepositoryBase<Employee,MyProjectContext>, IEmployeeRepository
    {
        
    }
}

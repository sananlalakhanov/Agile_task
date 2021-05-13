using Microsoft.EntityFrameworkCore;
using MyProject.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.DataAccess.Concrete.EntityFramework.Contexts
{
    public class MyProjectContext:DbContext
    {
        public MyProjectContext()
        {

        }
        public MyProjectContext(DbContextOptions<MyProjectContext> options):base(options)
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = (localdb)\\MSSQLLocalDB; Database = Agile; Trusted_Connection = true");
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}

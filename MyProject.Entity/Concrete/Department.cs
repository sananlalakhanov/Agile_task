using MyProject.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProject.Entity.Concrete
{
    [Table("tbl_Department")]
    public class Department:IEntity
    {
        [Key]
        public int DepId { get; set; }

        [Required(ErrorMessage = "Required")]
        [MaxLength(50)]
        public string DepartmentName { get; set; }
        public List<Employee> Employees { get; set; }
        
    }
}

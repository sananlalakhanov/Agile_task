using MyProject.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MyProject.Entity.Concrete
{
    [Table("tbl_Employee")] 
    public class Employee:IEntity
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="Required")]
        [MaxLength(50)]
        public string Name { get; set; }


        [Required(ErrorMessage = "Required")]
        [MaxLength(50)]
        public string Surname { get; set; }


        [Required(ErrorMessage = "Required")]
        [MaxLength(100)]
        public string Email { get; set; }


        [Required(ErrorMessage = "Required")]
        [MaxLength(15)]
        public string Mobile { get; set; }

        public string Description { get; set; }

        [ForeignKey("Department")]
        public int DepId { get; set; }
        public Department Department { get; set; }
    }
}

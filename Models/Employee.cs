using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DotNetCore.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required(ErrorMessage ="Please enter the full name!")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter the employee code!")]
        [DisplayName("Employee Code")]
        public string EmpCode { get; set; }

        [Required(ErrorMessage = "Please enter the position!")]
        [DisplayName("Position")]
        public string Position { get; set; }

        [Required(ErrorMessage = "Please enter the location!")]
        [DisplayName("Location")]
        public string Location { get; set; }
    }
}

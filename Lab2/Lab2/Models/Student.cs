using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab2.Models
{
    public class Student
    {
        
        public string Id { get; set; }

        [Required(ErrorMessage = "Please put Student name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please put Student Date of Birth")]
        public DateTime DOB { get; set; }

        [Required(ErrorMessage = "Please put Student Credit")]
        [Range(0,160)]
        public int Credit { get; set; }

        [Required(ErrorMessage = "Please put Student CGPA")]
        [Range(1, 4)]
        public double Cgpa { get; set; }

        
        public string DepartmentName { get; set; }

    }
}
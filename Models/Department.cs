using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }

        [Display(Name = "DeptName")]
        public string DepartmentName { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }
    }
}

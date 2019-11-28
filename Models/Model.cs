using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Model
    {
        public int ModelID { get; set; }
        [Display(Name = "ModelName")]
        public string ModelName { get; set; }

        [ForeignKey("Brand")]
        public int BrandID { get; set; }
        public Brand Brand { get; set; }

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}

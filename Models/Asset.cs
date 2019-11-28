using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Asset
    {   
        
        public int AssetID { get; set; }
        [Required]
        [Display(Name = "AssetName")]
        public string AssetName { get; set; }

        [Required]
        [Display(Name = "Image")]
        public string Image { get; set; }

    }
}

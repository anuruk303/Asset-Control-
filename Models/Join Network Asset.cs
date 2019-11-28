using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace tbkk_AC.Models
{
    public class Join_Network_Asset
    {
        public int JoinNetAsID { get; set; }
        [Required]
        [Display(Name = "Note")]
        public string Note { get; set; }
        [Required]
        [Display(Name = "Status")]
        public string Status { get; set; }
        [ForeignKey("NetworkName")]
        public int NetworkID { get; set; }
        public Network Network { get; set; }
        [ForeignKey("Asset")]
        public int AssetID { get; set; }
        public Asset Asset { get; set; }

    }
}

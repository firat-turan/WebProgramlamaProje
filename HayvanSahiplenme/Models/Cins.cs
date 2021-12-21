using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenme.Models
{
    public class Cins
    {
        [Key]
        public int CinsId { get; set; }
        [StringLength(50)]
        public string CinsAd { get; set; }
        [StringLength(50)]
        public string CinsAdIng { get; set; }
        
        public int TurId { get; set; }
        public Tur Tur { get; set; }    

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenmeSitesi.Models
{
    public class Hayvan
    {
        [Key]
        public int HayvanID { get; set; }
        [StringLength(50)]
        public string Tur { get; set; }
        public ICollection<Ilan> Ilans { get; set; }
        public ICollection<Cins> Cinss { get; set; }
    }
}

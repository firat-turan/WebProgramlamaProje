using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenmeSitesi.Models
{
    public class Ilan
    {
        [Key]
        public int IlanID{ get; set; }
        public DateTime Tarihi { get; set; }

        [StringLength(150)]
        public string Aciklama { get; set; }



        public int HayvanID { get; set; }
        public virtual Hayvan Hayvan { get; set; }

    }
}

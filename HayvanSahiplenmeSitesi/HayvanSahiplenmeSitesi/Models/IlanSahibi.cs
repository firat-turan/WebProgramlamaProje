using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenmeSitesi.Models
{
    public class IlanSahibi
    {
        [Key]
        public int IlanSahibiID { get; set; }
        [StringLength(50)]
        public string Ad { get; set; }
        [StringLength(50)]
        public string Soyad { get; set; }
        public int TelNo{ get; set; }
        [StringLength(150)]
        public string Adres { get; set; }
        [StringLength(50)]
        public string Email{ get; set; }

        public ICollection<Hayvan> Hayvan { get; set; }


    }
}

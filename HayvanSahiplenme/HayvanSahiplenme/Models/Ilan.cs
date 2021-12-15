using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenme.Models
{
    public class Ilan
    {
        [Key]
        public int IlanId { get; set; }
        public DateTime Tarih { get; set; }
        [StringLength(200)]
        public string Aciklama { get; set; }
        [StringLength(200)]
        public string AciklamaIng { get; set; }
        [StringLength(100)]
        public string Fotograf { get; set; }

        public int HayvanId { get; set; }
        public Hayvan Hayvan{ get; set; }

        public int KullaniciId { get; set; }
        public Kullanici Kullanici { get; set; }



    }
}

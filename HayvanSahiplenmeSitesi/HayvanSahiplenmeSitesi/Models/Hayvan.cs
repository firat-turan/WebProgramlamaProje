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
        [StringLength(50)]
        public string Cins { get; set; }
        public int Yas { get; set; }
        [StringLength(50)]
        public string AsiDurumu { get; set; }
        [StringLength(10)]
        public string Cinsiyet { get; set; }
        [StringLength(100)]
        public string Fotograf { get; set; }

        public int IlanSahibiID { get; set; }
        public virtual IlanSahibi IlanSahibi{ get; set; }

        public ICollection<Ilan> Ilan { get; set; }
    }
}

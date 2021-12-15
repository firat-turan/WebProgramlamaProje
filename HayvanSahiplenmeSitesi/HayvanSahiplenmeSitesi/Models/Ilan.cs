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
        public DateTime Tarih { get; set; }
        [StringLength(150)]
        public string Aciklama { get; set; }
        public int Yas { get; set; }
        [StringLength(50)]
        public string AsiDurumu { get; set; }
        [StringLength(10)]
        public string Cinsiyet { get; set; }
        [StringLength(100)]
        public string Fotograf { get; set; }

        public Hayvan HayvanID { get; set; }

        public Cins CinsID { get; set; }
 
        public IlanSahibi IlanSahibiID { get; set; }



    }
}

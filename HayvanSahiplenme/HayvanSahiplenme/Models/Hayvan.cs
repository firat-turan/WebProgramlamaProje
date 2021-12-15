using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenme.Models
{
    public class Hayvan
    {
        public int HayvanId { get; set; }
        public string Cinsiyet { get; set; }
        public string CinsiyetIng { get; set; }

        public int Yas { get; set; }
        public string AsiDurumu { get; set; }
        public string AsiDurumuIng { get; set; }

        public int CinsId { get; set; }
        public Cins Cins { get; set; }

        public ICollection<Ilan> Ilans { get; set; }


    }
}

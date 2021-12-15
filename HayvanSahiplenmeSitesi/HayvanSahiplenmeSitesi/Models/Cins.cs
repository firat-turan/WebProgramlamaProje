using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenmeSitesi.Models
{
    public class Cins
    {
        public int CinsID { get; set; }
        public string CinsAdi{ get; set; }

        public Hayvan HayvanID { get; set; }

        public ICollection<Ilan> Ilans { get; set; }

    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenme.Models
{
    public class Kullanici:IdentityUser
    {

        [StringLength(50)]
        public string Ad { get; set; }
        [StringLength(50)]
        public string Soyad { get; set; }
        [StringLength(50)]
        public string TcNo { get; set; }
        [StringLength(50)]
        public string TelNo { get; set; }
        [StringLength(150)]
        public string Adress { get; set; }

        public ICollection<Ilan> Ilan { get; set; }
    }
}

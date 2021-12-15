using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenme.Models
{
    public class Kullanici
    {
        [Key]
        public int KullaniciId { get; set; }
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
        [StringLength(50)]
        public string Email { get; set; }







    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenme.Models
{
    public class Ilan
    {
        [Key]
        public int IlanId { get; set; }
        public DateTime Tarih { get; set; }

        [StringLength(100)]
        public string İlanBaslik { get; set; }

        [StringLength(100)]
        public string İlanBaslikIng { get; set; }
        [StringLength(50)]
        public string HayvanAd { get; set; }

        public int CinsId { get; set; }
        public Cins Cins { get; set; }

        [StringLength(50)]
        public string Cinsiyet { get; set; }
        [StringLength(50)]
        public string CinsiyetIng { get; set; }

        public int Yas { get; set; }
        [StringLength(50)]
        public string AsiDurumu { get; set; }
        [StringLength(50)]
        public string AsiDurumuIng { get; set; }

        

        [StringLength(200)]
        public string Aciklama { get; set; }
        [StringLength(200)]
        public string AciklamaIng { get; set; }

        [StringLength(100)]
        public string Fotograf { get; set; }

        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public Kullanici Kullanici { get; set; }
        
        //public DbSet<Kullanici> Kullanici { get; set; }
    }
}

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
        [Required]
        [Display(Name = "İlan Başlığı")]
        [StringLength(100)]
        public string İlanBaslik { get; set; }
        [Required]
        [Display(Name = "İlan Başlığı İngilizce")]
        [StringLength(100)]
        public string İlanBaslikIng { get; set; }
        [Required]
        [Display(Name = "Hayvan Adı")]
        [StringLength(50)]
        public string HayvanAd { get; set; }
        [Required]
        [Display(Name = "Cins Adı")]
        public int CinsId { get; set; }
        public Cins Cins { get; set; }
        [Required]
        [Display(Name = "Cinsiyet")]
        [StringLength(50)]
        public string Cinsiyet { get; set; }
        [Required]
        [Display(Name = "Cinsiyet İngilizce")]
        [StringLength(50)]
        public string CinsiyetIng { get; set; }
        [Required]
        [Display(Name = "Yaş")]
        public int Yas { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Aşı Durumu")]
        public string AsiDurumu { get; set; }
        [Required]
        [Display(Name = "Aşı Durumu Ing")]
        [StringLength(50)]
        public string AsiDurumuIng { get; set; }


        [Display(Name = "Açıklama")]
        [StringLength(200)]
        public string Aciklama { get; set; }
        [Display(Name = "Açıklama İngilizce")]
        [StringLength(200)]
        public string AciklamaIng { get; set; }
        [Display(Name = "Fotoğraf")]
        [StringLength(100)]
        public string Fotograf { get; set; }
        [Display(Name = "Fotoğraf")]
        [NotMapped]
        public IFormFile ImageFile { get; set; }

        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public Kullanici Kullanici { get; set; }
        
        //public DbSet<Kullanici> Kullanici { get; set; }
    }
}

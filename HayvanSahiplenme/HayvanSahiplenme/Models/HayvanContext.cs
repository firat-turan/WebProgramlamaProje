using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenme.Models
{
    public class HayvanContext:DbContext
    {
        public DbSet<Tur> Tur { get; set; }
        public DbSet<Cins> Cins { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Ilan> Ilans { get; set; }



        public HayvanContext(DbContextOptions<HayvanContext>options):base(options)
        {

        }
    }
}

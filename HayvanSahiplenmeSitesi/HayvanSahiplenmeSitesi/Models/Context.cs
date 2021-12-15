using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HayvanSahiplenmeSitesi.Models
{
    public class Context: DbContext
    {
        public DbSet<Hayvan> Hayvan { get; set; }
        public DbSet<IlanSahibi> IlanSahibi { get; set; }
        public DbSet<Ilan> Ilan { get; set; }
        public DbSet<Cins> Cins { get; set; }

        public Context(DbContextOptions<Context>options):base(options)
        {

        }
    }
}

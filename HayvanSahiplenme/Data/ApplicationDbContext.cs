using HayvanSahiplenme.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HayvanSahiplenme.Data
{
    public class ApplicationDbContext : IdentityDbContext<Kullanici>
    {
        public DbSet<Tur> Tur { get; set; }
        public DbSet<Cins> Cins { get; set; }
        public DbSet<Kullanici> Kullanici { get; set; }
        public DbSet<Ilan> Ilans { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
    }
}

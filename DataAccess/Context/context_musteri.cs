using DataAccess.Mapping;
using Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class context_musteri:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = (localdb)\\v11.0; database = Musteridb; integrated security = true;");
        }
        public DbSet<Musteri> Musteris { get; set; }
        public DbSet<Admin> Admins { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new Musterimapping());
            modelBuilder.ApplyConfiguration(new AdminMapping());
            modelBuilder.Entity<Musteri>().HasIndex(x=>x.Telefon).IsUnique();
            modelBuilder.Entity<Admin>().HasIndex(x => x.Kullanici_Adi).IsUnique();
        }

    }
}

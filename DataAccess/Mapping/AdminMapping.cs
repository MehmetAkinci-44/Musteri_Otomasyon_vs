using Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Mapping
{
    public class AdminMapping : IEntityTypeConfiguration<Admin>
    {
        public void Configure(EntityTypeBuilder<Admin> builder)
        {
            builder.Property(x => x.Adi).IsRequired();
            builder.Property(x=>x.Soyadi).IsRequired();
            builder.Property(x=>x.E_mail).IsRequired();
            builder.Property(x=>x.Telefon).IsRequired();
            builder.Property(x=>x.Kullanici_Adi).IsRequired();
            builder.Property(x=>x.Sifre).IsRequired();
            builder.Property(x => x.Adi).HasMaxLength(25);
            builder.Property(x => x.Soyadi).HasMaxLength(25);
            builder.Property(x => x.Telefon).HasMaxLength(11);
            builder.Property(x => x.Kullanici_Adi).HasMaxLength(25);
            builder.Property(x=>x.Sifre).HasMaxLength(25);
            
        }
    }
}

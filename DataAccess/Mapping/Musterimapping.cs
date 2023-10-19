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
    public class Musterimapping : IEntityTypeConfiguration<Musteri>
    {
        public void Configure(EntityTypeBuilder<Musteri> builder)
        {
            builder.Property(x=>x.Adi).HasMaxLength(25);
            builder.Property(x=>x.Soyadi).HasMaxLength(25);
            builder.Property(x => x.E_mail).HasMaxLength(75);
            builder.Property(x => x.Telefon).HasMaxLength(11);
            builder.Property(x => x.Meslegi).HasMaxLength(25);
            builder.Property(x => x.Adi).IsRequired();
            builder.Property(x => x.Soyadi).IsRequired();
            builder.Property(x => x.Dogum_Tarihi).IsRequired();

        }
    }
}

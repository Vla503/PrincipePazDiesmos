using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PrincipePaz.Diesmos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmo.Data.Mapping
{
    public class PastorMap : IEntityTypeConfiguration<Pastor>
    {
        public void Configure(EntityTypeBuilder<Pastor> b)
        {
            //key
            b.HasKey(x => x.IdPastor);
            //property
            b.Property(x => x.NombrePastor).IsRequired().HasMaxLength(200);
            b.Property(x => x.Telefono).IsRequired().HasMaxLength(20);
            b.Property(x => x.Dui).IsRequired().HasMaxLength(20);
            b.Property(x => x.Nit).IsRequired().HasMaxLength(20);

            //foreig
            b.HasOne(x => x.Iglesia).WithMany().HasForeignKey(f => f.IdIglesia);
        }
    }
}

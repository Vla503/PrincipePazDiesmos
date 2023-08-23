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
    public class IglesiaMap : IEntityTypeConfiguration<Iglesia>
    {
        public void Configure(EntityTypeBuilder<Iglesia> b)
        {
            //primary key
            b.HasKey(x => x.idIglesia);
            // property 
            b.Property(x => x.NombreIglesia).IsRequired().HasMaxLength(200);
            b.Property(x => x.Direccion).IsRequired().HasMaxLength(1000);
            b.Property(x => x.Telefono).IsRequired().HasMaxLength(20);

            //foreig
            b.HasOne(x => x.Distrito).WithMany().HasForeignKey(f => f.IdDistrito);
        }
    }
}

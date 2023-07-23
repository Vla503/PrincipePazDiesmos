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
    public class DistritoMap : IEntityTypeConfiguration<Distrito>
    {
        public void Configure(EntityTypeBuilder<Distrito> b)
        {
            //key 
            b.HasKey(x => x.IdDistrito);
            //property
            b.Property(x => x.NombreDistrito).IsRequired().HasMaxLength(500);
            //foreig
            b.HasOne(x => x.Zona).WithMany().HasForeignKey(f => f.IdZona);
        }
    }
}

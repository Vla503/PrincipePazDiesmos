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
    partial class ZonaMap : IEntityTypeConfiguration<Zona>
    {
        public void Configure(EntityTypeBuilder<Zona> b)
        {
            //key 
            b.HasKey(x => x.IdZona);
            //property 
            b.Property(x => x.NombreZona).IsRequired().HasMaxLength(500);
        }
    }
}

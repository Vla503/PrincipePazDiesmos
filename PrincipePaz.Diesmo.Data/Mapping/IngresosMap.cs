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
    public class IngresosMap : IEntityTypeConfiguration<Ingresos>
    {
        public void Configure(EntityTypeBuilder<Ingresos> b)
        {
            //key
            b.HasKey(x => x.IdIngreso);
            //property
            b.Property(x => x.Monto).IsRequired().HasPrecision(18,2);
            //foreig
            b.HasOne(x => x.RegistroDiesmo).WithMany().HasForeignKey(f => f.IdDiesmo);
        }
    }
}

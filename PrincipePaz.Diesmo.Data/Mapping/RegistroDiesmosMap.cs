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
    public class RegistroDiesmosMap : IEntityTypeConfiguration<RegistroDiesmos>
    {
        public void Configure(EntityTypeBuilder<RegistroDiesmos> b)
        {
            //key
            b.HasKey(x => x.IdDiesmo);
            //property
            b.Property(x => x.TotalIngreso).IsRequired(false).HasPrecision(18,2);
            //foreig
            b.HasOne(x => x.Pastor).WithMany().HasForeignKey(f => f.IdPastor);
        }
    }
}

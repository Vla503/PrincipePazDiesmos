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
    public class SessionMap : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> b)
        {
            b.HasKey(x => x.IdSession);
            //property 
            b.Property(x => x.DireccionSesion).IsRequired().HasMaxLength(1000);
            //foreig
            b.HasOne(x => x.Zona).WithMany().HasForeignKey(f => f.IdZona);

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Model
{
    public class RegistroDiesmos
    {
        public int IdDiesmo { get; set; }
        public int Correlativo { get; set; }
        public int IdPastor { get; set; }
        public Pastor Pastor { get; set; }
        public DateTimeOffset FechaIngreso { get; set; }
        public List<Ingresos> Ingresos { get; set; }
        public decimal? TotalIngreso { get; set; }
    }
}

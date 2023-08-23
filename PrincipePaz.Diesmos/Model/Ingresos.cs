using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Model
{
    public class Ingresos
    {
        public int IdIngreso { get; set; }
        public int IdDiesmo { get; set; }
        public RegistroDiesmos RegistroDiesmo { get; set; }
        public decimal Monto { get; set; }
        public Concepto Concepto { get; set; }
    }
}

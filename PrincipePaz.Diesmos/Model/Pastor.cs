using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Model
{
    public class Pastor
    {
        public Pastor(string nombrePastor, string telefono, string dui, string nit)
        {
            NombrePastor = nombrePastor;
            Telefono = telefono;
            Dui = dui;
            Nit = nit;
        }
        public int IdPastor { get; set; }
        public string NombrePastor { get; set; }
        public string Telefono { get; set; }
        public string Dui { get; set; }
        public string Nit { get; set; }
        public int IdIglesia { get; set; }
        public Iglesia? Iglesia { get; set; }
        public DateTimeOffset FechaIngreso { get; set; }
    }
}

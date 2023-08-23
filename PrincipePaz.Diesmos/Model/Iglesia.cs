using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Model
{
    public class Iglesia
    {
        public Iglesia(Distrito distrito, string nombreIglesia, string direccion, string telefono)
        {
            Distrito = distrito;
            NombreIglesia = nombreIglesia;
            Direccion = direccion;
            Telefono = telefono;
        }
        public int idIglesia { get; set; }
        public string NombreIglesia { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public Municipio Municipio { get; set; }
        public Departamento Departamento { get; set; }
        public Distrito Distrito { get; set; }
        public int IdDistrito { get; set; }
    }
}

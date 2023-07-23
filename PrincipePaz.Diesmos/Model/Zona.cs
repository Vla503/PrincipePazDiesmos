using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Model
{
    public class Zona
    {
        public Zona(string nomberZona)
        {
            NombreZona = nomberZona;
        }
        public int IdZona { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string NombreZona { get; set; }
    }
}

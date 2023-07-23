using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Model
{
    public class Distrito
    {
        public Distrito(string nombreDistrito, Zona zona)
        {
            NombreDistrito = nombreDistrito;
            Zona = zona;
        }
        /// <summary>
        /// id distrito
        /// </summary>
        public int IdDistrito { get; set; }
        /// <summary>
        /// nombre del distrito
        /// </summary>
        public string NombreDistrito { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int IdZona { get; set; }
        /// <summary>
        /// zona a la cual esta asociado
        /// </summary>
        public Zona Zona { get; set; }
    }
}

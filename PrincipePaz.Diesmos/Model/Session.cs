using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Model
{
    public class Session
    {
        public Session(Zona zona, string direccionSession)
        {
            Zona = zona;
            DireccionSesion = direccionSession;
        }
        public int IdSession { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int IdZona { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Zona Zona { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTimeOffset FechaIngreso { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string DireccionSesion { get; set; }
        /// <summary>
        /// cada session tiene una lista de diesmos
        /// </summary>
        public List<RegistroDiesmos>? Diesmos { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal  TotalSession { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public EstadoSession Estado { get; set; }

    }
}

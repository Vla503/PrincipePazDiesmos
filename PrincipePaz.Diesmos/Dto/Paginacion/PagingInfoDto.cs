using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Dto.Paginacion
{
    public class PagingInfoDto
    {
        public PagingInputDto PagingInput { get; set; }
        /// <summary>
        /// Determina el total de items registrado
        /// </summary>
        public int TotalItems { get; set; }

        /// <summary>
        /// determina el total de paginas segun el total de registros y cuanto seran mostrados
        /// </summary>
        public int TotalPages
        {
            get { return (int)Math.Ceiling((decimal)TotalItems / PagingInput.ItemsPerPage); }
        }
    }
}

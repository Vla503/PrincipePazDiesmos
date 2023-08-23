using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Dto.Paginacion
{
    /// <summary>
    /// Informacion de pagina actual y cantidad de itens a solicitar por pagina
    /// </summary>
    public class PagingInputDto
    {
        /// <summary>
        /// pagina actual a ver en una lista paginada
        /// </summary>
        public int CurrentPage { get; set; }
        /// <summary>
        /// cantidad de items a mostrar por pagina
        /// </summary>
        public int ItemsPerPage { get; set; }
    }

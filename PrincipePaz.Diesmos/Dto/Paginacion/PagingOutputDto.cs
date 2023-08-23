using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Dto.Paginacion
{
    public class PagingOutputDto<TEntity> where TEntity : class
    {
        public PagingOutputDto(List<TEntity> listadoPaginado, int totalItems)
        {
            ListadoPaginado = listadoPaginado;
            TotalItems = totalItems;
        }

        /// <summary>
        /// Listado paginado de la entidad
        /// </summary>
        public List<TEntity> ListadoPaginado { get; set; }

        /// <summary>
        /// Total de items
        /// </summary>
        public int TotalItems { get; set; }
    }
}
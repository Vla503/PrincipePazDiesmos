using PrincipePaz.Diesmos.Dto.Paginacion;
using PrincipePaz.Diesmos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Data
{
    public interface IZonaRepository : IBaseRepository<int, Zona>
    {
        /// <summary>
        /// metodo para paginar zonas
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pagingData"></param>
        /// <returns></returns>
        Task<PagingOutputDto<Zona>> GetZonaPaginadas(string name, PagingInputDto pagingData);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task<List<Zona>> GetZonas();
    }
}

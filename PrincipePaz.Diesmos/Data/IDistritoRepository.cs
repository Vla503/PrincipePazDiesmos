using PrincipePaz.Diesmos.Dto.Paginacion;
using PrincipePaz.Diesmos.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Data
{
    public interface IDistritoRepository : IBaseRepository<int, Distrito>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="pagingData"></param>
        /// <returns></returns>
        Task<PagingOutputDto<Distrito>> GetDistritoPaginado(string name, PagingInputDto pagingData);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="idZona"></param>
        /// <returns></returns>
        Task<List<Distrito>> GetDistritoByIdZona(string idZona);

    }
}

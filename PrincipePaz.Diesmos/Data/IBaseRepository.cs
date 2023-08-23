using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrincipePaz.Diesmos.Data
{
    public interface IBaseRepository<TKey, TEntity>
    {

        /// <summary>
        /// 
        /// </summary>
        /// <param name="entidad"></param>
        /// <returns></returns>
        Task AddAsync(TEntity entidad);

        /// <summary>
        /// Saca por su id una entidad
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<TEntity> GetById(TKey id);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Remove(TEntity entity);


        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        Task SaveChangesAsync();
    }
}

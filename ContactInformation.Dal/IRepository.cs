using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ContactInformation.Dal
{
    /// <summary>
    /// Generic repository to work with generic entity Db operations 
    /// </summary>
    /// <typeparam name="TEntity"></typeparam>
    public interface IRepository<TEntity>
    {
        /// <summary>
        /// Insert generic entity object 
        /// </summary>
        /// <param name="entity"></param>
        void Insert(TEntity entity);

        /// <summary>
        /// Delete generic entity object 
        /// </summary>
        /// <param name="id"></param>
        void Delete(object id);

        /// <summary>
        ///Update generic entity object 
        /// </summary>
        /// <param name="entityToUpdate"></param>
        void Update(TEntity entityToUpdate);

        /// <summary>
        /// Save chages to Db
        /// </summary>
        void Save();

        /// <summary>
        /// Generic to get entity list 
        /// </summary>
        /// <param name="filter"></param>
        /// <param name="orderBy"></param>
        /// <param name="includeProperties"></param>
        /// <returns></returns>
        IEnumerable<TEntity> Get(
        Expression<Func<TEntity, bool>> filter = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        string includeProperties = "");

    }
}

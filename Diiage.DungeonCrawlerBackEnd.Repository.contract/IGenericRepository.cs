using Diiage.DungeonCrawlerBackEnd.Entity;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Diiage.DungeonCrawlerBackEnd.Repository.Contract
{
    public interface IGenericRepository<TEntity> where TEntity : IEntity
    {

        #region CREATE
        /// <summary>
        /// 
        /// </summary>
        /// <param name="entity"></param>
        void Add(TEntity entity);

        void Add(IEnumerable<TEntity> entities);
        #endregion


        #region READ

        TEntity GetById(params object[] keyValues);

        TEntity GetFirstOrDefault(
        Expression<Func<TEntity, bool>> predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
        bool disableTracking = true
        );

        IEnumerable<TEntity> GetMuliple(
        Expression<Func<TEntity, bool>> predicate = null,
        Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
        Func<IQueryable<TEntity>, IIncludableQueryable<TEntity, object>> include = null,
        bool disableTracking = true
        );

        IQueryable<TEntity> GetAll();


        IQueryable<TEntity> FromSql(string sql, params object[] parameters);
        #endregion


        #region UPDATE

        void Update(TEntity entity);

        void Update(IEnumerable<TEntity> entities);

        #endregion


        #region DELETE

        void Delete(object id);

        void Delete(TEntity entityToDelete);

        void Delete(IEnumerable<TEntity> entities);

        #endregion

    }
}

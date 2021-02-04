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
        /// Allow to create an object
        /// </summary>
        /// <param name="entity">objct we want to create</param>
        void Add(TEntity entity);
        /// <summary>
        /// Allow to create objctes
        /// </summary>
        /// <param name="entities">objects we want to create</param>
        void Add(IEnumerable<TEntity> entities);
        #endregion


        #region READ
        /// <summary>
        /// Allow to get an object
        /// </summary>
        /// <param name="keyValues">id of the object we want</param>
        /// <returns>the object we want</returns>
        TEntity GetById(params object[] keyValues);

        /// <summary>
        /// Get all specified objects
        /// </summary>
        /// <returns>objects we want</returns>
        IQueryable<TEntity> GetAll();


        #endregion


        #region UPDATE
        /// <summary>
        /// Allow to update an object
        /// </summary>
        /// <param name="entity">object we want to update</param>
        void Update(TEntity entity);
        /// <summary>
        /// Allow to update objects
        /// </summary>
        /// <param name="entities">objects we want to update</param>
        void Update(IEnumerable<TEntity> entities);

        #endregion


        #region DELETE
        /// <summary>
        /// Allow to delete an object
        /// </summary>
        /// <param name="id">id of the object we want to delete</param>
        void Delete(object id);

        /// <summary>
        /// Allow to delete object
        /// </summary>
        /// <param name="entityToDelete">object we want to delete</param>
        void Delete(TEntity entityToDelete);

        /// <summary>
        /// Allow to delete objects
        /// </summary>
        /// <param name="entities">list of objects we want to delete</param>
        void Delete(IEnumerable<TEntity> entities);

        #endregion

    }
}

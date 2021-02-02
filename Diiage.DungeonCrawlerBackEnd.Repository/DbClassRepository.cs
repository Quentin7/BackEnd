using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Diiage.DungeonCrawlerBackEnd.Entity;
using Diiage.DungeonCrawlerBackEnd.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace Diiage.DungeonCrawlerBackEnd.Repository
{
    class DbClassRepository : IClassRepository
    {

        
        public void Add(Class @class)
        {             
        }

        public void Add(IEnumerable<Class> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Class entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<Class> entities)
        {
            throw new NotImplementedException();
        }

        public Class Find(int id)
        {
            Class i = new Class();  // c'est pas beau ça
            return i;
        }

        public IQueryable<Class> FromSql(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Class> GetAll()
        {
            throw new NotImplementedException();
        }

        public Class GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Class GetFirstOrDefault(Expression<Func<Class, bool>> predicate = null, Func<IQueryable<Class>, IOrderedQueryable<Class>> orderBy = null, Func<IQueryable<Class>, IIncludableQueryable<Class, object>> include = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Class> GetMuliple(Expression<Func<Class, bool>> predicate = null, Func<IQueryable<Class>, IOrderedQueryable<Class>> orderBy = null, Func<IQueryable<Class>, IIncludableQueryable<Class, object>> include = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public void Update(Class entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Class> entities)
        {
            throw new NotImplementedException();
        }
    }
}

using Diiage.DungeonCrawlerBackEnd.Entity;
using Diiage.DungeonCrawlerBackEnd.Repository.Contract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Diiage.DungeonCrawlerBackEnd.Repository
{
    class DbUserRepository : IUserRepository
    {
        public void Add(User entity)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(User entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> FromSql(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IQueryable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public User GetFirstOrDefault(Expression<Func<User, bool>> predicate = null, Func<IQueryable<User>, IOrderedQueryable<User>> orderBy = null, Func<IQueryable<User>, IIncludableQueryable<User, object>> include = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetMuliple(Expression<Func<User, bool>> predicate = null, Func<IQueryable<User>, IOrderedQueryable<User>> orderBy = null, Func<IQueryable<User>, IIncludableQueryable<User, object>> include = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public void Update(User entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<User> entities)
        {
            throw new NotImplementedException();
        }
    }
}

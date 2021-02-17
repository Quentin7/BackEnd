using Diiage.DungeonCrawlerBackEnd.Entity;
using Diiage.DungeonCrawlerBackEnd.Entity.Context;
using Diiage.DungeonCrawlerBackEnd.Repository.Contract;
using Microsoft.EntityFrameworkCore.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Diiage.DungeonCrawlerBackEnd.Repository
{
    public class DbCharacterRepository : ICharacterRepository
    {
        public DungeonCrawlerDbContext DbContext => throw new NotImplementedException();

        public void Add(Character entity)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<Character> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Character entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<Character> entities)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Character> FromSql(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Character> GetAll()
        {
            throw new NotImplementedException();
        }

        public Character GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Character GetFirstOrDefault(Expression<Func<Character, bool>> predicate = null, Func<IQueryable<Character>, IOrderedQueryable<Character>> orderBy = null, Func<IQueryable<Character>, IIncludableQueryable<Character, object>> include = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Character> GetMuliple(Expression<Func<Character, bool>> predicate = null, Func<IQueryable<Character>, IOrderedQueryable<Character>> orderBy = null, Func<IQueryable<Character>, IIncludableQueryable<Character, object>> include = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Character entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Character> entities)
        {
            throw new NotImplementedException();
        }
    }
}

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
    public class DbPotionRepository : IPotionRepository
    {
        public DungeonCrawlerDbContext DbContext => throw new NotImplementedException();

        public void Add(Potion entity)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<Potion> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Potion entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<Potion> entities)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Potion> FromSql(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Potion> GetAll()
        {
            throw new NotImplementedException();
        }

        public Potion GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Potion GetFirstOrDefault(Expression<Func<Potion, bool>> predicate = null, Func<IQueryable<Potion>, IOrderedQueryable<Potion>> orderBy = null, Func<IQueryable<Potion>, IIncludableQueryable<Potion, object>> include = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Potion> GetMuliple(Expression<Func<Potion, bool>> predicate = null, Func<IQueryable<Potion>, IOrderedQueryable<Potion>> orderBy = null, Func<IQueryable<Potion>, IIncludableQueryable<Potion, object>> include = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Potion entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Potion> entities)
        {
            throw new NotImplementedException();
        }
    }
}

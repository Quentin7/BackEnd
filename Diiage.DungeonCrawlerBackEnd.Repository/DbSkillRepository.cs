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
    class DbSkillRepository : ISkillRepository
    {
        public DungeonCrawlerDbContext DbContext => throw new NotImplementedException();

        public void Add(Skill entity)
        {
            throw new NotImplementedException();
        }

        public void Add(IEnumerable<Skill> entities)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Skill entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Delete(IEnumerable<Skill> entities)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IQueryable<Skill> FromSql(string sql, params object[] parameters)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Skill> GetAll()
        {
            throw new NotImplementedException();
        }

        public Skill GetById(params object[] keyValues)
        {
            throw new NotImplementedException();
        }

        public Skill GetFirstOrDefault(Expression<Func<Skill, bool>> predicate = null, Func<IQueryable<Skill>, IOrderedQueryable<Skill>> orderBy = null, Func<IQueryable<Skill>, IIncludableQueryable<Skill, object>> include = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Skill> GetMuliple(Expression<Func<Skill, bool>> predicate = null, Func<IQueryable<Skill>, IOrderedQueryable<Skill>> orderBy = null, Func<IQueryable<Skill>, IIncludableQueryable<Skill, object>> include = null, bool disableTracking = true)
        {
            throw new NotImplementedException();
        }

        public int Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Skill entity)
        {
            throw new NotImplementedException();
        }

        public void Update(IEnumerable<Skill> entities)
        {
            throw new NotImplementedException();
        }
    }
}

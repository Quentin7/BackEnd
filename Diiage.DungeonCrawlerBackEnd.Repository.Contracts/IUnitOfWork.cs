using Diiage.DungeonCrawlerBackEnd.Repository.Contract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diiage.DungeonCrawlerBackEnd.Entity
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        TContext DbContext { get; }
        int Save();
    }
}

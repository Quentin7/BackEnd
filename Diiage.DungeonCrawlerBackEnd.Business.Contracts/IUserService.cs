using Diiage.DungeonCrawlerBackEnd.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diiage.DungeonCrawlerBackEnd.Business.Contracts
{
    public interface IUserService
    {
        User FindByMail(string email);
    }
}

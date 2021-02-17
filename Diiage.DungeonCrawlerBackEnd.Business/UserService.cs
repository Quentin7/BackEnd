using Diiage.DungeonCrawlerBackEnd.Business.Contracts;
using Diiage.DungeonCrawlerBackEnd.Entity;
using Diiage.DungeonCrawlerBackEnd.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diiage.DungeonCrawlerBackEnd.Business
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public User FindByMail(string email)
        {
            return _userRepository.FindByMail(email);
        }
    }
}

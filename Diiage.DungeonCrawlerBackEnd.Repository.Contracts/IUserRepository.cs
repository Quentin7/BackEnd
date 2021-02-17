using Diiage.DungeonCrawlerBackEnd.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Diiage.DungeonCrawlerBackEnd.Repository.Contract
{
    public interface IUserRepository : IGenericRepository<User>
    {
        void SignIn(User user);
        void SignOut();
        void ResetPassword(User user, User newPassword);
        User FindByMail(string email);
        bool PasswordValidation(string password);
    }
}

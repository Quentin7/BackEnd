using Diiage.DungeonCrawlerBackEnd.Business.Contracts;
using Diiage.DungeonCrawlerBackEnd.Entity;
using Diiage.DungeonCrawlerBackEnd.Repository.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Diiage.DungeonCrawlerBackEnd.Business
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly IUserRepository _userRepository; 

        /// <summary>
        /// Allow register an user
        /// </summary>
        /// <param name="user">user we want to register</param>
        public void Register(User user)
        {
            _userRepository.Add(user);
        }

        /// <summary>
        /// Allow to reset the password of an user
        /// </summary>
        public void ResetPassword(User user, User newPassword)
        {
            _userRepository.ResetPassword(user, newPassword);
        }

        public void SignIn(User user)
        {
            _userRepository.SignIn(user);
        }

        public void SignOut()
        {
            _userRepository.SignOut();
        }
    }
}

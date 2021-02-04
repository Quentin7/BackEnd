using Diiage.DungeonCrawlerBackEnd.Business.Contracts;
using Diiage.DungeonCrawlerBackEnd.Entity;
using Microsoft.AspNetCore.Mvc;

namespace Diiage.DungeonCrawlerBackEnd.WebApplication.Controllers
{
    public class AuthentificationController : Controller
    {
        private IAuthentificationService _authentificationService;

        /// <summary>
        /// Allow to register a new user
        /// </summary>
        /// <param name="user">user we want to register</param>
        [HttpPost]
        public void Register(User user)
        {
            _authentificationService.Register(user);
        }

        /// <summary>
        /// Allow to connect an user
        /// </summary>
        [HttpPost]
        public void SignIn()
        {
            _authentificationService.SignIn();
        }
        
        /// <summary>
        /// Allow to disconnect an user
        /// </summary>
        [HttpPost]
        public void Disconnect()
        {
            _authentificationService.SignOut();
        }

        /// <summary>
        /// Allow to reset the password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newPassword"></param>
        [HttpPost]
        public void ResetPassord(User user, User newPassword)
        {
            _authentificationService.ResetPassword(user, newPassword);
        }
    }
}

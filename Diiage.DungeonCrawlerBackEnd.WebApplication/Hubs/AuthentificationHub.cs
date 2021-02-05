using Diiage.DungeonCrawlerBackEnd.Business.Contracts;
using Diiage.DungeonCrawlerBackEnd.Entity;
using Microsoft.AspNetCore.SignalR;

namespace Diiage.DungeonCrawlerBackEnd.WebApplication.Hubs
{
    public class AuthentificationHub : Hub<IAuthentificationService>
    {
        private readonly IAuthentificationService _authService;

        /// <summary>
        /// method to register an user
        /// </summary>
        /// <param name="user"></param>
        void Register(User user)
        {
            _authService.Register(user);
        }

        /// <summary>
        /// method to sign in
        /// </summary>
        /// <param name="user"></param>
        void SignIn(User user)
        {
            //_authService.SignIn(user);
        }

        /// <summary>
        /// method to sign out
        /// </summary>
        /// <param name="user"></param>
        void SignOut(User user)
        {
            //_authService.SignOut(user);
        }

        /// <summary>
        /// method to reset the password
        /// </summary>
        /// <param name="user"></param>
        /// <param name="newPassword"></param>
        void ResetPassword(User user, User newPassword)
        {
            _authService.ResetPassword(user, newPassword);
        }
    }
}

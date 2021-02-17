using Diiage.DungeonCrawlerBackEnd.Entity;

namespace Diiage.DungeonCrawlerBackEnd.Business.Contracts
{
    public interface IAuthentificationService
    {
        void Register(User user);
        void SignIn(User user);
        void SignOut();
        void ResetPassword(User user, User newPassword);
    }
}

using Diiage.DungeonCrawlerBackEnd.Entity;

namespace Diiage.DungeonCrawlerBackEnd.Business.Contracts
{
    public interface IAuthentificationService
    {
        void Register(User user);
        void SignIn();
        void SignOut();
        void ResetPassword(User user, User newPassword);
    }
}

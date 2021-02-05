using Diiage.DungeonCrawlerBackEnd.Entity;
using Diiage.DungeonCrawlerBackEnd.Repository.Contract;

namespace Diiage.DungeonCrawlerBackEnd.Business.Contracts
{
    public interface IAuthentificationService //: IUserRepository
    {
        void Register(User user);
        void SignIn();
        void SignOut();
        void ResetPassword(User user, User newPassword);
        User VerificationEMail(string eMail);
    }
}

using System.Collections.Generic;

namespace Diiage.DungeonCrawlerBackEnd.Entity
{
    public class User : IEntity
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserEMail { get; set; }
        public string UserPasswordHash { get; set; }
        public string UserPasswordSalt { get; set; }
        public IEnumerable<Character> UserCharacters { get; set; }

        public User()
        {
            this.UserCharacters = new List<Character>();
        }

        public User( string name, string email, string passwordHash, string passwordSalt)
        {
            this.UserName = name;
            this.UserEMail = email;
            this.UserPasswordHash = passwordHash;
            this.UserPasswordSalt = passwordSalt;
            this.UserCharacters = new List<Character>();
        }
    }
}

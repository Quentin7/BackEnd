using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Diiage.DungeonCrawlerBackEnd.Entity
{
    public class User : IEntity
    {
        public string UserFirstname { get; set; }
        public string UserLastname { get; set; }
        [Required]
        public string UserEMail { get; set; }
        [Required]
        public string UserPasswordHash { get; set; }
        public string UserPasswordSalt { get; set; }
        public IEnumerable<Character> UserCharacters { get; set; }

        public User()
        {
            this.UserCharacters = new List<Character>();
        }

        public User( string firstname, string lastname, string email, string passwordHash, string passwordSalt)
        {
            this.UserFirstname = firstname;
            this.UserLastname = lastname;
            this.UserEMail = email;
            this.UserPasswordHash = passwordHash;
            this.UserPasswordSalt = passwordSalt;
            this.UserCharacters = new List<Character>();
        }
    }
}

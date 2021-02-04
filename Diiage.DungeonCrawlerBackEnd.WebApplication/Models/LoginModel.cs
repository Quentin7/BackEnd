using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diiage.DungeonCrawlerBackEnd.WebApplication.Models
{
    public class LoginModel
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }

    }
}

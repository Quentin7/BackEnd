using Diiage.DungeonCrawlerBackEnd.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Diiage.DungeonCrawlerBackEnd.WebApplication.Models
{
    public class CharacterModel
    {
        public String CharacterName { get; set; }
        public User CharacterUser { get; set; }
        public Class CharacterClass { get; set; }
    }
}

using System.Collections.Generic;
using System.Linq;

namespace Diiage.DungeonCrawlerBackEnd.Entity.Context
{
    public class SeedDataLocal
    {
        public static void Initialize()
        {
            using (var context = new DungeonCrawlerDbContext() )
            {
                SeedCharacter(context);
            }
        }
        
        public static void SeedCharacter(DungeonCrawlerDbContext context)
        {
            if (!context.Characters.Any())
            {
                var characters = Factory.CreateCharacter();
                List<Character> characterDb = new List<Character>();

                foreach (var item in characters)
                {
                    var c = new Character(item.CharacteId, item.CharacterName, item.CharacterClassId, item.CharacterLvl, item.CharacterXp, item.CharacterHp, item.CharacterStr, item.CharacterSta, item.CharacterInt, item.CharacterAgi, item.CharacterSpe, item.CharacterUserId);
                    characterDb.Add(c);
                }
                context.AddRange(characterDb);
                //context.SaveChanges();
            }
        }
    }
}

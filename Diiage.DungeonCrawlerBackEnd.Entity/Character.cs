using System.Collections.Generic;

namespace Diiage.DungeonCrawlerBackEnd.Entity
{
    public class Character : IEntity
    {
        public int CharacteId { get; set; }
        public string CharacterName { get; set; }
        public int CharacterClassId { get; set; }
        public Class CharacterClass { get; set; }
        public int CharacterLvl { get; set; }
        public int CharacterXp { get; set; }
        public int CharacterNbPotion { get; set; }
        public IEnumerable<Potion> CharacterPotions { get; set; }
        public int CharacterHp { get; set; }
        public int CharacterStr { get; set; }
        public int CharacterSta { get; set; }
        public int CharacterInt { get; set; }
        public int CharacterAgi { get; set; }
        public int CharacterSpe { get; set; }
        public int CharacterUserId { get; set; }
        public User CharacterUser { get; set; }

        public Character()
        {
            this.CharacterPotions = new List<Potion>();
        }
        public Character(int id, string name, int classId, int lvl, int xp, int hp, int str, int sta, int @int, int agi, int Spe, int userId )
        {
            this.CharacteId = id;
            this.CharacterName = name;
            this.CharacterClassId = classId;
            this.CharacterLvl = lvl;
            this.CharacterXp = xp;
            this.CharacterHp = hp;
            this.CharacterStr = str;
            this.CharacterSta = sta;
            this.CharacterInt = @int;
            this.CharacterAgi = agi;
            this.CharacterSpe = Spe;
            this.CharacterUserId = userId;
        }

    }
}

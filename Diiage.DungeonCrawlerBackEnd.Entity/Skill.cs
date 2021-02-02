using System;
using System.Collections.Generic;
using System.Text;

namespace Diiage.DungeonCrawlerBackEnd.Entity
{
    public class Skill : IEntity
    {
        public int SkillId { get; set; }
        public string SkillName { get; set; }
        public int SkillNbTurn { get; set; }
        public int SkillDamage { get; set; }
        public int SkillLvlUnlock { get; set; }
        public bool SkillTarget { get; set; }
        public int SkillLocation { get; set; }
        public int SkillClassId { get; set; }
        public Class SkillClass { get; set; }

        public Skill()
        {

        }
        public Skill(int id, string name, int nbTurn, int damage, int lvlUnlock, bool Target, int skillLocation)
        {
            this.SkillId = id;
            this.SkillName = name;
            this.SkillNbTurn = nbTurn;
            this.SkillDamage = damage;
            this.SkillLvlUnlock = lvlUnlock;
            this.SkillLocation = skillLocation;
        }

    }
}

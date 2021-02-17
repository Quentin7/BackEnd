using System.Collections.Generic;

namespace Diiage.DungeonCrawlerBackEnd.Entity
{
    public class Class : IEntity
    {
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string ClassRole { get; set; }
        public int ClassBaseHp { get; set; }
        public int ClassLvlUpHp { get; set; }
        public int ClassBaseStr { get; set; }
        public int ClassLvlUpStr { get; set; }
        public int ClassBaseSta { get; set; }
        public int ClassLvlUpSta { get; set; }
        public int ClassBaseInt { get; set; }
        public int ClassLvlUpInt { get; set; }
        public int ClassBaseAgi { get; set; }
        public int ClassLvlUpAgi { get; set; }
        public int ClassBaseSpe { get; set; }
        public int ClassLvlUpSpe { get; set; }
        public IEnumerable<Skill> ClassSkills { get; set; }
        public IEnumerable<Character> ClassCharacters { get; set; }

        public Class()
        {
            this.ClassSkills = new List<Skill>();
        }

        public Class(int id, string name, string role, int baseHp, int LvlUpHp, int baseStr, int LvlUpStr, int baseSta, int LvlUpSta, int baseInt, int LvlUpInt, int baseAgi, int LvlUpAgi, int baseSpe, int LvlUpSpe)
        {
            this.ClassId = id;
            this.ClassName = name;
            this.ClassRole = role;
            this.ClassBaseHp = baseHp;
            this.ClassLvlUpHp = LvlUpHp;
            this.ClassBaseStr = baseStr;
            this.ClassLvlUpStr = LvlUpStr;
            this.ClassBaseSta = baseSta;
            this.ClassLvlUpSta = LvlUpSta;
            this.ClassBaseInt = baseInt;
            this.ClassLvlUpInt = LvlUpInt;
            this.ClassBaseAgi = baseAgi;
            this.ClassLvlUpAgi = LvlUpAgi;
            this.ClassBaseSpe = baseSpe;
            this.ClassLvlUpSpe = LvlUpSpe;
            this.ClassSkills = new List<Skill>();
        }
    }

   
}

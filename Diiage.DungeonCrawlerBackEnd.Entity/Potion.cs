using System;
using System.Collections.Generic;
using System.Text;

namespace Diiage.DungeonCrawlerBackEnd.Entity
{
    public class Potion : IEntity
    {
        public int PotionId { get; set; }
        public string PotionName { get; set; }
        public int PotionHeal { get; set;  }

        public Potion()
        {

        }

        public Potion(int id, string name, int heal)
        {
            this.PotionId = id;
            this.PotionName = name;
            this.PotionHeal = heal;
        }
    }
}

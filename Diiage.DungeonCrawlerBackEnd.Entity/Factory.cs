using System;
using System.Collections.Generic;
using System.Text;

namespace Diiage.DungeonCrawlerBackEnd.Entity
{
    public static class Factory
    {
        public static List<User> Users { get; set; }
        public static List<Character> Characters { get; set; }
        public static List<Class> Classes { get; set; }
        public static List<Potion> Potions { get; set; }
        public static List<Skill> Skills { get; set; }

        static Factory()
        {
            Users = new List<User>();

            User user1 = new User( "Henry", "salut@salut.mail", "", "");
            User user2 = new User( "Sally", "salut@salut.mail", "", "");

            Class Warrior = new Class 
            {
                ClassId = 1,
                ClassName = "Warrior",
                ClassRole = "Player",
                ClassBaseHp = 60,
                ClassLvlUpHp = 6,   // ya un probleme
                ClassBaseStr = 10,
                ClassLvlUpStr = 3,
                ClassBaseSta = 10,
                ClassLvlUpSta = 3,
                ClassBaseInt = 3,
                ClassLvlUpInt = 1,
                ClassBaseAgi = 7,
                ClassLvlUpAgi = 1,
                ClassBaseSpe = 8, // à faire valider
                ClassLvlUpSpe = 2, // à faire valider
            };
            Class shaman = new Class
            {
                ClassId = 2,
                ClassName = "Shaman",
                ClassRole = "Player",
                ClassBaseHp = 50,
                ClassLvlUpHp = 6,   // ya un probleme
                ClassBaseStr = 7,
                ClassLvlUpStr = 1,
                ClassBaseSta = 8,
                ClassLvlUpSta = 2,
                ClassBaseInt = 5,
                ClassLvlUpInt = 3,
                ClassBaseAgi = 10,
                ClassLvlUpAgi = 2,
                ClassBaseSpe = 11, // à faire valider
                ClassLvlUpSpe = 2, // à faire valider
            }; 
            Class wizard = new Class
            {
                ClassId = 3,
                ClassName = "Wizard",
                ClassRole = "Player",
                ClassBaseHp = 45,
                ClassLvlUpHp = 6,   // ya un probleme
                ClassBaseStr = 7,
                ClassLvlUpStr = 1,
                ClassBaseSta = 6,
                ClassLvlUpSta = 2,
                ClassBaseInt = 12,
                ClassLvlUpInt = 3,
                ClassBaseAgi = 5,
                ClassLvlUpAgi = 1,
                ClassBaseSpe = 6, // à faire valider
                ClassLvlUpSpe = 2, // à faire valider
            };
            Class goblin = new Class
            {
                ClassId = 4,
                ClassName = "Goblin",
                ClassRole = "Monster",
                ClassBaseHp = 30,
                ClassLvlUpHp = 6,   // ya un probleme
                ClassBaseStr = 5,
                ClassLvlUpStr = 1,
                ClassBaseSta = 5,
                ClassLvlUpSta = 1,
                ClassBaseInt = 8,
                ClassLvlUpInt = 2,
                ClassBaseAgi = 12,
                ClassLvlUpAgi = 3,
                ClassBaseSpe = 13, // à faire valider
                ClassLvlUpSpe = 3, // à faire valider
            };
            Class necromancer = new Class
            {
                ClassId = 5,
                ClassName = "Necromancer",
                ClassRole = "Monster",
                ClassBaseHp = 40,
                ClassLvlUpHp = 0,   // ya un probleme
                ClassBaseStr = 9,
                ClassLvlUpStr = 2,
                ClassBaseSta = 6,
                ClassLvlUpSta = 2,
                ClassBaseInt = 12,
                ClassLvlUpInt = 2,
                ClassBaseAgi = 3,
                ClassLvlUpAgi = 1,
                ClassBaseSpe = 5, // à faire valider
                ClassLvlUpSpe = 2, // à faire valider
            };
            Class orc = new Class
            {
                ClassId = 6,
                ClassName = "Orc",
                ClassRole = "Monster",
                ClassBaseHp = 60,
                ClassLvlUpHp = 0,   // ya un probleme
                ClassBaseStr = 10,
                ClassLvlUpStr = 3,
                ClassBaseSta = 10,
                ClassLvlUpSta = 3,
                ClassBaseInt = 1,
                ClassLvlUpInt = 1,
                ClassBaseAgi = 9,
                ClassLvlUpAgi = 2,
                ClassBaseSpe = 11, // à faire valider
                ClassLvlUpSpe = 2, // à faire valider
            };
            Class bossWarrior = new Class
            {
                ClassId = 7,
                ClassName = "Warrior Boss",
                ClassRole = "Boss",
                ClassBaseHp = 80,
                ClassLvlUpHp = 0,   // ya un probleme
                ClassBaseStr = 12,
                ClassLvlUpStr = 3,
                ClassBaseSta = 12,
                ClassLvlUpSta = 3,
                ClassBaseInt = 8,
                ClassLvlUpInt = 1,
                ClassBaseAgi = 8,
                ClassLvlUpAgi = 1,
                ClassBaseSpe = 8, // à faire valider
                ClassLvlUpSpe = 3, // à faire valider
            };
            Class bossWizard = new Class
            {
                ClassId = 8,
                ClassName = "Wizard Boss",
                ClassRole = "Boss",
                ClassBaseHp = 60,
                ClassLvlUpHp = 0,   // ya un probleme
                ClassBaseStr = 10,
                ClassLvlUpStr = 3,
                ClassBaseSta = 12,
                ClassLvlUpSta = 4,
                ClassBaseInt = 12,
                ClassLvlUpInt = 5,
                ClassBaseAgi = 6,
                ClassLvlUpAgi = 1,
                ClassBaseSpe = 8, // à faire valider
                ClassLvlUpSpe = 2, // à faire valider
            };

            Character char1 = new Character
            { 
                CharacteId = 1,
                CharacterName = "Stregobor",
                CharacterClassId = 3,
                CharacterClass = wizard,
                CharacterLvl = 1,
                CharacterXp = 0,
                CharacterNbPotion = 0,
                CharacterHp =  wizard.ClassBaseHp + (1*wizard.ClassLvlUpHp*wizard.ClassLvlUpSta),
                CharacterStr = wizard.ClassBaseStr, 
                CharacterSta = wizard.ClassBaseSta,
                CharacterInt = wizard.ClassBaseInt,
                CharacterAgi = wizard.ClassBaseAgi,
                CharacterSpe = wizard.ClassBaseSpe,
                CharacterUserId = 1,
                CharacterUser = user1,

            };
            Character char2 = new Character
            {
                CharacteId = 2,
                CharacterName = "Maximus",
                CharacterClassId = 1,
                CharacterClass = Warrior,
                CharacterLvl = 1,
                CharacterXp = 0,
                CharacterNbPotion = 0,
                CharacterHp = Warrior.ClassBaseHp + (1 * Warrior.ClassLvlUpHp * Warrior.ClassLvlUpSta),
                CharacterStr = Warrior.ClassBaseStr,
                CharacterSta = Warrior.ClassBaseSta,
                CharacterInt = Warrior.ClassBaseInt,
                CharacterAgi = Warrior.ClassBaseAgi,
                CharacterSpe = Warrior.ClassBaseSpe,
                CharacterUserId = 2,
                CharacterUser = user2,

            };
            Character char3 = new Character
            {
                CharacteId = 2,
                CharacterName = "Pharetra",
                CharacterClassId = 1,
                CharacterClass = Warrior,
                CharacterLvl = 1,
                CharacterXp = 0,
                CharacterNbPotion = 0,
                CharacterHp = Warrior.ClassBaseHp + (1 * Warrior.ClassLvlUpHp * Warrior.ClassLvlUpSta),
                CharacterStr = Warrior.ClassBaseStr,
                CharacterSta = Warrior.ClassBaseSta,
                CharacterInt = Warrior.ClassBaseInt,
                CharacterAgi = Warrior.ClassBaseAgi,
                CharacterSpe = Warrior.ClassBaseSpe,
                CharacterUserId = 2,
                CharacterUser = user2,

            };

            Potion p1 = new Potion(1, "Petite potion", 50);
            Potion p2 = new Potion(2, "Potion moyenne", 100);
            Potion p3 = new Potion(3, "Grande potion", 200);

            Skill shieldStrike = new Skill
            {
                SkillId = 1,
                SkillName = "Shield strike",
                SkillNbTurn = 0,
                SkillDamage = 15,   // ça marche pas
                SkillLvlUnlock = 1,
                SkillTarget = true,
                SkillLocation = 1,
                SkillClass = Warrior,
            };
            Skill thunderClap = new Skill
            { };
            Skill revenge = new Skill
            { };
            Skill devastate = new Skill
            { };
            Skill multipleShots = new Skill
            { };
            Skill slay = new Skill
            { };


            Skill flameShock = new Skill
            { };
            Skill lightning = new Skill
            { };
            Skill lightningChain = new Skill
            { };
            Skill ancestralSpirit = new Skill
            { };
            Skill earthQuake = new Skill
            { };
            Skill lavaExplosion = new Skill
            { };


            Skill fireBold = new Skill
            { };
            Skill frotedBold = new Skill
            { };
            Skill arcaneExplosion = new Skill
            { };
            Skill frostedNova = new Skill
            { };
            Skill arcaneProjectile = new Skill
            { };
            Skill fireExplosion = new Skill
            { };
        }
        
        /// <summary>
        /// create datas of users
        /// </summary>
        /// <returns>a list of users</returns>
        public static IEnumerable<User> CreateUser()
        {
            Users = new List<User>()
            {
                new User( "Henry", "salut@salut.mail", "", ""),
                new User("Sally", "salut@salut.mail", "", ""),
            };
            
            return Users;
        }   
        /// <summary>
        /// create datas of characters
        /// </summary>
        /// <returns>a list of characters</returns>
        public static IEnumerable<Character> CreateCharacter()
        {
            Characters = new List<Character>()
            {
                new Character( 1, "Stregobor", 3, 1, 0, 45, 7, 6, 12, 5, 6, 1),
                new Character( 2, "Maximus", 1, 1, 0, 60, 10, 10, 3, 7, 8, 2),
                new Character( 3, "Pharetra", 2, 1, 0, 50, 7, 8, 5, 10, 11, 2),
            };
            
            return Characters;
        }
        /// <summary>
        /// create datas of classes
        /// </summary>
        /// <returns>a list of classes</returns>
        public static IEnumerable<Class> CreateClass()
        {
            Classes = new List<Class>()
            {
                new Class( 1, "Warrior", "Player", 60, 6, 10, 3, 10, 3, 3, 1, 7, 1, 8, 2),
                new Class( 2, "Shaman", "Player", 50, 6, 7, 1, 8, 2, 5, 3, 10, 2, 6, 1 ),
                new Class( 3, "Wizard", "Player", 45, 6, 7, 1, 6, 2, 12, 3, 5, 1, 6, 1)
            };
            
            return Classes;
        }
        /// <summary>
        /// create datas of potions
        /// </summary>
        /// <returns>a list of potions</returns>
        public static IEnumerable<Potion> CreatePotion()
        {
            Potions = new List<Potion>()
            {
                new Potion(1, "Petite potion", 50),
                new Potion(2, "Potion moyenne", 100),
                new Potion(3, "Grande potion", 200),
            };
            
            return Potions;
        }
        /// <summary>
        /// create datas of skills
        /// </summary>
        /// <returns>a list of skills</returns>
        public static IEnumerable<Skill> CreateSkill()
        {
            Skills = new List<Skill>()
            {
                new Skill( 1, "Shield strike", 0, 15, 1, false, 1),
                new Skill( 2, "Flame shock", 0, 14, 1, false, 1 ),
                new Skill( 3, "Fire bold", 0, 13, 1, false, 1  ),
                new Skill( 4, "Dynamite stick", 0, 12, 1, false, 1),
                new Skill( 5, "Sword strike", 0, 08, 1, false, 1),
                new Skill( 6, "Sword strike", 0, 07, 1, false, 1),
                new Skill( 7, "Fireball", 0, 07, 1, false, 1),
                new Skill( 8, "Melee", 0, 07, 1, false, 1)
            };
            
            return Skills;
        }
    }
}

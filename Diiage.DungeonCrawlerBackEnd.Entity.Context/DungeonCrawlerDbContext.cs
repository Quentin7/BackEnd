using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Diiage.DungeonCrawlerBackEnd.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Diiage.DungeonCrawlerBackEnd.Entity.Context
{
    public class DungeonCrawlerDbContext : DbContext
    {
        public static IConfiguration ConfigurationDb;

        public DungeonCrawlerDbContext() 
        {
        }
        public DungeonCrawlerDbContext( IConfiguration configuration)
        {
            ConfigurationDb = configuration;
        }

        public DbSet<Character> Characters { get; set; }
        public DbSet<Class> Classes { get; set; }
        public DbSet<Potion> Potions { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<User> Users { get; set; }

        readonly string connection = "Server = MSI; Database = DungeonCrawlerDbContext; User Id=user; Password=Azerty@123; Trusted_Connection = True; MultipleActiveResultSets = true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Character>().HasKey(c => new { c.CharacteId });
            modelBuilder.Entity<Character>().HasOne<Class>(c => c.CharacterClass).WithMany(d => d.ClassCharacters).HasForeignKey( k => k.CharacteId);

            modelBuilder.Entity<Class>().HasKey(c => new { c.ClassId });


            modelBuilder.Entity<Potion>().HasKey(p => new { p.PotionId });


            modelBuilder.Entity<Skill>().HasKey(s => new { s.SkillId });
            modelBuilder.Entity<Skill>().HasOne<Class>(c => c.SkillClass).WithMany(s => s.ClassSkills).HasForeignKey( k => k.SkillClassId);

            modelBuilder.Entity<User>().HasKey(u => new { u.UserEMail });


        }
    }
    
}

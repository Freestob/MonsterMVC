using MonsterMVC.Domain.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMVC.Data
{
    class MonsterDbInitializer : DropCreateDatabaseIfModelChanges<MonsterDbContext>
    {
        protected override void Seed(MonsterDbContext context)
        {
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 1,
                Name = "Aboleth",
                ChallengeRating = 10,
                UrlId = 1
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 2,
                Name = "Acolyte",
                ChallengeRating = .25f,
                UrlId = 2
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 3,
                Name = "Adult Black Dragon",
                ChallengeRating = 14,
                UrlId = 3
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 4,
                Name = "Adult Blue Dracolich",
                ChallengeRating = 17,
                UrlId = 4
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 5,
                Name = "Adult Blue Dracolich",
                ChallengeRating = 17,
                UrlId = 5
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 5,
                Name = "Adult Blue Dragon",
                ChallengeRating = 16,
                UrlId = 5
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 6,
                Name = "Adult Brass Dragon",
                ChallengeRating = 13,
                UrlId = 6
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 7,
                Name = "Adult Bronze Dragon",
                ChallengeRating = 15,
                UrlId = 7
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 8,
                Name = "Adult Copper Dragon",
                ChallengeRating = 14,
                UrlId = 8
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 9,
                Name = "Adult Gold Dragon",
                ChallengeRating = 17,
                UrlId = 9
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 10,
                Name = "Adult Green Dragon",
                ChallengeRating = 15,
                UrlId = 10
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 11,
                Name = "Adult Red Dragon",
                ChallengeRating = 17,
                UrlId = 11
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 12,
                Name = "Adult Silver Dragon",
                ChallengeRating = 16,
                UrlId = 12
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 13,
                Name = "Adult White Dragon",
                ChallengeRating = 13,
                UrlId = 13
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 14,
                Name = "Air Elemental",
                ChallengeRating = 5,
                UrlId = 14
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 15,
                Name = "Ancient Black Dragon",
                ChallengeRating = 21,
                UrlId = 15
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 16,
                Name = "Ancient Blue Dragon",
                ChallengeRating = 23,
                UrlId = 16
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 17,
                Name = "Ancient Brass Dragon",
                ChallengeRating = 20,
                UrlId = 17
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 18,
                Name = "Ancient Bronze Dragon",
                ChallengeRating = 22,
                UrlId = 18
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 19,
                Name = "Ancient Copper Dragon",
                ChallengeRating = 21,
                UrlId = 19
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 20,
                Name = "Ancient Gold Dragon",
                ChallengeRating = 24,
                UrlId = 20
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 21,
                Name = "Ancient Green Dragon",
                ChallengeRating = 22,
                UrlId = 21
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 22,
                Name = "Ancient Red Dragon",
                ChallengeRating = 24,
                UrlId = 22
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 23,
                Name = "Ancient Silver Dragon",
                ChallengeRating = 23,
                UrlId = 23
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 24,
                Name = "Ancient White Dragon",
                ChallengeRating = 20,
                UrlId = 24
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 25,
                Name = "Androsphinx",
                ChallengeRating = 17,
                UrlId = 25
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 26,
                Name = "Animated Armor",
                ChallengeRating = 1,
                UrlId = 26
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 27,
                Name = "Ankheg",
                ChallengeRating = 2,
                UrlId = 27
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 28,
                Name = "Ape",
                ChallengeRating = 0.5f,
                UrlId = 28
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 29,
                Name = "Archmage",
                ChallengeRating = 12,
                UrlId = 29
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 30,
                Name = "Assassin",
                ChallengeRating = 8,
                UrlId = 30
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 31,
                Name = "Awakened Shrub",
                ChallengeRating = 0,
                UrlId = 31
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 32,
                Name = "Awakened Tree",
                ChallengeRating = 2,
                UrlId = 32
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 33,
                Name = "Axe Beak",
                ChallengeRating = .25f,
                UrlId = 33
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 34,
                Name = "Azer",
                ChallengeRating = 2,
                UrlId = 34
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 35,
                Name = "Baboon",
                ChallengeRating = 0,
                UrlId = 35
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 36,
                Name = "Badger",
                ChallengeRating = 0,
                UrlId = 36
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 37,
                Name = "Balor",
                ChallengeRating = 19,
                UrlId = 37
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 38,
                Name = "Bandit",
                ChallengeRating = 0.125f,
                UrlId = 38
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 39,
                Name = "Bandit Captain",
                ChallengeRating = 2,
                UrlId = 39
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 40,
                Name = "Barbed Devil",
                ChallengeRating = 5,
                UrlId = 40
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 41,
                Name = "Basilisk",
                ChallengeRating = 3,
                UrlId = 41
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 42,
                Name = "Bat",
                ChallengeRating = 0,
                UrlId = 42
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 43,
                Name = "Bearded Devil",
                ChallengeRating = 3,
                UrlId = 43
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 44,
                Name = "Behir",
                ChallengeRating = 11,
                UrlId = 44
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 45,
                Name = "Berserker",
                ChallengeRating = 1,
                UrlId = 45
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 46,
                Name = "Black Bear",
                ChallengeRating = 0.5f,
                UrlId = 46
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 47,
                Name = "Black Dragon Wyrmling",
                ChallengeRating = 2,
                UrlId = 47
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 48,
                Name = "Black Pudding",
                ChallengeRating = 4,
                UrlId = 48
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 49,
                Name = "Blink Dog",
                ChallengeRating = .25f,
                UrlId = 49
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 50,
                Name = "Blood Hawk",
                ChallengeRating = 0.125f,
                UrlId = 50
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 51,
                Name = "Blue Dragon Wyrmling",
                ChallengeRating = 3,
                UrlId = 51
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 52,
                Name = "Boar",
                ChallengeRating = 0.25f,
                UrlId = 52
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 53,
                Name = "Bone Devil",
                ChallengeRating = 12,
                UrlId = 53
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 54,
                Name = "Brass Dragon Wyrmling",
                ChallengeRating = 1,
                UrlId = 54
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 55,
                Name = "Bronze Dragon Wyrmling",
                ChallengeRating = 2,
                UrlId = 55
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 56,
                Name = "Brown Bear",
                ChallengeRating = 1,
                UrlId = 56
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 57,
                Name = "Bugbear",
                ChallengeRating = 1,
                UrlId = 57
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 58,
                Name = "Bulette",
                ChallengeRating = 5,
                UrlId = 58
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 59,
                Name = "Camel",
                ChallengeRating = 0.125f,
                UrlId = 59
            });
            context.SaveChanges();

            base.Seed(context);
        }

    }
}

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
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 60,
                Name = "Carrion Crawler",
                ChallengeRating = 2,
                UrlId = 60
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 61,
                Name = "Cat",
                ChallengeRating = 0,
                UrlId = 61
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 62,
                Name = "Cave Bear",
                ChallengeRating = 2,
                UrlId = 62
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 63,
                Name = "Centaur",
                ChallengeRating = 2,
                UrlId = 63
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 64,
                Name = "Chain Devil",
                ChallengeRating = 11,
                UrlId = 64
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 65,
                Name = "Chimera",
                ChallengeRating = 6,
                UrlId = 65
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 66,
                Name = "Chuul",
                ChallengeRating = 4,
                UrlId = 66
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 67,
                Name = "Clay Golem",
                ChallengeRating = 9,
                UrlId = 67
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 68,
                Name = "Cloaker",
                ChallengeRating = 8,
                UrlId = 68
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 69,
                Name = "Cloud Giant",
                ChallengeRating = 9,
                UrlId = 69
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 70,
                Name = "Cockatrice",
                ChallengeRating = 0.5f,
                UrlId = 70
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 71,
                Name = "Commoner",
                ChallengeRating = 0,
                UrlId = 71
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 72,
                Name = "Constrictor Snake",
                ChallengeRating = 0.25f,
                UrlId = 72
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 73,
                Name = "Copper Dragon Wyrmling",
                ChallengeRating = 1,
                UrlId = 73
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 74,
                Name = "Couatl",
                ChallengeRating = 4,
                UrlId = 74
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 75,
                Name = "Crab",
                ChallengeRating = 0,
                UrlId = 75
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 76,
                Name = "Crocodile",
                ChallengeRating = 0.5f,
                UrlId = 76
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 77,
                Name = "Cult Fanatic",
                ChallengeRating = 2,
                UrlId = 77
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 78,
                Name = "Cultist",
                ChallengeRating = 0.125f,
                UrlId = 78
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 79,
                Name = "Darkmantle",
                ChallengeRating = 0.5f,
                UrlId = 79
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 80,
                Name = "Death Dog",
                ChallengeRating = 1,
                UrlId = 80
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 81,
                Name = "Deep Gnome (Svirfneblin)",
                ChallengeRating = 0.5f,
                UrlId = 81
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 82,
                Name = "Deer",
                ChallengeRating = 0,
                UrlId = 82
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 83,
                Name = "Deva",
                ChallengeRating = 10,
                UrlId = 83
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 84,
                Name = "Dire Wolf",
                ChallengeRating = 1,
                UrlId = 84
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 85,
                Name = "Djinni",
                ChallengeRating = 11,
                UrlId = 85
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 86,
                Name = "Doppelganger",
                ChallengeRating = 3,
                UrlId = 86
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 87,
                Name = "Draft Horse",
                ChallengeRating = 0.25f,
                UrlId = 87
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 88,
                Name = "Dragon Turtle",
                ChallengeRating = 17,
                UrlId = 88
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 89,
                Name = "Dretch",
                ChallengeRating = 0.25f,
                UrlId = 89
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 90,
                Name = "Drider",
                ChallengeRating = 6,
                UrlId = 90
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 91,
                Name = "Drow",
                ChallengeRating = 0.25f,
                UrlId = 91
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 92,
                Name = "Druid",
                ChallengeRating = 2,
                UrlId = 92
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 93,
                Name = "Dryad",
                ChallengeRating = 1,
                UrlId = 93
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 94,
                Name = "Duergar",
                ChallengeRating = 1,
                UrlId = 94
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 95,
                Name = "Dust Mephit",
                ChallengeRating = 0.5f,
                UrlId = 95
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 96,
                Name = "Eagle",
                ChallengeRating = 0,
                UrlId = 96
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 97,
                Name = "Earth Elemental",
                ChallengeRating = 5,
                UrlId = 97
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 98,
                Name = "Efreeti",
                ChallengeRating = 11,
                UrlId = 98
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 99,
                Name = "Elephant",
                ChallengeRating = 4,
                UrlId = 99
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 100,
                Name = "Elk",
                ChallengeRating = 0.25f,
                UrlId = 100
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 101,
                Name = "Erinyes",
                ChallengeRating = 12,
                UrlId = 101
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 102,
                Name = "Ettercap",
                ChallengeRating = 2,
                UrlId = 102
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 103,
                Name = "Ettin",
                ChallengeRating = 4,
                UrlId = 103
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 104,
                Name = "Fire Elemental",
                ChallengeRating = 5,
                UrlId = 104
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 105,
                Name = "Fire Giant",
                ChallengeRating = 9,
                UrlId = 105
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 106,
                Name = "Flesh Golem",
                ChallengeRating = 5,
                UrlId = 106
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 107,
                Name = "Flying Snake",
                ChallengeRating = 0.125f,
                UrlId = 107
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 108,
                Name = "Flying Sword",
                ChallengeRating = 0.25f,
                UrlId = 108
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 109,
                Name = "Frog",
                ChallengeRating = 0,
                UrlId = 109
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 110,
                Name = "Frost Giant",
                ChallengeRating = 9,
                UrlId = 110
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 111,
                Name = "Gargoyle",
                ChallengeRating = 2,
                UrlId = 111
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 112,
                Name = "Gelatinous Cube",
                ChallengeRating = 2,
                UrlId = 112
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 113,
                Name = "Ghast",
                ChallengeRating = 2,
                UrlId = 113
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 114,
                Name = "Ghost",
                ChallengeRating = 4,
                UrlId = 114
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 115,
                Name = "Ghoul",
                ChallengeRating = 1,
                UrlId = 115
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 116,
                Name = "Giant Ape",
                ChallengeRating = 7,
                UrlId = 116
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 117,
                Name = "Giant Badger",
                ChallengeRating = 0.25f,
                UrlId = 117
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 118,
                Name = "Giant Bat",
                ChallengeRating = 0.25f,
                UrlId = 118
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 119,
                Name = "Giant Boar",
                ChallengeRating = 2,
                UrlId = 119
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 120,
                Name = "Giant Centipede",
                ChallengeRating = 0.25f,
                UrlId = 120
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 121,
                Name = "Giant Constrictor Snake",
                ChallengeRating = 2,
                UrlId = 121
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 122,
                Name = "Giant Crab",
                ChallengeRating = 0.125f,
                UrlId = 122
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 123,
                Name = "Giant Crocodile",
                ChallengeRating = 5,
                UrlId = 123
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 124,
                Name = "Giant Eagle",
                ChallengeRating = 1,
                UrlId = 124
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 125,
                Name = "Giant Elk",
                ChallengeRating = 2,
                UrlId = 125
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 126,
                Name = "Giant Fire Beetle",
                ChallengeRating = 0,
                UrlId = 126
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 127,
                Name = "Giant Frog",
                ChallengeRating = 0.25f,
                UrlId = 127
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 128,
                Name = "Giant Goat",
                ChallengeRating = 0.5f,
                UrlId = 128
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 129,
                Name = "Giant Hyena",
                ChallengeRating = 1,
                UrlId = 129
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 130,
                Name = "Giant Lizard",
                ChallengeRating = 0.25f,
                UrlId = 130
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 131,
                Name = "Giant Octopus",
                ChallengeRating = 1,
                UrlId = 131
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 132,
                Name = "Giant Owl",
                ChallengeRating = 0.25f,
                UrlId = 132
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 133,
                Name = "Giant Poisonous Snake",
                ChallengeRating = 0.25f,
                UrlId = 133
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 134,
                Name = "Giant Rat",
                ChallengeRating = 0.125f,
                UrlId = 134
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 135,
                Name = "Giant Rat (Diseased)",
                ChallengeRating = 0.125f,
                UrlId = 135
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 136,
                Name = "Giant Scorpion",
                ChallengeRating = 3,
                UrlId = 136
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 137,
                Name = "Giant Sea Horse",
                ChallengeRating = 0.5f,
                UrlId = 137
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 138,
                Name = "Giant Shark",
                ChallengeRating = 5,
                UrlId = 138
            });
            context.Monsters.Add(new MonsterDataModel()
            {
                Id = 139,
                Name = "Giant Spider",
                ChallengeRating = 1,
                UrlId = 139
            });
            context.SaveChanges();

            base.Seed(context);
        }

    }
}

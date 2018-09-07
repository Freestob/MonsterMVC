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
            context.SaveChanges();

            base.Seed(context);
        }

    }
}

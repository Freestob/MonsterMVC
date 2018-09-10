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
            context.SaveChanges();


            context.Encounters.Add(new Encounter()
            {
                Id = 1,

            });
            context.SaveChanges();

            context.ActiveMonsters.Add(new ActiveMonster()
            {
                Id = 1,
                EncounterId = 1,
                MonsterId = 1,
                HealthPoints = 10,
                IsAlive = true
            });

            base.Seed(context);
        }

    }
}

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
            context.SaveChanges();

            base.Seed(context);
        }

    }
}

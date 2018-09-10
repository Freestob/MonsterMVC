using MonsterMVC.Domain.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterMVC.Data.Maps
{
    internal class EncounterMap : EntityTypeConfiguration<Encounter>
    {
        public EncounterMap()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            HasMany(x => x.ActiveMonsters)
                .WithRequired(x => x.Encounter)
                .HasForeignKey(x => x.EncounterId);
        }
    }
}

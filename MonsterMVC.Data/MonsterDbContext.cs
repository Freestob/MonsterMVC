﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonsterMVC.Data.Maps;
using MonsterMVC.Domain.Data;

namespace MonsterMVC.Data
{
    class MonsterDbContext : DbContext
    {
        public MonsterDbContext() : base("MonsterDataBase")
        {
            //Drop the database and recreate on each run
            //Database.SetInitializer(new DropCreateDatabaseAlways<MonsterDbContext>());
            // Create the DB if it doesn't exist.  
            Database.SetInitializer(new CreateDatabaseIfNotExists<MonsterDbContext>());
            //Will Drop and recreate if model changes.
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<MonsterDbContext>());
            //Custom Initializer
            Database.SetInitializer(new MonsterDbInitializer());
        }

        public DbSet<MonsterDataModel> Monsters {get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new MonsterMap());
            base.OnModelCreating(modelBuilder);

        }
    }
}
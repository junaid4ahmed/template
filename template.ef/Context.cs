﻿using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace template.ef {
  public class Context
    : DbContext {

    public Context()
     : base(nameOrConnectionString: "template.ef") {

      Configuration.ProxyCreationEnabled = true;
      Database.SetInitializer<Context>(new Initializer());

      //Database.Log = Console.Write;
    }

    public DbSet<Entities.category> Categories { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {

      // Configuration
      modelBuilder.Configurations.Add(new Configurations.category());

      // Convention
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

      base.OnModelCreating(modelBuilder);
    }

  }
}
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace template.ef {
  public class Context
    : DbContext {

    public Context()
     : base(nameOrConnectionString: "template.ef") {

      Configuration.ProxyCreationEnabled = true;
      Database.SetInitializer<Context>(new Initializer());

      // to see what framework is generating for database in console
      Database.Log = System.Console.Write;
    }

    public DbSet<Entities.category> Categories { get; set; }
    public DbSet<Entities.product> Products { get; set; }

    protected override void OnModelCreating(DbModelBuilder modelBuilder) {

      // Configuration
      modelBuilder.Configurations.Add(new Configurations.category());
      modelBuilder.Configurations.Add(new Configurations.product());

      // Convention
      modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
      base.OnModelCreating(modelBuilder);
    }

  }
}

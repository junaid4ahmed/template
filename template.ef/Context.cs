using System.Data.Entity;

namespace template.ef {
  public class Context
    : DbContext {

    public Context()
     : base(nameOrConnectionString: "template.ef") {

      Configuration.ProxyCreationEnabled = true;
      Database.SetInitializer<Context>(new Initializer());

      //Database.Log = Console.Write;

    }
  }
}
